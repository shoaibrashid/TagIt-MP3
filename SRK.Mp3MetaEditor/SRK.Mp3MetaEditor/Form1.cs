using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRK.Mp3MetaEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btn_BrowseDialog_Click(object sender, EventArgs e)
        {
            if (fbd_Path.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = fbd_Path.SelectedPath;
            }
        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.txt_Path.Text))
                {
                    this.progressBar1.Visible = true;
                    bg_Worker.RunWorkerAsync();
                    this.progressBar1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please select folder.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txt_Path.Text))
            {
                this.txt_Path.Text = string.Empty;
            }
        }

        private void bg_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int int_counter = 0;
            int int_renamed = 0;
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;

                string dirPath = txt_Path.Text;
                DirectoryInfo dir_Source = new DirectoryInfo(txt_Path.Text);
                FileInfo[] files = dir_Source.GetFiles("*.mp3");
                foreach (FileInfo file in files)
                {
                    int_counter += 1;
                    string finalName = string.Empty;
                    if (file.Name.Contains('-'))
                    {
                        int_renamed += 1;
                        finalName = file.Name.Remove(0, file.Name.LastIndexOf('-') + 1).Trim();
                        finalName = Path.Combine(file.Directory.FullName, finalName);
                        worker.ReportProgress((int_counter * 10));
                        File.Move(file.FullName, finalName);
                        TagLib.File tagFile = TagLib.File.Create(finalName);
                        if (tagFile.Tag.Title.Contains("- SongsPK.info")) {
                            tagFile.Tag.Title = tagFile.Tag.Title.Replace("- SongsPK.info", "");
                            tagFile.Save();
                        }
                    }
                }
                this.txt_Path.Text = "";
                e.Result=(new RenameProgress(int_counter,int_renamed,Constants.Success,string.Empty));
            }
            catch (Exception ex)
            {
                e.Result = (new RenameProgress(int_counter, int_renamed, Constants.Failure,ex.Message));
            }
        }

        private void bg_Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bg_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                MessageBox.Show("Canceled!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (!(e.Error == null))
            {
                MessageBox.Show("Error: " + e.Error.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.Result != null) {
                RenameProgress obj_RenameProgress =(RenameProgress)e.Result;
                if (obj_RenameProgress != null) {
                    if (obj_RenameProgress._renameStatus.Equals(Constants.Success)) {

                        string message=String.Format("Successfully renamed {0} songs out of {1}.", obj_RenameProgress._renamedFilesCount, obj_RenameProgress._totalFilesCount);
                        MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (obj_RenameProgress._renameStatus.Equals(Constants.Failure)) {
                        MessageBox.Show("An error has been occurred."+obj_RenameProgress._errorMessage, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
    }
}
