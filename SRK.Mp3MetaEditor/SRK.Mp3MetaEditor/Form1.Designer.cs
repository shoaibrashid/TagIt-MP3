namespace SRK.Mp3MetaEditor
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
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BrowseDialog = new System.Windows.Forms.Button();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fbd_Path = new System.Windows.Forms.FolderBrowserDialog();
            this.bg_Worker = new System.ComponentModel.BackgroundWorker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(89, 39);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(347, 20);
            this.txt_Path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse Folder";
            // 
            // btn_BrowseDialog
            // 
            this.btn_BrowseDialog.Location = new System.Drawing.Point(436, 37);
            this.btn_BrowseDialog.Name = "btn_BrowseDialog";
            this.btn_BrowseDialog.Size = new System.Drawing.Size(30, 23);
            this.btn_BrowseDialog.TabIndex = 2;
            this.btn_BrowseDialog.Text = "...";
            this.btn_BrowseDialog.UseVisualStyleBackColor = true;
            this.btn_BrowseDialog.Click += new System.EventHandler(this.btn_BrowseDialog_Click);
            // 
            // btn_Rename
            // 
            this.btn_Rename.Location = new System.Drawing.Point(314, 71);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(75, 23);
            this.btn_Rename.TabIndex = 3;
            this.btn_Rename.Text = "Rename";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(89, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // fbd_Path
            // 
            this.fbd_Path.ShowNewFolderButton = false;
            // 
            // bg_Worker
            // 
            this.bg_Worker.WorkerReportsProgress = true;
            this.bg_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_Worker_DoWork);
            this.bg_Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_Worker_ProgressChanged);
            this.bg_Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_Worker_RunWorkerCompleted);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(391, 71);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bulk Rename Utility";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 128);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.btn_BrowseDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MP3 Meta Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BrowseDialog;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog fbd_Path;
        private System.ComponentModel.BackgroundWorker bg_Worker;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label2;
    }
}

