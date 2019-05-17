namespace Shogun2_Mod_Manager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.apply = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.modsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.addModOpenFIleDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.apply,
            this.settingsButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 20);
            this.add.Text = "Add A New Mod";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // apply
            // 
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(50, 20);
            this.apply.Text = "Apply";
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(61, 20);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // modsCheckedList
            // 
            this.modsCheckedList.CheckOnClick = true;
            this.modsCheckedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modsCheckedList.FormattingEnabled = true;
            this.modsCheckedList.Location = new System.Drawing.Point(0, 24);
            this.modsCheckedList.Name = "modsCheckedList";
            this.modsCheckedList.Size = new System.Drawing.Size(800, 426);
            this.modsCheckedList.TabIndex = 1;
            // 
            // addModOpenFIleDialog
            // 
            this.addModOpenFIleDialog.Filter = "Mod files (*.pack)|*.pack|All files (*.*)|*.*";
            this.addModOpenFIleDialog.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modsCheckedList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Total War: Shogun 2 Non Workshop Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem apply;
        private System.Windows.Forms.CheckedListBox modsCheckedList;
        private System.Windows.Forms.ToolStripMenuItem settingsButton;
        private System.Windows.Forms.OpenFileDialog addModOpenFIleDialog;
    }
}

