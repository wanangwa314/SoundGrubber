using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundGrubber
{
    public partial class Form1 : Form
    {
        Recoder recoder;
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
            Task.Factory.StartNew(() => Application.Run(new_Recording_Dialog)).Wait();

            directoryPathTextbx.Text = new_Recording_Dialog.FilePath;
            fileNameTextbx.Text = new_Recording_Dialog.FileName;
            InitRecordingControls();
            
            recoder = new Recoder(string.Format("{0}\\{1}", directoryPathTextbx.Text, fileNameTextbx.Text));
        }

        private void startRecBtn_Click(object sender, EventArgs e)
        {
            OnStartRecording();
            recoder.StartRecording();        
        }

        private void stopRecBtn_Click(object sender, EventArgs e)
        {
            recoder.StopRecording();
        }
    }
}
