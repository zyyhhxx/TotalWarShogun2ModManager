namespace Shogun2_Mod_Manager
{
    partial class SettingsForm
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
            this.gamePathTextBox = new System.Windows.Forms.TextBox();
            this.modPathTextBox = new System.Windows.Forms.TextBox();
            this.modNameLabel = new System.Windows.Forms.Label();
            this.modPathLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseGamePathButton = new System.Windows.Forms.Button();
            this.browseModPathButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // gamePathTextBox
            // 
            this.gamePathTextBox.Location = new System.Drawing.Point(78, 15);
            this.gamePathTextBox.Name = "gamePathTextBox";
            this.gamePathTextBox.Size = new System.Drawing.Size(413, 20);
            this.gamePathTextBox.TabIndex = 0;
            // 
            // modPathTextBox
            // 
            this.modPathTextBox.Location = new System.Drawing.Point(78, 50);
            this.modPathTextBox.Name = "modPathTextBox";
            this.modPathTextBox.Size = new System.Drawing.Size(413, 20);
            this.modPathTextBox.TabIndex = 1;
            // 
            // modNameLabel
            // 
            this.modNameLabel.AutoSize = true;
            this.modNameLabel.Location = new System.Drawing.Point(12, 18);
            this.modNameLabel.Name = "modNameLabel";
            this.modNameLabel.Size = new System.Drawing.Size(60, 13);
            this.modNameLabel.TabIndex = 2;
            this.modNameLabel.Text = "Game Path";
            // 
            // modPathLabel
            // 
            this.modPathLabel.AutoSize = true;
            this.modPathLabel.Location = new System.Drawing.Point(12, 53);
            this.modPathLabel.Name = "modPathLabel";
            this.modPathLabel.Size = new System.Drawing.Size(53, 13);
            this.modPathLabel.TabIndex = 3;
            this.modPathLabel.Text = "Mod Path";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 76);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(497, 76);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // browseGamePathButton
            // 
            this.browseGamePathButton.Location = new System.Drawing.Point(497, 15);
            this.browseGamePathButton.Name = "browseGamePathButton";
            this.browseGamePathButton.Size = new System.Drawing.Size(75, 23);
            this.browseGamePathButton.TabIndex = 6;
            this.browseGamePathButton.Text = "Browse";
            this.browseGamePathButton.UseVisualStyleBackColor = true;
            this.browseGamePathButton.Click += new System.EventHandler(this.browseGamePathButton_Click);
            // 
            // browseModPathButton
            // 
            this.browseModPathButton.Location = new System.Drawing.Point(497, 47);
            this.browseModPathButton.Name = "browseModPathButton";
            this.browseModPathButton.Size = new System.Drawing.Size(75, 23);
            this.browseModPathButton.TabIndex = 7;
            this.browseModPathButton.Text = "Browse";
            this.browseModPathButton.UseVisualStyleBackColor = true;
            this.browseModPathButton.Click += new System.EventHandler(this.browseModPathButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(this.browseModPathButton);
            this.Controls.Add(this.browseGamePathButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.modPathLabel);
            this.Controls.Add(this.modNameLabel);
            this.Controls.Add(this.modPathTextBox);
            this.Controls.Add(this.gamePathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gamePathTextBox;
        private System.Windows.Forms.TextBox modPathTextBox;
        private System.Windows.Forms.Label modNameLabel;
        private System.Windows.Forms.Label modPathLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button browseGamePathButton;
        private System.Windows.Forms.Button browseModPathButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}