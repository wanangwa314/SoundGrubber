﻿using System;
using System.Windows.Forms;
using System.IO;

namespace SoundGrubber
{
    public partial class Form1 : Form
    {
        Recoder recoder;
        string filePath = null;
        public Form1()
        {
            InitializeComponent();
            InitUI();
        }

        //Initialise recording controls and new instance of
        //recorder object
        private void newRecBtn_Click(object sender, EventArgs e)
        {

            New_Recording_Dialog new_Recording_Dialog = new New_Recording_Dialog();
            new_Recording_Dialog.ShowDialog();

            cancelRecBtn.Visible = true;
            directoryPathTextbx.Text = new_Recording_Dialog.FilePath;
            fileNameTextbx.Text = new_Recording_Dialog.FileName;
            InitRecordingControls();
            
            recoder = new Recoder(string.Format("{0}\\{1}", directoryPathTextbx.Text, fileNameTextbx.Text));
            filePath = string.Format("{0}\\{1}", directoryPathTextbx.Text, fileNameTextbx.Text);
        }

        //Start recording and sets UI to a recording state 
        private void startRecBtn_Click(object sender, EventArgs e)
        {
            OnStartRecording();
            recoder.StartRecording();        
        }

        //Stop recording and reset UI
        private void stopRecBtn_Click(object sender, EventArgs e)
        {
            recoder.StopRecording();
            InitUI();//Resets UI
        }

        //Cancel a new recording and delete file if it was created
        //And also resets UI
        private void cancelRecBtn_Click(object sender, EventArgs e)
        {
            InitUI();//Resets UI
            recoder.Dispose();
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
