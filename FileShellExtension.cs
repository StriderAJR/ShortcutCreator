using System.Diagnostics;
using Microsoft.Win32;

/*
// sample usage to register
// get full path to self, %L is a placeholder for the selected file
string menuCommand = string.Format("\"{0}\" \"%L\"", Application.ExecutablePath);
FileShellExtension.Register("jpegfile", "Simple Context Menu", "Copy to Grayscale", menuCommand);

// sample usage to unregister
FileShellExtension.Unregister("jpegfile", "Simple Context Menu");
 */

static class FileShellExtension
{
	public static void Register(string fileType, string shellKeyName, string menuText, string menuCommand)
	{
		// create path to registry location
		string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

		// add context menu to the registry
		using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath))
		{
			key.SetValue(null, menuText);
		}

		// add command that is invoked to the registry
		using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(string.Format(@"{0}\command", regPath)))
		{
			key.SetValue(null, menuCommand);
		}
	}

	public static void Unregister(string fileType, string shellKeyName)
	{
		Debug.Assert(!string.IsNullOrEmpty(fileType) && !string.IsNullOrEmpty(shellKeyName));

		// path to the registry location
		string regPath = string.Format(@"{0}\shell\{1}", fileType, shellKeyName);

		// remove context menu from the registry
		Registry.ClassesRoot.DeleteSubKeyTree(regPath);
	}
}