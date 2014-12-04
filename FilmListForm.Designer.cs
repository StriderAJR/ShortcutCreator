namespace MPCShortcutCreator
{
	partial class FilmListForm
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
			this.filmListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// filmListBox
			// 
			this.filmListBox.FormattingEnabled = true;
			this.filmListBox.Location = new System.Drawing.Point(12, 12);
			this.filmListBox.Name = "filmListBox";
			this.filmListBox.Size = new System.Drawing.Size(484, 420);
			this.filmListBox.TabIndex = 0;
			// 
			// FilmListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 442);
			this.Controls.Add(this.filmListBox);
			this.Name = "FilmListForm";
			this.Text = "FilmListForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox filmListBox;
	}
}