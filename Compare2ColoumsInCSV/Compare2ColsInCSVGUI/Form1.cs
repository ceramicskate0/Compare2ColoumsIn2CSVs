using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Compare2ColsInCSVGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void File1TXTBOX_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.csv)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            string FileName1 = "";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                FileName1 = choofdlog.FileName;
                File1TXTBOX.Text = FileName1;
            } 
        }

        private void File2TXTBOX_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.csv)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            string FileName1 = "";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                FileName1 = choofdlog.FileName;
                File2TXTBOX.Text = FileName1;
            }
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            try
            {

            if (String.IsNullOrWhiteSpace(File1TXTBOX.Text) == false && String.IsNullOrWhiteSpace(File2TXTBOX.Text) == false)
            {                
                int test=Convert.ToInt32(Col2TXTBOX.Text);
                if (test < 0)
                {
                    throw new Exception("THATS A NEGITIVE NUMBER?");
                }
                test=Convert.ToInt32(Col1TXTBOX.Text);
                if (test<0)
                {
                    throw new Exception ("THATS A NEGITIVE NUMBER?");
                }
                System.Diagnostics.ProcessStartInfo PR = new System.Diagnostics.ProcessStartInfo(Directory.GetCurrentDirectory() + "\\Compare2ColoumsInCSV.exe", BuildCommand());
                PR.RedirectStandardOutput = false;
                PR.CreateNoWindow = false;
                PR.UseShellExecute = false;
                System.Diagnostics.Process StartPR = new System.Diagnostics.Process();
                StartPR.StartInfo = PR;
                try
                {
                    StartPR.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to locate exe for app in current dir " + ex);
                }
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please provide Active Accounts CSV and another input before running the app");
            }
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message.ToString());
            }

        }

        private void OUTPUTTXTBOX_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog choofdlog = new FolderBrowserDialog();
            string FileName1 = "";

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                FileName1 = choofdlog.SelectedPath;
            }
            OUTPUTTXTBOX.Text = FileName1+"\\OUTPUTcsvCompare.csv";
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private string BuildCommand()
        {
            string Command = "";
            Command = "File1 " + File1TXTBOX.Text + " col1 " + Col1TXTBOX.Text + " File2 " + File2TXTBOX.Text + " col2 " + Col2TXTBOX.Text;
            if (string.IsNullOrEmpty(OUTPUTTXTBOX.Text)==false)
            {
                Command += " output " + OUTPUTTXTBOX.Text;
            }
            if (NoReverseCheck.Checked)
            {
                Command += " noreverse ";
            }
            return Command;
        }






        private void Col1TXTBOX_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void Col2TXTBOX_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void File1TXTBOX_TextChanged(object sender, EventArgs e)
        {
        }
        private void Col1TXTBOX_TextChanged(object sender, EventArgs e)
        {
        }
        private void File2TXTBOX_TextChanged(object sender, EventArgs e)
        {
        }
        private void Col2TXTBOX_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
