using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MPCShortcutCreator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void openFilesBtn_Click(object sender, EventArgs e)
		{
			var fileFolderDialog = new FileFolderDialog();

			if (fileFolderDialog.ShowDialog() == DialogResult.OK)
			{
				string[] selectedPaths = openFileDialog.FileNames;

				foreach (var selectedPath in selectedPaths)
				{
					objectListBox.Items.Add(selectedPath);
				}
			}
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string file in files) objectListBox.Items.Add(file);
		}

		private void createShortcutsBtn_Click(object sender, EventArgs e)
		{
			if (objectListBox.Items.Count == 0)
			{
				MessageBox.Show(
					"Список объектов пуст. \n\nПеретащите в окно программы файлы и папки, для которых хотите создать ярлыки.");
			}
			else
				if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
				{
					int index = 0;
					for (int i = 0; i < objectListBox.Items.Count; i++)
					{
						var item = (string) objectListBox.Items[0];
						bool isSuccess = CreateShortcut(
							Path.GetFileName(item) == "" ? Path.GetDirectoryName(item) : Path.GetFileName(item),
							folderBrowserDialog1.SelectedPath, item, textBox1.Text);
						if (isSuccess)
							objectListBox.Items.RemoveAt(index);
						else
							index++;
					}
				}
		}

		public static bool CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string mpcPath)
		{
			try
			{
				string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
				WshShell shell = new WshShell();

				IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

				shortcut.Description = "My shortcut description"; // The description of the shortcut
				shortcut.IconLocation = Environment.CurrentDirectory + "\\MPC_icon.ico"; // The icon of the shortcut
				shortcut.TargetPath = mpcPath;
				shortcut.Arguments = String.Format("\"{0}\"", targetFileLocation);

				shortcut.Save(); // Save the shortcut

				return true;
			}
			catch (Exception e)
			{
				MessageBox.Show("Произошла ошибка создания ярлыка.\n" + e.Message, "Ошибка");
				return false;
			} 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = openFileDialog.FileName;
			}
		}

		private void deleteItemBtn_Click(object sender, EventArgs e)
		{
			while (objectListBox.SelectedItems.Count != 0)
			{
				objectListBox.Items.Remove(objectListBox.SelectedItems[0]);
			}
		}

		private void clearListBtn_Click(object sender, EventArgs e)
		{
			objectListBox.Items.Clear();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			objectListBox.Items.Clear();
		}
	}
}
