namespace SecurFolder
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.fbdFolderSelected = new System.Windows.Forms.FolderBrowserDialog();
            this.tcOperation = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnOkPassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstListFileAndFolder = new System.Windows.Forms.ListBox();
            this.lblDirectoryNumber = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPasswordConfirmNewFolder = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOkCreateLockFolder = new System.Windows.Forms.Button();
            this.txtPasswordNewFolder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameNewFolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFolderSelected = new System.Windows.Forms.TextBox();
            this.btnFolderSelected = new System.Windows.Forms.Button();
            this.btnListFolderLock = new System.Windows.Forms.Button();
            this.tcOperation.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.txtPasswordConfirmNewFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secur your folder";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(537, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tcOperation
            // 
            this.tcOperation.Controls.Add(this.tabPage1);
            this.tcOperation.Controls.Add(this.tabPage2);
            this.tcOperation.Location = new System.Drawing.Point(12, 47);
            this.tcOperation.Name = "tcOperation";
            this.tcOperation.SelectedIndex = 0;
            this.tcOperation.Size = new System.Drawing.Size(626, 344);
            this.tcOperation.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.btnListFolderLock);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lock existing folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadFolder);
            this.groupBox1.Controls.Add(this.txtFolderName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(368, 15);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(49, 22);
            this.btnLoadFolder.TabIndex = 2;
            this.btnLoadFolder.Text = "...";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click_1);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(104, 15);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(257, 20);
            this.txtFolderName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPasswordConfirm);
            this.groupBox2.Controls.Add(this.btnOkPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lstListFileAndFolder);
            this.groupBox2.Controls.Add(this.lblDirectoryNumber);
            this.groupBox2.Controls.Add(this.lblDateCreated);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblFileNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 222);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirm password :";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(217, 153);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(144, 20);
            this.txtPasswordConfirm.TabIndex = 13;
            // 
            // btnOkPassword
            // 
            this.btnOkPassword.Location = new System.Drawing.Point(217, 179);
            this.btnOkPassword.Name = "btnOkPassword";
            this.btnOkPassword.Size = new System.Drawing.Size(49, 23);
            this.btnOkPassword.TabIndex = 12;
            this.btnOkPassword.Text = "Ok";
            this.btnOkPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(217, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lock the folder by entering a password :";
            // 
            // lstListFileAndFolder
            // 
            this.lstListFileAndFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstListFileAndFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListFileAndFolder.FormattingEnabled = true;
            this.lstListFileAndFolder.HorizontalScrollbar = true;
            this.lstListFileAndFolder.Location = new System.Drawing.Point(217, 19);
            this.lstListFileAndFolder.Name = "lstListFileAndFolder";
            this.lstListFileAndFolder.Size = new System.Drawing.Size(349, 80);
            this.lstListFileAndFolder.TabIndex = 9;
            // 
            // lblDirectoryNumber
            // 
            this.lblDirectoryNumber.AutoSize = true;
            this.lblDirectoryNumber.Location = new System.Drawing.Point(120, 45);
            this.lblDirectoryNumber.Name = "lblDirectoryNumber";
            this.lblDirectoryNumber.Size = new System.Drawing.Size(35, 13);
            this.lblDirectoryNumber.TabIndex = 8;
            this.lblDirectoryNumber.Text = "label8";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(120, 71);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(35, 13);
            this.lblDateCreated.TabIndex = 7;
            this.lblDateCreated.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of file :";
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Location = new System.Drawing.Point(120, 19);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(35, 13);
            this.lblFileNumber.TabIndex = 6;
            this.lblFileNumber.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date created :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of directory :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.txtPasswordConfirmNewFolder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Creaye and lock folder";
            // 
            // txtPasswordConfirmNewFolder
            // 
            this.txtPasswordConfirmNewFolder.Controls.Add(this.label9);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.textBox2);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.btnOkCreateLockFolder);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.txtPasswordNewFolder);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.label10);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.txtNameNewFolder);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.label8);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.txtFolderSelected);
            this.txtPasswordConfirmNewFolder.Controls.Add(this.btnFolderSelected);
            this.txtPasswordConfirmNewFolder.Location = new System.Drawing.Point(6, 6);
            this.txtPasswordConfirmNewFolder.Name = "txtPasswordConfirmNewFolder";
            this.txtPasswordConfirmNewFolder.Size = new System.Drawing.Size(458, 196);
            this.txtPasswordConfirmNewFolder.TabIndex = 11;
            this.txtPasswordConfirmNewFolder.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Confirm password :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 18;
            // 
            // btnOkCreateLockFolder
            // 
            this.btnOkCreateLockFolder.Location = new System.Drawing.Point(212, 167);
            this.btnOkCreateLockFolder.Name = "btnOkCreateLockFolder";
            this.btnOkCreateLockFolder.Size = new System.Drawing.Size(49, 23);
            this.btnOkCreateLockFolder.TabIndex = 17;
            this.btnOkCreateLockFolder.Text = "Ok";
            this.btnOkCreateLockFolder.UseVisualStyleBackColor = true;
            // 
            // txtPasswordNewFolder
            // 
            this.txtPasswordNewFolder.Location = new System.Drawing.Point(212, 114);
            this.txtPasswordNewFolder.Name = "txtPasswordNewFolder";
            this.txtPasswordNewFolder.PasswordChar = '*';
            this.txtPasswordNewFolder.Size = new System.Drawing.Size(162, 20);
            this.txtPasswordNewFolder.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Lock the folder by entering a password :";
            // 
            // txtNameNewFolder
            // 
            this.txtNameNewFolder.Location = new System.Drawing.Point(212, 86);
            this.txtNameNewFolder.Name = "txtNameNewFolder";
            this.txtNameNewFolder.Size = new System.Drawing.Size(162, 20);
            this.txtNameNewFolder.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name of the new folder :";
            // 
            // txtFolderSelected
            // 
            this.txtFolderSelected.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFolderSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderSelected.Location = new System.Drawing.Point(9, 46);
            this.txtFolderSelected.Name = "txtFolderSelected";
            this.txtFolderSelected.Size = new System.Drawing.Size(443, 20);
            this.txtFolderSelected.TabIndex = 3;
            // 
            // btnFolderSelected
            // 
            this.btnFolderSelected.Location = new System.Drawing.Point(6, 18);
            this.btnFolderSelected.Name = "btnFolderSelected";
            this.btnFolderSelected.Size = new System.Drawing.Size(172, 22);
            this.btnFolderSelected.TabIndex = 2;
            this.btnFolderSelected.Text = "Select where to create folder";
            this.btnFolderSelected.UseVisualStyleBackColor = true;
            this.btnFolderSelected.Click += new System.EventHandler(this.btnFolderSelected_Click);
            // 
            // btnListFolderLock
            // 
            this.btnListFolderLock.Location = new System.Drawing.Point(462, 19);
            this.btnListFolderLock.Name = "btnListFolderLock";
            this.btnListFolderLock.Size = new System.Drawing.Size(134, 23);
            this.btnListFolderLock.TabIndex = 12;
            this.btnListFolderLock.Text = "View list folder lock";
            this.btnListFolderLock.UseVisualStyleBackColor = true;
            this.btnListFolderLock.Click += new System.EventHandler(this.btnListFolderLock_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 432);
            this.Controls.Add(this.tcOperation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurFolder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcOperation.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.txtPasswordConfirmNewFolder.ResumeLayout(false);
            this.txtPasswordConfirmNewFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderSelected;
        private System.Windows.Forms.TabControl tcOperation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstListFileAndFolder;
        private System.Windows.Forms.Label lblDirectoryNumber;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Button btnOkPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox txtPasswordConfirmNewFolder;
        private System.Windows.Forms.Button btnFolderSelected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOkCreateLockFolder;
        private System.Windows.Forms.TextBox txtPasswordNewFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameNewFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFolderSelected;
        private System.Windows.Forms.Button btnListFolderLock;
    }
}

