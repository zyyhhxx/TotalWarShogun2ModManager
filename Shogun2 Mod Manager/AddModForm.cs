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
    public partial class AddModForm : Form
    {
        private string modPath;
        public string modName;
        public DialogResult Result { get; set; }

        public AddModForm(string modpath)
        {
            InitializeComponent();
            this.modPath = modpath;
            modPathTextBox.Text = modpath;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            modName = modNameTextBox.Text;
            Result = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            Close();
        }
    }
}
