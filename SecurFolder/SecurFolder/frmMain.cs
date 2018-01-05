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

namespace SecurFolder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            fbdFolderSelected.ShowDialog();
            txtFolderName.Text = fbdFolderSelected.SelectedPath;

            if (Directory.Exists(txtFolderName.Text)){
                
                //Instanciate an object of directory
                DirectoryInfo dr = new DirectoryInfo(txtFolderName.Text);

                //taking the number of files and directories in te selected directory
                int intNumberFile = 0;
                int intNumberDirectory = 0;
                foreach(var f in dr.GetFiles()) {
                    intNumberFile += 1;
                    lstListFileAndFolder.Items.Add(f.FullName);
                    
                }
                foreach(var d in dr.GetDirectories()) {
                    intNumberDirectory += 1;
                    lstListFileAndFolder.Items.Add(d.FullName + "");
                }

                lblDateCreated.Text = Convert.ToString(dr.CreationTime);
                lblFileNumber.Text = Convert.ToString(intNumberFile);
                lblDirectoryNumber.Text = Convert.ToString(intNumberDirectory);

            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFileNumber.Text = "";
            lblDirectoryNumber.Text = "";
            lblDateCreated.Text = "";
            txtFolderName.Clear();
        }

        private void btnFolderSelected_Click(object sender, EventArgs e)
        {
            fbdFolderSelected.ShowDialog();
            txtFolderName.Text = fbdFolderSelected.SelectedPath;
        }

        private void btnLoadFolder_Click_1(object sender, EventArgs e)
        {

        }
    }
}
