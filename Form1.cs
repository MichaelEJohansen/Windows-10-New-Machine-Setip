using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //userSelection = [ (bloatware), (software), (GUI), (TimeZone), (Power/UAC), (Rename PC), (Create New User) ]
        private bool[] userSelection = new bool[7];
        private string[] FileNames = {"1. Remove Bloatware", "2. Install Software", "3. Clean GUI", "4. Change Time Zone",
                                    "5. Disable Power and UAC", "6. Rename PC", "7. Create New User", "8. Restart Explorer" };
        private string newUserName = "";
        private string newPassword = "";
        private string newPCName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Make sure that username and pc name are filled out if those options are selected
            if ((userSelection[5] && textBoxRename.Text == "") || (userSelection[6] && textBoxUserName.Text == ""))
            {
                string errorMessage = "Please enter:";

                if (userSelection[5]) errorMessage += "\n     - a new computer name.";
                if (userSelection[6]) errorMessage += "\n     - a new username.";

                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                //get the current working directory and redirect to the forms files
                string batDir = string.Format(Application.StartupPath + "\\bin\\forms files");
                Process proc = null;

                try
                {
                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batDir;

                    for (int i = 0; i < userSelection.Length; i++)
                    {
                        if (userSelection[i])
                        {
                            if (i == 5) //Rename PC
                            {
                                this.newPCName = this.textBoxRename.Text;
                                var argProc = new Process
                                {
                                    StartInfo = {
                                        Arguments = String.Format("\"{0}\"", this.newPCName)
                                    }
                                };
                                argProc.StartInfo.WorkingDirectory = batDir;
                                argProc.StartInfo.FileName = FileNames[i];
                                argProc.StartInfo.CreateNoWindow = false;
                                argProc.Start();
                                argProc.WaitForExit();
                            }
                            else if (i == 6) //Create New User
                            {

                                this.newUserName = textBoxUserName.Text;
                                this.newPassword = textBoxPassword.Text;
                                var argProc = new Process
                                {
                                    StartInfo = {
                                        Arguments = String.Format("\"{0}\" \"{1}\"", this.newUserName, this.newPassword)
                                    }
                                };
                                argProc.StartInfo.WorkingDirectory = batDir;
                                argProc.StartInfo.FileName = FileNames[i];
                                argProc.StartInfo.CreateNoWindow = false;
                                argProc.Start();
                                argProc.WaitForExit();
                            }
                            
                            else
                            {
                                proc.StartInfo.FileName = FileNames[i];
                                proc.StartInfo.CreateNoWindow = false;
                                proc.Start();
                                proc.WaitForExit();
                            }
                        }
                    }

                    proc.StartInfo.FileName = FileNames[7];
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
        }

        #region TextBoxes
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBoxRemoveBloatware.Checked == true) { this.userSelection[0] = true; }
            else{ this.userSelection[0] = false;}
        }

        private void checkBoxInstallSoftware_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxInstallSoftware.Checked == true) { this.userSelection[1] = true; }
            else { this.userSelection[1] = false; }
        }

        private void checkBoxCleanGUI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxCleanGUI.Checked == true) { this.userSelection[2] = true; }
            else { this.userSelection[2] = false; }
        }

        private void checkBoxChangeTimeZone_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxChangeTimeZone.Checked == true) { this.userSelection[3] = true; }
            else { this.userSelection[3] = false; }
        }

        private void checkBoxDisablePowerUAC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDisablePowerUAC.Checked == true) { this.userSelection[4] = true; }
            else { this.userSelection[4] = false; }
        }

        private void checkBoxRenamePC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxRenamePC.Checked == true)
            {
                this.userSelection[5] = true;
                this.textBoxRename.Enabled = true;
            }
            else
            {
                this.userSelection[5] = false;
                this.textBoxRename.Enabled = false;
            }
        }

        private void checkBoxCreateNewUser_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxCreateNewUser.Checked == true)
            {
                this.userSelection[6] = true;
                this.textBoxUserName.Enabled = true;
                this.textBoxPassword.Enabled = true;
            }
            else
            {
                this.userSelection[6] = false;
                this.textBoxUserName.Enabled = false;
                this.textBoxPassword.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            checkBoxRemoveBloatware.Checked = true;
            checkBoxInstallSoftware.Checked = true;
            checkBoxCleanGUI.Checked = true;
            checkBoxChangeTimeZone.Checked = true;
            checkBoxDisablePowerUAC.Checked = true;
            checkBoxRenamePC.Checked = true;
            checkBoxCreateNewUser.Checked = true;
        }
        #endregion
    }
}
