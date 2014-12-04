using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MPCShortcutCreator
{
	public partial class SecondForm : Form
	{
		private const string IniFilePath = "settings.ini";
		private const string FolderNamesFilePath = "folders.txt";

		private const string MainIniSection = "Settings";
		private const string PlayerFolderPathIniKey = "PlayerFolderPath";
		private const string ShortcutFolderPathIniKey = "ShortcutFolderPath";
		private const string ShortcutFolderPrefixIniKey = "ShortcutFolderPrefix";
		private const string CollectionFolderNameIniKey = "CollectionFolderName";
		private const string SeriesFolderNameIniKey = "SeriesFolderName";
		private const string FileExtensionsToSkipIniKey = "FileExtensionsToSkip";
		private const char Separator = ',';

		private void SaveSettingsToIniFile()
		{
			IniFile iniFIle = new IniFile(Application.StartupPath + "\\" + IniFilePath);
			iniFIle.IniWriteValue(MainIniSection, PlayerFolderPathIniKey, playerPathTextBox.Text);
			iniFIle.IniWriteValue(MainIniSection, ShortcutFolderPathIniKey, shortcutFolderPathTextBox.Text);
			iniFIle.IniWriteValue(MainIniSection, ShortcutFolderPrefixIniKey, shortcutFolderPrefixTextBox.Text);
			iniFIle.IniWriteValue(MainIniSection, CollectionFolderNameIniKey, collectionFolderNameTextBox.Text);
			iniFIle.IniWriteValue(MainIniSection, SeriesFolderNameIniKey, seriesFolderNameTextBox.Text);
			iniFIle.IniWriteValue(MainIniSection, FileExtensionsToSkipIniKey, fileExtensionsToSkipTextBox.Text);
		}

		private void LoadSettingsFromIniFile()
		{
			IniFile iniFIle = new IniFile(Application.StartupPath + "\\" + IniFilePath);
			playerPathTextBox.Text = iniFIle.IniReadValue(MainIniSection, PlayerFolderPathIniKey);
			shortcutFolderPathTextBox.Text = iniFIle.IniReadValue(MainIniSection, ShortcutFolderPathIniKey);
			shortcutFolderPrefixTextBox.Text = iniFIle.IniReadValue(MainIniSection, ShortcutFolderPrefixIniKey);
			collectionFolderNameTextBox.Text = iniFIle.IniReadValue(MainIniSection, CollectionFolderNameIniKey);
			seriesFolderNameTextBox.Text = iniFIle.IniReadValue(MainIniSection, SeriesFolderNameIniKey);
			fileExtensionsToSkipTextBox.Text = iniFIle.IniReadValue(MainIniSection, FileExtensionsToSkipIniKey);
		}

		private void LoadFoldersListFromFile()
		{
			objectListBox.Items.Clear();
			if (System.IO.File.Exists(FolderNamesFilePath))
			{
				StreamReader file = new StreamReader(FolderNamesFilePath);
				string line;
				while ((line = file.ReadLine()) != null)
				{
					objectListBox.Items.Add(line);
				}
				file.Close();
			}
		}

		private void SaveFoldersListToFile()
		{
			StringBuilder sb = new StringBuilder();
			foreach (string folderName in objectListBox.Items)
			{
				sb.AppendLine(folderName);
			}
			
			using (StreamWriter outfile = new StreamWriter(FolderNamesFilePath))
			{
				outfile.Write(sb.ToString());
			}
		}

		public SecondForm()
		{
			InitializeComponent();

			if (System.IO.File.Exists(IniFilePath))
				LoadSettingsFromIniFile();
			else
				SaveSettingsToIniFile();

			LoadFoldersListFromFile();

			if (objectListBox.Items.Count != 0)
			{
				var items = objectListBox.Items.OfType<string>().GroupBy(item => item).ToList();
				objectListBox.Items.Clear();
				foreach (var item in items)
					objectListBox.Items.Add(item.Key);
				objectListBox.Sorted = true;
			}
		}

		private void SecondForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		private void SecondForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			foreach (string file in files) objectListBox.Items.Add(file);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			List<string> filmList = new List<string>();

			foreach (string folderName in objectListBox.Items)
			{
				filmList.AddRange(Directory.GetDirectories(folderName));
				filmList.AddRange(Directory.GetFiles(folderName));
			}

			FilmListForm filmListForm = new FilmListForm(filmList);
			filmListForm.Show();
		}

		private void shortcutFolderSelectBtn_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				shortcutFolderPathTextBox.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void playerFolderSelectBtn_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				playerPathTextBox.Text = openFileDialog.FileName;
			}
		}

		private void createShortcutsBtn_Click(object sender, EventArgs e)
		{
			if (objectListBox.Items.Count == 0)
			{
				MessageBox.Show(
					"Список объектов пуст. \n\nПеретащите в окно программы папки, для которых хотите создать ярлыки.");
			}
			else
			{
				int overAllCount = 0;
				int successCount = 0;
				int soundFilesCount = 0;
				int collectionItemsCount = 0;

				List<string> errorFiles = new List<string>();

				SaveSettingsToIniFile();

				// Записываем все отслеживаемые пути в файл, чтобы потом их оттуда считывать при открытии программы
				using (FileStream fs = new FileStream(FolderNamesFilePath, FileMode.Create, FileAccess.Write))
				using (StreamWriter sw = new StreamWriter(fs))
					foreach (string folderName in objectListBox.Items)
						sw.WriteLine(folderName);

				List<string> fileExtensions =
					fileExtensionsToSkipTextBox.Text.Split(new[] { Separator }).Select(str => str.Trim().ToLower()).ToList();
				List<string> collectionNames =
					collectionFolderNameTextBox.Text.Split(new[] { Separator }).Select(str => str.Trim().ToLower()).ToList();
				List<string> seriesNames =
					seriesFolderNameTextBox.Text.Split(new[] { Separator }).Select(str => str.Trim().ToLower()).ToList();

				// Находим одинаковые имена конечных папок
				foreach (string fullFolderName in objectListBox.Items)
				{
					string fullPath = Path.GetFullPath(fullFolderName).TrimEnd(Path.DirectorySeparatorChar);
					string folderName = fullPath.Split(Path.DirectorySeparatorChar).Last();

					string fullShortcutFolderName = shortcutFolderPathTextBox.Text + shortcutFolderPrefixTextBox.Text + " " + folderName;

					if (!Directory.Exists(fullShortcutFolderName))
						Directory.CreateDirectory(fullShortcutFolderName);

					List<string> filmList = new List<string>();

					filmList.AddRange(Directory.GetDirectories(fullFolderName));
					filmList.AddRange(Directory.GetFiles(fullFolderName));

					overAllCount += filmList.Count;

					foreach (var item in filmList)
					{
						string itemFullPath = Path.GetFullPath(item).TrimEnd(Path.DirectorySeparatorChar);
						string itemName = itemFullPath.Split(Path.DirectorySeparatorChar).Last();

						bool isCollectionFolder = collectionNames.Any(itemName.ToLower().Contains);

						if (isCollectionFolder)
						{
							List<string> collectionItems = new List<string>();
							collectionItems.AddRange(Directory.GetDirectories(itemFullPath));
							collectionItems.AddRange(Directory.GetFiles(itemFullPath));

							if (!Directory.Exists(fullShortcutFolderName + "\\" + itemName))
								Directory.CreateDirectory(fullShortcutFolderName + "\\" + itemName);

							collectionItemsCount += collectionItems.Count;

							foreach (var collectionItem in collectionItems)
							{
								try
								{
									bool isSuccess = CreateShortcut(collectionItem, fullShortcutFolderName + "\\" + itemName, playerPathTextBox.Text, fileExtensions);
									if (isSuccess)
										successCount++;
									else
										soundFilesCount++;
								}
								catch (Exception)
								{
									errorFiles.Add(item);
								}
							}
						}
						else
						{
							try
							{
								bool isSuccess;

								if (seriesNames.Any(fullFolderName.ToLower().Contains))
									isSuccess = CreateShortcut(item, fullShortcutFolderName, "", fileExtensions);
								else
									isSuccess = CreateShortcut(item, fullShortcutFolderName, playerPathTextBox.Text, fileExtensions);

								if (isSuccess)
									successCount++;
								else
									soundFilesCount++;
							}
							catch (Exception)
							{
								errorFiles.Add(item);
							}
						}
					}
				}

				string message = String.Format("Для {0} файлов было создано {1} ярлык(ов).\nИз них\n{2} аудио-дорожки,\n{3} фильмы из состава коллекций.",
											   overAllCount, successCount, soundFilesCount, collectionItemsCount);
				if (errorFiles.Count != 0)
				{
					message += "\n\nДля следующих файлов ярлыки не были созданы:";
					foreach (var errorFile in errorFiles)
						message += errorFile + "\n";
				}

				MessageBox.Show(message);
			}
		}

		public static bool CreateShortcut(string targetFileLocation, string shortcutPath, string mpcPath,
										  List<string> fileExtensions)
		{
			string shortcutName = Path.GetFileName(targetFileLocation) == ""
									  ? Path.GetDirectoryName(targetFileLocation)
									  : Path.GetFileName(targetFileLocation);

			var extension = Path.GetExtension(targetFileLocation);
			if (extension != null && !fileExtensions.Contains(extension.Replace(".", "")))
			{
				string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
				WshShell shell = new WshShell();

				IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

				shortcut.Description = "My shortcut description"; // The description of the shortcut
				shortcut.IconLocation = Environment.CurrentDirectory + "\\MPC_icon.ico"; // The icon of the shortcut

				if (String.IsNullOrEmpty(mpcPath))
					shortcut.TargetPath = targetFileLocation;
				else
				{
					shortcut.TargetPath = mpcPath;
					shortcut.Arguments = String.Format("\"{0}\"", targetFileLocation);
				}
				shortcut.Save(); // Save the shortcut

				return true;
			}
			return false;
		}

		private void DeleteShortcutsBtn_Click(object sender, EventArgs e)
		{
			foreach (string fullFolderName in objectListBox.Items)
			{
				string fullPath = Path.GetFullPath(fullFolderName).TrimEnd(Path.DirectorySeparatorChar);
				string folderName = fullPath.Split(Path.DirectorySeparatorChar).Last();

				string fullShortcutFolderName = shortcutFolderPathTextBox.Text + shortcutFolderPrefixTextBox.Text + " " + folderName;

				if (Directory.Exists(fullShortcutFolderName))
					Directory.Delete(fullShortcutFolderName, true);
			}
			MessageBox.Show("Все ярлыки были удалены.");
		}

		private void saveSettingsBtn_Click(object sender, EventArgs e)
		{
			SaveSettingsToIniFile();
			SaveFoldersListToFile();
		}

		private void loadSettingsBtn_Click(object sender, EventArgs e)
		{
			LoadSettingsFromIniFile();
			LoadFoldersListFromFile();
		}

		private void deleteItemBtn_Click(object sender, EventArgs e)
		{
			List<object> tempList = new List<object>();
			foreach (var item in objectListBox.Items)
			{
				tempList.Add(item.ToString());
			}

			foreach (var item in objectListBox.SelectedItems)
				tempList.Remove(item.ToString());

			objectListBox.Items.Clear();

			foreach (var item in tempList)
			{
				objectListBox.Items.Add(item);
			}
		}

		private void clearListBtn_Click(object sender, EventArgs e)
		{
			objectListBox.Items.Clear();
		}
	}
}
