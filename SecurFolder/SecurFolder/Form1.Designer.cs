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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDirectoryNumber = new System.Windows.Forms.Label();
            this.fbdFolderSelected = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstListFileAndFolder = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secur your folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadFolder);
            this.groupBox1.Controls.Add(this.txtFolderName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 54);
            this.groupBox1.TabIndex = 1;
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
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(379, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // lblFileNumber
            // 
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Location = new System.Drawing.Point(120, 19);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(35, 13);
            this.lblFileNumber.TabIndex = 6;
            this.lblFileNumber.Text = "label6";
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
            // lblDirectoryNumber
            // 
            this.lblDirectoryNumber.AutoSize = true;
            this.lblDirectoryNumber.Location = new System.Drawing.Point(120, 45);
            this.lblDirectoryNumber.Name = "lblDirectoryNumber";
            this.lblDirectoryNumber.Size = new System.Drawing.Size(35, 13);
            this.lblDirectoryNumber.TabIndex = 8;
            this.lblDirectoryNumber.Text = "label8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstListFileAndFolder);
            this.groupBox2.Controls.Add(this.lblDirectoryNumber);
            this.groupBox2.Controls.Add(this.lblDateCreated);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblFileNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 163);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lstListFileAndFolder
            // 
            this.lstListFileAndFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstListFileAndFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListFileAndFolder.FormattingEnabled = true;
            this.lstListFileAndFolder.HorizontalScrollbar = true;
            this.lstListFileAndFolder.Location = new System.Drawing.Point(170, 20);
            this.lstListFileAndFolder.Name = "lstListFileAndFolder";
            this.lstListFileAndFolder.Size = new System.Drawing.Size(247, 117);
            this.lstListFileAndFolder.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 314);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurFolder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblDirectoryNumber;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderSelected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstListFileAndFolder;
    }
}

