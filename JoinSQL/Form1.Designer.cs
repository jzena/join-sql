namespace JoinSQL
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
            this.txtPathSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rchTxtContent = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFind = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bntUploadFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchFolder = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchNameFilter = new System.Windows.Forms.TextBox();
            this.btnSearchFindFiles = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSelectFolderInsideFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolderInFile = new System.Windows.Forms.TextBox();
            this.dgfilesconsidence = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnametofind = new System.Windows.Forms.TextBox();
            this.btnFindInsideFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.richTxtScript = new System.Windows.Forms.RichTextBox();
            this.btnPreviewScript = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfilesconsidence)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathSource
            // 
            this.txtPathSource.Location = new System.Drawing.Point(115, 19);
            this.txtPathSource.Name = "txtPathSource";
            this.txtPathSource.Size = new System.Drawing.Size(583, 20);
            this.txtPathSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Folder";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(483, 45);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Vista previa";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rchTxtContent
            // 
            this.rchTxtContent.Location = new System.Drawing.Point(20, 97);
            this.rchTxtContent.Name = "rchTxtContent";
            this.rchTxtContent.Size = new System.Drawing.Size(711, 265);
            this.rchTxtContent.TabIndex = 5;
            this.rchTxtContent.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(564, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(656, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(704, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(27, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 519);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnPreviewScript);
            this.tabPage4.Controls.Add(this.richTxtScript);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtPassword);
            this.tabPage4.Controls.Add(this.txtUser);
            this.tabPage4.Controls.Add(this.txtDatabase);
            this.tabPage4.Controls.Add(this.txtServer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 493);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Obtener SCRIPT";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "SERVER";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(106, 86);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "webWebTraining";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(106, 64);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(100, 20);
            this.txtDatabase.TabIndex = 0;
            this.txtDatabase.Text = "WebTraining";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(106, 34);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "SQL0406\\pro01";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnFind);
            this.tabPage1.Controls.Add(this.txtPathSource);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnProcess);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.rchTxtContent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Procesar SQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bntUploadFolder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSearchFolder);
            this.tabPage2.Controls.Add(this.dgvFiles);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtSearchNameFilter);
            this.tabPage2.Controls.Add(this.btnSearchFindFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda de archivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bntUploadFolder
            // 
            this.bntUploadFolder.Location = new System.Drawing.Point(670, 22);
            this.bntUploadFolder.Name = "bntUploadFolder";
            this.bntUploadFolder.Size = new System.Drawing.Size(27, 23);
            this.bntUploadFolder.TabIndex = 9;
            this.bntUploadFolder.Text = "...";
            this.bntUploadFolder.UseVisualStyleBackColor = true;
            this.bntUploadFolder.Click += new System.EventHandler(this.bntUploadFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione Folder";
            // 
            // txtSearchFolder
            // 
            this.txtSearchFolder.Location = new System.Drawing.Point(114, 24);
            this.txtSearchFolder.Name = "txtSearchFolder";
            this.txtSearchFolder.Size = new System.Drawing.Size(540, 20);
            this.txtSearchFolder.TabIndex = 4;
            // 
            // dgvFiles
            // 
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(19, 100);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.Size = new System.Drawing.Size(726, 367);
            this.dgvFiles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtSearchNameFilter
            // 
            this.txtSearchNameFilter.Location = new System.Drawing.Point(114, 47);
            this.txtSearchNameFilter.Name = "txtSearchNameFilter";
            this.txtSearchNameFilter.Size = new System.Drawing.Size(540, 20);
            this.txtSearchNameFilter.TabIndex = 1;
            // 
            // btnSearchFindFiles
            // 
            this.btnSearchFindFiles.Location = new System.Drawing.Point(670, 51);
            this.btnSearchFindFiles.Name = "btnSearchFindFiles";
            this.btnSearchFindFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFindFiles.TabIndex = 0;
            this.btnSearchFindFiles.Text = "Buscar";
            this.btnSearchFindFiles.UseVisualStyleBackColor = true;
            this.btnSearchFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSelectFolderInsideFile);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtFolderInFile);
            this.tabPage3.Controls.Add(this.dgfilesconsidence);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtnametofind);
            this.tabPage3.Controls.Add(this.btnFindInsideFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar en archivos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSelectFolderInsideFile
            // 
            this.btnSelectFolderInsideFile.Location = new System.Drawing.Point(686, 24);
            this.btnSelectFolderInsideFile.Name = "btnSelectFolderInsideFile";
            this.btnSelectFolderInsideFile.Size = new System.Drawing.Size(27, 23);
            this.btnSelectFolderInsideFile.TabIndex = 16;
            this.btnSelectFolderInsideFile.Text = "...";
            this.btnSelectFolderInsideFile.UseVisualStyleBackColor = true;
            this.btnSelectFolderInsideFile.Click += new System.EventHandler(this.btnSelectFolderInsideFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seleccione Folder";
            // 
            // txtFolderInFile
            // 
            this.txtFolderInFile.Location = new System.Drawing.Point(130, 26);
            this.txtFolderInFile.Name = "txtFolderInFile";
            this.txtFolderInFile.Size = new System.Drawing.Size(540, 20);
            this.txtFolderInFile.TabIndex = 14;
            // 
            // dgfilesconsidence
            // 
            this.dgfilesconsidence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfilesconsidence.Location = new System.Drawing.Point(35, 102);
            this.dgfilesconsidence.Name = "dgfilesconsidence";
            this.dgfilesconsidence.Size = new System.Drawing.Size(726, 367);
            this.dgfilesconsidence.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre";
            // 
            // txtnametofind
            // 
            this.txtnametofind.Location = new System.Drawing.Point(130, 49);
            this.txtnametofind.Name = "txtnametofind";
            this.txtnametofind.Size = new System.Drawing.Size(540, 20);
            this.txtnametofind.TabIndex = 11;
            // 
            // btnFindInsideFile
            // 
            this.btnFindInsideFile.Location = new System.Drawing.Point(686, 53);
            this.btnFindInsideFile.Name = "btnFindInsideFile";
            this.btnFindInsideFile.Size = new System.Drawing.Size(75, 23);
            this.btnFindInsideFile.TabIndex = 10;
            this.btnFindInsideFile.Text = "Buscar";
            this.btnFindInsideFile.UseVisualStyleBackColor = true;
            this.btnFindInsideFile.Click += new System.EventHandler(this.btnFindInsideFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "DATABASE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "USER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = ".TRAINING555f#";
            // 
            // richTxtScript
            // 
            this.richTxtScript.Location = new System.Drawing.Point(11, 162);
            this.richTxtScript.Name = "richTxtScript";
            this.richTxtScript.Size = new System.Drawing.Size(758, 265);
            this.richTxtScript.TabIndex = 6;
            this.richTxtScript.Text = "";
            // 
            // btnPreviewScript
            // 
            this.btnPreviewScript.Location = new System.Drawing.Point(221, 110);
            this.btnPreviewScript.Name = "btnPreviewScript";
            this.btnPreviewScript.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewScript.TabIndex = 7;
            this.btnPreviewScript.Text = "Vista previa";
            this.btnPreviewScript.UseVisualStyleBackColor = true;
            this.btnPreviewScript.Click += new System.EventHandler(this.btnPreviewScript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoinSQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgfilesconsidence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RichTextBox rchTxtContent;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchNameFilter;
        private System.Windows.Forms.Button btnSearchFindFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchFolder;
        private System.Windows.Forms.Button bntUploadFolder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSelectFolderInsideFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolderInFile;
        private System.Windows.Forms.DataGridView dgfilesconsidence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnametofind;
        private System.Windows.Forms.Button btnFindInsideFile;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPreviewScript;
        private System.Windows.Forms.RichTextBox richTxtScript;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

