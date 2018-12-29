using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundGrubber
{
    partial class Form1 
    { 
        
        //Set state of UI controls to prevent premature activation of recording 
        //components before resources are initialised
        private void InitUI()
        {
            fileNameTextbx.Enabled = false;
            directoryPathTextbx.Enabled = false;
            browseBtn.Enabled = false;
            startRecBtn.Visible = false;
            stopRecBtn.Visible = false;
            timeView.Visible = false;
        }

        //Reverse of InitUI method just a sets the state of 
        //newRecBtn button to false
        private void InitRecordingControls()
        {
            newRecBtn.Enabled = false;
            fileNameTextbx.Enabled = false;
            directoryPathTextbx.Enabled = false;
            browseBtn.Enabled = false;
            startRecBtn.Visible = false;
            stopRecBtn.Visible = false;
            timeView.Visible = false;
        }
    }
}
