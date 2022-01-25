using System;
using System.IO;
using System.Windows.Forms;

namespace SaveLoad
{
    public class SaveLoad
    {
        public void SetValue(string dir, string key, string value)
        {
            if (Directory.Exists(dir))
            {
                //
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(dir);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show("Failed to set value!\nError: CREATE_DIRECTORY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                File.WriteAllText(dir + "\\" + key, value);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Failed to set value!\nError: SET_VALUE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetValue(string dir, string key)
        {
            string value = "";
            try
            {
                value = File.ReadAllText(dir + "\\" + key);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Failed to get value!\nError: READ_VALUE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return value;
        }

        public bool KeyExists(string dir, string key)
        {
            bool exists;
            if (File.Exists(dir + "\\" + key))
            {
                exists = true;
            }
            else
            {
                exists = false;
            }
            return exists;
        }
    }
}