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

namespace SoundGrubber
{
    public partial class New_Recording_Dialog : Form
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public New_Recording_Dialog()
        {
            InitializeComponent();
            //Set default text in UI text file
            fileNameTextBx.Text = "recording.wav";
            filePathTextBx.Text = Directory.GetCurrentDirectory() + "\\" + fileNameTextBx.Text;
        }
        
        //Helps user select folder to save file using FileBrowserDialog
        private void browseBtn_Click(object sender, EventArgs e)
        {
            if(fileNameTextBx.Text == string.Empty)
            {
                MessageBox.Show("ERROR: Enter Name in filename Text field");
                return;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            filePathTextBx.Text = string.Format(@"{0}", folderBrowserDialog.SelectedPath);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            ValidateInputs();
            Close();
        }

        private void ValidateInputs()
        {
            //Check if filename contain extension .wav
            //add it if the name does not contain the extension
            if(fileNameTextBx.Text.Contains(".wav") == false)
            {
                fileNameTextBx.Text += ".wav";
            }

            //Check if directory exists if not ask user if we can
            //automatically create one
            if(!Directory.Exists(filePathTextBx.Text))
            {
                MessageBox.Show("Directory does not exist, Create Directory", "Directory not found", MessageBoxButtons.OKCancel);
                Directory.CreateDirectory(filePathTextBx.Text);
            }

            FileName = fileNameTextBx.Text;
            FilePath = string.Format(filePathTextBx.Text);
        }
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
