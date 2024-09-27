using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace AiCompanion
{
    internal class AutoStartManager
    {
        private const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";
        private readonly string appName;
        private readonly string appPath;

        public AutoStartManager(string appName)
        {
            this.appName = appName;
            this.appPath = Application.ExecutablePath; // Path to the current executable
        }

        public void AddToAutoStart()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true))
                {
                    if (key == null)
                        throw new InvalidOperationException("Unable to open registry key.");

                    key.SetValue(appName, appPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding app to autostart: {ex.Message}");
            }
        }
        public void RemoveFromAutoStart()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true))
                {
                    if (key == null)
                        throw new InvalidOperationException("Unable to open registry key.");

                    key.DeleteValue(appName, false); // The second parameter avoids throwing if the value does not exist
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing app from autostart: {ex.Message}");
            }
        }
        public bool IsInAutoStart()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, false))
                {
                    if (key == null)
                        return false;

                    string value = key.GetValue(appName) as string;
                    return value != null && value.Equals(appPath, StringComparison.OrdinalIgnoreCase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking autostart status: {ex.Message}");
                return false;
            }
        }

    }
}
