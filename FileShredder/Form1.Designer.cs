namespace FileShredder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrcFile = new System.Windows.Forms.TextBox();
            this.btnSrcFile = new System.Windows.Forms.Button();
            this.ofdSrcFile = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.btnShredIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File:";
            // 
            // txtSrcFile
            // 
            this.txtSrcFile.Location = new System.Drawing.Point(113, 21);
            this.txtSrcFile.Name = "txtSrcFile";
            this.txtSrcFile.Size = new System.Drawing.Size(497, 22);
            this.txtSrcFile.TabIndex = 1;
            // 
            // btnSrcFile
            // 
            this.btnSrcFile.Location = new System.Drawing.Point(616, 19);
            this.btnSrcFile.Name = "btnSrcFile";
            this.btnSrcFile.Size = new System.Drawing.Size(37, 24);
            this.btnSrcFile.TabIndex = 2;
            this.btnSrcFile.Text = "...";
            this.btnSrcFile.UseVisualStyleBackColor = true;
            this.btnSrcFile.Click += new System.EventHandler(this.btnSrcFile_Click);
            // 
            // ofdSrcFile
            // 
            this.ofdSrcFile.FileName = "Choose File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Folder:";
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(113, 54);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(497, 22);
            this.txtTargetFolder.TabIndex = 4;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(616, 53);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(37, 24);
            this.btnSelectFolder.TabIndex = 5;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnShredIt
            // 
            this.btnShredIt.Location = new System.Drawing.Point(131, 147);
            this.btnShredIt.Name = "btnShredIt";
            this.btnShredIt.Size = new System.Drawing.Size(202, 68);
            this.btnShredIt.TabIndex = 6;
            this.btnShredIt.Text = "Shred It !";
            this.btnShredIt.UseVisualStyleBackColor = true;
            this.btnShredIt.Click += new System.EventHandler(this.btnShredIt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 389);
            this.Controls.Add(this.btnShredIt);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtTargetFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSrcFile);
            this.Controls.Add(this.txtSrcFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FileShredder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSrcFile;
        private System.Windows.Forms.Button btnSrcFile;
        private System.Windows.Forms.OpenFileDialog ofdSrcFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdTarget;
        private System.Windows.Forms.Button btnShredIt;
    }
}

