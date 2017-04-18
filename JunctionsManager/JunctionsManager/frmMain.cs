using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * Author:  Mian Zeshan Farooqi
 * Dated:   May 28, 2015
 */ 

namespace JunctionsManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdBrowseSource_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void cmdBrowseDestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDialog.SelectedPath;

                // Append the source directory name to destination path, just for user convenience
                txtDestinationFolder.Text = Path.Combine(txtDestinationFolder.Text, Path.GetFileNameWithoutExtension(txtSourceFolder.Text));
            }
        }

        private void cmdBrowseTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtTargetFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnGo_click(object sender, EventArgs e)
        {

            if(txtSourceFolder.Text.Length > 0 && txtDestinationFolder.Text.Length > 0)
            {
                // Create Junction by executing mklink command via command prompt
                string src = txtSourceFolder.Text;
                string dest = txtDestinationFolder.Text;

                
                string command = new StringBuilder().Append("mklink").Append(" ")
                    .Append("/D").Append(" ").Append("/J").Append(" ")
                    .Append(this.encloseInQuotes(dest)).Append(" ")
                    .Append(this.encloseInQuotes(src)).ToString();

                this.executeCommand(command);

                MessageBox.Show(this.encloseInQuotes(src) + " has been mapped to " + this.encloseInQuotes(dest));

            }
            else if(txtTargetFolder.Text.Length > 0)
            {
                // Remove Junction - It's simply a remove directory operation
                string target = txtTargetFolder.Text;

                String command = new StringBuilder().Append("rmdir").Append(" ")
                    .Append(this.encloseInQuotes(target)).ToString();
                
                MessageBox.Show(target + " has been removed!");
            }
            else
            {
                MessageBox.Show("Invalid Parameters Specified!");
            }
        }
        
        private long executeCommand(String strCommand)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            psi.CreateNoWindow = true;

            psi.LoadUserProfile = true;
            psi.FileName = "cmd.exe";
            psi.Arguments = new StringBuilder().Append("/c").Append(" ").Append(strCommand).ToString();

            Process process = new Process();
            process.StartInfo = psi;
            process.Start();
            process.WaitForExit();

            /*
             * TODO: Return the result of command rather than zero in all cases
             */

            return 0;

        }

        private string encloseInQuotes(String str)
        {
            return "\"" + str + "\"";
        }
    }
}
