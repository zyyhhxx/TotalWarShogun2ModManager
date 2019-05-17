using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shogun2_Mod_Manager
{
    public partial class SettingsForm : Form
    {
        public string gamePath;
        public string modPath;
        public DialogResult Result { get; set; }

        public SettingsForm(Settings s)
        {
            InitializeComponent();
            gamePath = s.gamePath;
            modPath = s.modPath;
            gamePathTextBox.Text = gamePath;
            modPathTextBox.Text = modPath;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            Close();
        }

        private void browseModPathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                var filePath = folderBrowserDialog.SelectedPath;
                modPath = filePath;
                modPathTextBox.Text = modPath;
            }
        }

        private void browseGamePathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                var filePath = folderBrowserDialog.SelectedPath;
                gamePath = filePath;
                gamePathTextBox.Text = gamePath;
            }
        }
    }
}
