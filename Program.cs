using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MPCShortcutCreator
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				OpenFilmDir(args[0]);
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new SecondForm());
			}
		}

		static void OpenFilmDir(string fileName)
		{
			WshShell shell = new WshShell();

			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(fileName);
			string dirName = shortcut.Arguments;
			dirName = dirName.Trim(new char[]{'\"'});

			if (Path.HasExtension(dirName))
				dirName = Path.GetDirectoryName(dirName);


			Process.Start(dirName);
		}
	}
}
