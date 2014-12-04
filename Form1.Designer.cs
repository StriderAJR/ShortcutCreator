namespace MPCShortcutCreator
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.objectListBox = new System.Windows.Forms.ListBox();
			this.createShortcutsBtn = new System.Windows.Forms.Button();
			this.saveShortcutsDialog = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.clearListBtn = new System.Windows.Forms.Button();
			this.deleteItemBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.InitialDirectory = "C:\\";
			this.openFileDialog.RestoreDirectory = true;
			this.openFileDialog.Title = "Выбор файлов и папок...";
			// 
			// objectListBox
			// 
			this.objectListBox.FormattingEnabled = true;
			this.objectListBox.Items.AddRange(new object[] {
            " "});
			this.objectListBox.Location = new System.Drawing.Point(12, 38);
			this.objectListBox.Name = "objectListBox";
			this.objectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.objectListBox.Size = new System.Drawing.Size(601, 355);
			this.objectListBox.TabIndex = 1;
			// 
			// createShortcutsBtn
			// 
			this.createShortcutsBtn.Location = new System.Drawing.Point(289, 487);
			this.createShortcutsBtn.Name = "createShortcutsBtn";
			this.createShortcutsBtn.Size = new System.Drawing.Size(168, 23);
			this.createShortcutsBtn.TabIndex = 2;
			this.createShortcutsBtn.Text = "Создать ярлыки";
			this.createShortcutsBtn.UseVisualStyleBackColor = true;
			this.createShortcutsBtn.Click += new System.EventHandler(this.createShortcutsBtn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 433);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(682, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "C:\\Program Files (x86)\\K-Lite Codec Pack\\Media Player Classic\\mpc-hc.exe";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 417);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Путь до Media Player Classic:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(283, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Перетащите файлы или папки для создания ярлыков:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(701, 433);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// clearListBtn
			// 
			this.clearListBtn.Location = new System.Drawing.Point(619, 67);
			this.clearListBtn.Name = "clearListBtn";
			this.clearListBtn.Size = new System.Drawing.Size(110, 23);
			this.clearListBtn.TabIndex = 9;
			this.clearListBtn.Text = "Очистить список";
			this.clearListBtn.UseVisualStyleBackColor = true;
			this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
			// 
			// deleteItemBtn
			// 
			this.deleteItemBtn.Location = new System.Drawing.Point(619, 38);
			this.deleteItemBtn.Name = "deleteItemBtn";
			this.deleteItemBtn.Size = new System.Drawing.Size(110, 23);
			this.deleteItemBtn.TabIndex = 10;
			this.deleteItemBtn.Text = "Удалить";
			this.deleteItemBtn.UseVisualStyleBackColor = true;
			this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 522);
			this.Controls.Add(this.deleteItemBtn);
			this.Controls.Add(this.clearListBtn);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.createShortcutsBtn);
			this.Controls.Add(this.objectListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MPC Shortcut Creator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ListBox objectListBox;
		private System.Windows.Forms.Button createShortcutsBtn;
		private System.Windows.Forms.SaveFileDialog saveShortcutsDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button clearListBtn;
		private System.Windows.Forms.Button deleteItemBtn;
	}
}

