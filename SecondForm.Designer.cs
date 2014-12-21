namespace MPCShortcutCreator
{
	partial class SecondForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.objectListBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.playerFolderSelectBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.playerPathTextBox = new System.Windows.Forms.TextBox();
			this.shortcutFolderSelectBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.shortcutFolderPathTextBox = new System.Windows.Forms.TextBox();
			this.deleteItemBtn = new System.Windows.Forms.Button();
			this.clearListBtn = new System.Windows.Forms.Button();
			this.createShortcutsBtn = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.deleteShortcutsBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.shortcutFolderPrefixTextBox = new System.Windows.Forms.TextBox();
			this.saveSettingsBtn = new System.Windows.Forms.Button();
			this.collectionFolderNameTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.fileExtensionsToSkipTextBox = new System.Windows.Forms.TextBox();
			this.loadSettingsBtn = new System.Windows.Forms.Button();
			this.seriesFolderNameTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.commandNameTextBox = new System.Windows.Forms.TextBox();
			this.commandPathTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.createRegistryCommandButton = new System.Windows.Forms.Button();
			this.deleteRegistryCommand = new System.Windows.Forms.Button();
			this.commandKeyTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// objectListBox
			// 
			this.objectListBox.FormattingEnabled = true;
			this.objectListBox.Location = new System.Drawing.Point(12, 25);
			this.objectListBox.Name = "objectListBox";
			this.objectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.objectListBox.Size = new System.Drawing.Size(601, 264);
			this.objectListBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(258, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Перетащите папки, которые нужно отслеживать:";
			// 
			// playerFolderSelectBtn
			// 
			this.playerFolderSelectBtn.Location = new System.Drawing.Point(701, 472);
			this.playerFolderSelectBtn.Name = "playerFolderSelectBtn";
			this.playerFolderSelectBtn.Size = new System.Drawing.Size(28, 23);
			this.playerFolderSelectBtn.TabIndex = 11;
			this.playerFolderSelectBtn.Text = "...";
			this.playerFolderSelectBtn.UseVisualStyleBackColor = true;
			this.playerFolderSelectBtn.Click += new System.EventHandler(this.playerFolderSelectBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 456);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Путь до Media Player Classic:";
			// 
			// playerPathTextBox
			// 
			this.playerPathTextBox.Location = new System.Drawing.Point(12, 472);
			this.playerPathTextBox.Name = "playerPathTextBox";
			this.playerPathTextBox.Size = new System.Drawing.Size(682, 20);
			this.playerPathTextBox.TabIndex = 9;
			this.playerPathTextBox.Text = "C:\\Program Files (x86)\\K-Lite Codec Pack\\MPC-HC64\\mpc-hc64.exe";
			// 
			// shortcutFolderSelectBtn
			// 
			this.shortcutFolderSelectBtn.Location = new System.Drawing.Point(701, 555);
			this.shortcutFolderSelectBtn.Name = "shortcutFolderSelectBtn";
			this.shortcutFolderSelectBtn.Size = new System.Drawing.Size(28, 23);
			this.shortcutFolderSelectBtn.TabIndex = 14;
			this.shortcutFolderSelectBtn.Text = "...";
			this.shortcutFolderSelectBtn.UseVisualStyleBackColor = true;
			this.shortcutFolderSelectBtn.Click += new System.EventHandler(this.shortcutFolderSelectBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 539);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Путь до папки с ярлыками:";
			// 
			// shortcutFolderPathTextBox
			// 
			this.shortcutFolderPathTextBox.Location = new System.Drawing.Point(12, 555);
			this.shortcutFolderPathTextBox.Name = "shortcutFolderPathTextBox";
			this.shortcutFolderPathTextBox.Size = new System.Drawing.Size(682, 20);
			this.shortcutFolderPathTextBox.TabIndex = 12;
			// 
			// deleteItemBtn
			// 
			this.deleteItemBtn.Location = new System.Drawing.Point(619, 25);
			this.deleteItemBtn.Name = "deleteItemBtn";
			this.deleteItemBtn.Size = new System.Drawing.Size(110, 23);
			this.deleteItemBtn.TabIndex = 16;
			this.deleteItemBtn.Text = "Удалить";
			this.deleteItemBtn.UseVisualStyleBackColor = true;
			this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
			// 
			// clearListBtn
			// 
			this.clearListBtn.Location = new System.Drawing.Point(619, 54);
			this.clearListBtn.Name = "clearListBtn";
			this.clearListBtn.Size = new System.Drawing.Size(110, 23);
			this.clearListBtn.TabIndex = 15;
			this.clearListBtn.Text = "Очистить список";
			this.clearListBtn.UseVisualStyleBackColor = true;
			this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
			// 
			// createShortcutsBtn
			// 
			this.createShortcutsBtn.Location = new System.Drawing.Point(221, 581);
			this.createShortcutsBtn.Name = "createShortcutsBtn";
			this.createShortcutsBtn.Size = new System.Drawing.Size(110, 37);
			this.createShortcutsBtn.TabIndex = 17;
			this.createShortcutsBtn.Text = "Создать ярлыки";
			this.createShortcutsBtn.UseVisualStyleBackColor = true;
			this.createShortcutsBtn.Click += new System.EventHandler(this.createShortcutsBtn_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(619, 118);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 37);
			this.button3.TabIndex = 18;
			this.button3.Text = "Показать список файлов";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// deleteShortcutsBtn
			// 
			this.deleteShortcutsBtn.Location = new System.Drawing.Point(406, 581);
			this.deleteShortcutsBtn.Name = "deleteShortcutsBtn";
			this.deleteShortcutsBtn.Size = new System.Drawing.Size(110, 37);
			this.deleteShortcutsBtn.TabIndex = 19;
			this.deleteShortcutsBtn.Text = "Удалить все ярлыки";
			this.deleteShortcutsBtn.UseVisualStyleBackColor = true;
			this.deleteShortcutsBtn.Click += new System.EventHandler(this.DeleteShortcutsBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 499);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Префикс папок с ярлыками:";
			// 
			// shortcutFolderPrefixTextBox
			// 
			this.shortcutFolderPrefixTextBox.Location = new System.Drawing.Point(12, 516);
			this.shortcutFolderPrefixTextBox.Name = "shortcutFolderPrefixTextBox";
			this.shortcutFolderPrefixTextBox.Size = new System.Drawing.Size(682, 20);
			this.shortcutFolderPrefixTextBox.TabIndex = 21;
			this.shortcutFolderPrefixTextBox.Text = "TEST";
			// 
			// saveSettingsBtn
			// 
			this.saveSettingsBtn.Location = new System.Drawing.Point(619, 209);
			this.saveSettingsBtn.Name = "saveSettingsBtn";
			this.saveSettingsBtn.Size = new System.Drawing.Size(110, 37);
			this.saveSettingsBtn.TabIndex = 22;
			this.saveSettingsBtn.Text = "Сохранить настройки";
			this.saveSettingsBtn.UseVisualStyleBackColor = true;
			this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
			// 
			// collectionFolderNameTextBox
			// 
			this.collectionFolderNameTextBox.Location = new System.Drawing.Point(12, 308);
			this.collectionFolderNameTextBox.Name = "collectionFolderNameTextBox";
			this.collectionFolderNameTextBox.Size = new System.Drawing.Size(682, 20);
			this.collectionFolderNameTextBox.TabIndex = 23;
			this.collectionFolderNameTextBox.Text = "Антология, Дилогия, Трилогия";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(293, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "Названия в именах папок с собранием (через запятую):";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 393);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(278, 13);
			this.label6.TabIndex = 26;
			this.label6.Text = "Пропускать файлы с расширениями (через запятую):";
			// 
			// fileExtensionsToSkipTextBox
			// 
			this.fileExtensionsToSkipTextBox.Location = new System.Drawing.Point(12, 409);
			this.fileExtensionsToSkipTextBox.Name = "fileExtensionsToSkipTextBox";
			this.fileExtensionsToSkipTextBox.Size = new System.Drawing.Size(682, 20);
			this.fileExtensionsToSkipTextBox.TabIndex = 25;
			this.fileExtensionsToSkipTextBox.Text = "ac3, dts";
			// 
			// loadSettingsBtn
			// 
			this.loadSettingsBtn.Location = new System.Drawing.Point(619, 252);
			this.loadSettingsBtn.Name = "loadSettingsBtn";
			this.loadSettingsBtn.Size = new System.Drawing.Size(110, 37);
			this.loadSettingsBtn.TabIndex = 22;
			this.loadSettingsBtn.Text = "Загрузить настройки";
			this.loadSettingsBtn.UseVisualStyleBackColor = true;
			this.loadSettingsBtn.Click += new System.EventHandler(this.loadSettingsBtn_Click);
			// 
			// seriesFolderNameTextBox
			// 
			this.seriesFolderNameTextBox.Location = new System.Drawing.Point(12, 349);
			this.seriesFolderNameTextBox.Name = "seriesFolderNameTextBox";
			this.seriesFolderNameTextBox.Size = new System.Drawing.Size(682, 20);
			this.seriesFolderNameTextBox.TabIndex = 23;
			this.seriesFolderNameTextBox.Text = "Сериалы";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 333);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(363, 13);
			this.label7.TabIndex = 24;
			this.label7.Text = "Названия в именах папок, для которых не требуется привязка к MPC";
			// 
			// commandNameTextBox
			// 
			this.commandNameTextBox.Location = new System.Drawing.Point(15, 646);
			this.commandNameTextBox.Name = "commandNameTextBox";
			this.commandNameTextBox.Size = new System.Drawing.Size(682, 20);
			this.commandNameTextBox.TabIndex = 25;
			this.commandNameTextBox.Text = "Открыть расположение фильма";
			// 
			// commandPathTextBox
			// 
			this.commandPathTextBox.Location = new System.Drawing.Point(15, 691);
			this.commandPathTextBox.Name = "commandPathTextBox";
			this.commandPathTextBox.Size = new System.Drawing.Size(682, 20);
			this.commandPathTextBox.TabIndex = 25;
			this.commandPathTextBox.Text = "\"F:\\ShortcutCreator\\bin\\Debug\\MPCShortcutCreator.exe\" \"%L\"";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 630);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(166, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Комманда контекстного меню:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 671);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(160, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Исполняемый файл команды:";
			// 
			// createRegistryCommandButton
			// 
			this.createRegistryCommandButton.Location = new System.Drawing.Point(221, 715);
			this.createRegistryCommandButton.Name = "createRegistryCommandButton";
			this.createRegistryCommandButton.Size = new System.Drawing.Size(110, 37);
			this.createRegistryCommandButton.TabIndex = 17;
			this.createRegistryCommandButton.Text = "Создать запись в реестре";
			this.createRegistryCommandButton.UseVisualStyleBackColor = true;
			this.createRegistryCommandButton.Click += new System.EventHandler(this.createRegistryCommandButton_Click);
			// 
			// deleteRegistryCommand
			// 
			this.deleteRegistryCommand.Location = new System.Drawing.Point(406, 715);
			this.deleteRegistryCommand.Name = "deleteRegistryCommand";
			this.deleteRegistryCommand.Size = new System.Drawing.Size(110, 37);
			this.deleteRegistryCommand.TabIndex = 19;
			this.deleteRegistryCommand.Text = "Удалить запись в реестре";
			this.deleteRegistryCommand.UseVisualStyleBackColor = true;
			this.deleteRegistryCommand.Click += new System.EventHandler(this.deleteRegistryCommand_Click);
			// 
			// commandKeyTextBox
			// 
			this.commandKeyTextBox.Location = new System.Drawing.Point(12, 732);
			this.commandKeyTextBox.Name = "commandKeyTextBox";
			this.commandKeyTextBox.Size = new System.Drawing.Size(166, 20);
			this.commandKeyTextBox.TabIndex = 27;
			this.commandKeyTextBox.Text = "OpenFilmDir";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 716);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Ключ реестра:";
			// 
			// SecondForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 764);
			this.Controls.Add(this.commandKeyTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.commandNameTextBox);
			this.Controls.Add(this.commandPathTextBox);
			this.Controls.Add(this.fileExtensionsToSkipTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.seriesFolderNameTextBox);
			this.Controls.Add(this.collectionFolderNameTextBox);
			this.Controls.Add(this.loadSettingsBtn);
			this.Controls.Add(this.saveSettingsBtn);
			this.Controls.Add(this.shortcutFolderPrefixTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.deleteRegistryCommand);
			this.Controls.Add(this.deleteShortcutsBtn);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.createRegistryCommandButton);
			this.Controls.Add(this.createShortcutsBtn);
			this.Controls.Add(this.deleteItemBtn);
			this.Controls.Add(this.clearListBtn);
			this.Controls.Add(this.shortcutFolderSelectBtn);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.shortcutFolderPathTextBox);
			this.Controls.Add(this.playerFolderSelectBtn);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.playerPathTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.objectListBox);
			this.Name = "SecondForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SecondForm";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SecondForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SecondForm_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox objectListBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button playerFolderSelectBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox playerPathTextBox;
		private System.Windows.Forms.Button shortcutFolderSelectBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox shortcutFolderPathTextBox;
		private System.Windows.Forms.Button deleteItemBtn;
		private System.Windows.Forms.Button clearListBtn;
		private System.Windows.Forms.Button createShortcutsBtn;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button deleteShortcutsBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox shortcutFolderPrefixTextBox;
		private System.Windows.Forms.Button saveSettingsBtn;
		private System.Windows.Forms.TextBox collectionFolderNameTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox fileExtensionsToSkipTextBox;
		private System.Windows.Forms.Button loadSettingsBtn;
		private System.Windows.Forms.TextBox seriesFolderNameTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox commandNameTextBox;
		private System.Windows.Forms.TextBox commandPathTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button createRegistryCommandButton;
		private System.Windows.Forms.Button deleteRegistryCommand;
		private System.Windows.Forms.TextBox commandKeyTextBox;
		private System.Windows.Forms.Label label10;
	}
}