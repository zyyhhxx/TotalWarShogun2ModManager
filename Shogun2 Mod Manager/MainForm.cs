using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Shogun2_Mod_Manager
{
    public partial class Form1 : Form
    {
        private Settings settings;
        private char[] delim = { '\\' };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Settings.settingsPath))
            {
                string text = File.ReadAllText(Settings.settingsPath);
                settings = new Settings(text);
                RefreshList();
            }
            else
            {
                settings = new Settings();
                var settingsForm = new SettingsForm(settings);
                settingsForm.ShowDialog();
                if (settingsForm.Result == DialogResult.OK)
                {
                    settings.gamePath = settingsForm.gamePath;
                    settings.modPath = settingsForm.modPath;
                }
                settings.Save();
            }
            addModOpenFIleDialog.InitialDirectory = settings.gamePath;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(settings);
            settingsForm.ShowDialog();
            if (settingsForm.Result == DialogResult.OK)
            {
                settings.gamePath = settingsForm.gamePath;
                settings.modPath = settingsForm.modPath;
                settings.Save();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (addModOpenFIleDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                var filePath = addModOpenFIleDialog.FileName;
                var addModForm = new AddModForm(filePath);
                addModForm.ShowDialog();
                if (addModForm.Result == DialogResult.OK)
                {
                    var items = filePath.Split(delim);
                    var fileName = items[items.Length - 1];
                    settings.mods[addModForm.modName] = fileName;
                    settings.Save();
                    RefreshList();
                    CopyModFile(filePath, fileName);
                }
            }
        }

        private void RefreshList()
        {
            modsCheckedList.Items.Clear();
            var modList = new List<string>();
            foreach(var modInfo in settings.mods)
            {
                modList.Add(modInfo.Key);
            }
            modsCheckedList.Items.AddRange(modList.ToArray<string>());
        }

        private void apply_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < modsCheckedList.Items.Count; i++)
            {
                var item = modsCheckedList.Items[i];
                var filename = settings.mods[item.ToString()];
                Console.WriteLine(modsCheckedList.GetItemChecked(i));
                if (modsCheckedList.GetItemChecked(i))
                {
                    File.Copy(settings.modPath + "\\" + filename, settings.gamePath + "\\data\\" + filename, true);
                }
                else
                {
                    File.Delete(settings.gamePath + "\\data\\" + filename);
                }
            }
            MessageBox.Show("Mods applied!");
        }

        private void CopyModFile(string origin, string fileName)
        {
            File.Copy(origin, settings.modPath + "\\" + fileName, true);
        }
    }
}
