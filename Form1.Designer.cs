namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxRemoveBloatware = new System.Windows.Forms.CheckBox();
            this.checkBoxDisablePowerUAC = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeTimeZone = new System.Windows.Forms.CheckBox();
            this.checkBoxCleanGUI = new System.Windows.Forms.CheckBox();
            this.checkBoxInstallSoftware = new System.Windows.Forms.CheckBox();
            this.checkBoxRenamePC = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateNewUser = new System.Windows.Forms.CheckBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRename = new System.Windows.Forms.TextBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxRemoveBloatware
            // 
            this.checkBoxRemoveBloatware.AutoSize = true;
            this.checkBoxRemoveBloatware.Location = new System.Drawing.Point(12, 12);
            this.checkBoxRemoveBloatware.Name = "checkBoxRemoveBloatware";
            this.checkBoxRemoveBloatware.Size = new System.Drawing.Size(142, 20);
            this.checkBoxRemoveBloatware.TabIndex = 7;
            this.checkBoxRemoveBloatware.Text = "Remove Bloatware";
            this.checkBoxRemoveBloatware.UseVisualStyleBackColor = true;
            this.checkBoxRemoveBloatware.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxDisablePowerUAC
            // 
            this.checkBoxDisablePowerUAC.AutoSize = true;
            this.checkBoxDisablePowerUAC.Location = new System.Drawing.Point(12, 116);
            this.checkBoxDisablePowerUAC.Name = "checkBoxDisablePowerUAC";
            this.checkBoxDisablePowerUAC.Size = new System.Drawing.Size(217, 20);
            this.checkBoxDisablePowerUAC.TabIndex = 8;
            this.checkBoxDisablePowerUAC.Text = "Disable Power Saving and UAC";
            this.checkBoxDisablePowerUAC.UseVisualStyleBackColor = true;
            this.checkBoxDisablePowerUAC.CheckedChanged += new System.EventHandler(this.checkBoxDisablePowerUAC_CheckedChanged);
            // 
            // checkBoxChangeTimeZone
            // 
            this.checkBoxChangeTimeZone.AutoSize = true;
            this.checkBoxChangeTimeZone.Location = new System.Drawing.Point(12, 90);
            this.checkBoxChangeTimeZone.Name = "checkBoxChangeTimeZone";
            this.checkBoxChangeTimeZone.Size = new System.Drawing.Size(142, 20);
            this.checkBoxChangeTimeZone.TabIndex = 9;
            this.checkBoxChangeTimeZone.Text = "Change Time Zone";
            this.checkBoxChangeTimeZone.UseVisualStyleBackColor = true;
            this.checkBoxChangeTimeZone.CheckedChanged += new System.EventHandler(this.checkBoxChangeTimeZone_CheckedChanged);
            // 
            // checkBoxCleanGUI
            // 
            this.checkBoxCleanGUI.AutoSize = true;
            this.checkBoxCleanGUI.Location = new System.Drawing.Point(12, 64);
            this.checkBoxCleanGUI.Name = "checkBoxCleanGUI";
            this.checkBoxCleanGUI.Size = new System.Drawing.Size(88, 20);
            this.checkBoxCleanGUI.TabIndex = 10;
            this.checkBoxCleanGUI.Text = "Clean GUI";
            this.checkBoxCleanGUI.UseVisualStyleBackColor = true;
            this.checkBoxCleanGUI.CheckedChanged += new System.EventHandler(this.checkBoxCleanGUI_CheckedChanged);
            // 
            // checkBoxInstallSoftware
            // 
            this.checkBoxInstallSoftware.AutoSize = true;
            this.checkBoxInstallSoftware.Location = new System.Drawing.Point(12, 38);
            this.checkBoxInstallSoftware.Name = "checkBoxInstallSoftware";
            this.checkBoxInstallSoftware.Size = new System.Drawing.Size(116, 20);
            this.checkBoxInstallSoftware.TabIndex = 11;
            this.checkBoxInstallSoftware.Text = "Install Software";
            this.checkBoxInstallSoftware.UseVisualStyleBackColor = true;
            this.checkBoxInstallSoftware.CheckedChanged += new System.EventHandler(this.checkBoxInstallSoftware_CheckedChanged);
            // 
            // checkBoxRenamePC
            // 
            this.checkBoxRenamePC.AutoSize = true;
            this.checkBoxRenamePC.Location = new System.Drawing.Point(258, 12);
            this.checkBoxRenamePC.Name = "checkBoxRenamePC";
            this.checkBoxRenamePC.Size = new System.Drawing.Size(140, 20);
            this.checkBoxRenamePC.TabIndex = 12;
            this.checkBoxRenamePC.Text = "Rename Computer";
            this.checkBoxRenamePC.UseVisualStyleBackColor = true;
            this.checkBoxRenamePC.CheckedChanged += new System.EventHandler(this.checkBoxRenamePC_CheckedChanged);
            // 
            // checkBoxCreateNewUser
            // 
            this.checkBoxCreateNewUser.AutoSize = true;
            this.checkBoxCreateNewUser.Location = new System.Drawing.Point(258, 64);
            this.checkBoxCreateNewUser.Name = "checkBoxCreateNewUser";
            this.checkBoxCreateNewUser.Size = new System.Drawing.Size(129, 20);
            this.checkBoxCreateNewUser.TabIndex = 13;
            this.checkBoxCreateNewUser.Text = "Create New User";
            this.checkBoxCreateNewUser.UseVisualStyleBackColor = true;
            this.checkBoxCreateNewUser.CheckedChanged += new System.EventHandler(this.checkBoxCreateNewUser_CheckedChanged);
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLaunch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaunch.FlatAppearance.BorderSize = 0;
            this.buttonLaunch.Location = new System.Drawing.Point(238, 147);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 14;
            this.buttonLaunch.Text = "Go";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Location = new System.Drawing.Point(329, 90);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(134, 22);
            this.textBoxUserName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(329, 116);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 22);
            this.textBoxPassword.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // textBoxRename
            // 
            this.textBoxRename.Enabled = false;
            this.textBoxRename.Location = new System.Drawing.Point(306, 36);
            this.textBoxRename.Name = "textBoxRename";
            this.textBoxRename.Size = new System.Drawing.Size(157, 22);
            this.textBoxRename.TabIndex = 20;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectAll.Location = new System.Drawing.Point(157, 147);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 21;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 182);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.textBoxRename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.checkBoxCreateNewUser);
            this.Controls.Add(this.checkBoxRenamePC);
            this.Controls.Add(this.checkBoxInstallSoftware);
            this.Controls.Add(this.checkBoxCleanGUI);
            this.Controls.Add(this.checkBoxChangeTimeZone);
            this.Controls.Add(this.checkBoxDisablePowerUAC);
            this.Controls.Add(this.checkBoxRemoveBloatware);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows 10 New Machine Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxRemoveBloatware;
        private System.Windows.Forms.CheckBox checkBoxDisablePowerUAC;
        private System.Windows.Forms.CheckBox checkBoxChangeTimeZone;
        private System.Windows.Forms.CheckBox checkBoxCleanGUI;
        private System.Windows.Forms.CheckBox checkBoxInstallSoftware;
        private System.Windows.Forms.CheckBox checkBoxRenamePC;
        private System.Windows.Forms.CheckBox checkBoxCreateNewUser;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRename;
        private System.Windows.Forms.Button buttonSelectAll;
    }
}

