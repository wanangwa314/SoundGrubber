using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundGrubber
{
    partial class Form1 
    {
        int sec = 0, min = 0, hour = 0;
        string time = "00:00:00";

        //Set state of UI controls to prevent premature activation of recording 
        //components before resources are initialised
        private void InitUI()
        {
            
            fileNameTextbx.Enabled = false;
            directoryPathTextbx.Enabled = false;

            cancelRecBtn.Visible = false;
            startRecBtn.Visible = false;
            stopRecBtn.Visible = false;
            timeView.Visible = false;
        }

        //Reverse of InitUI method just a sets the state of 
        //newRecBtn button to false
        private void InitRecordingControls()
        {
            newRecBtn.Enabled = false;
            fileNameTextbx.Enabled = true;
            directoryPathTextbx.Enabled = true;
          
            startRecBtn.Visible = true;
            stopRecBtn.Visible = true;
            stopRecBtn.Enabled = false;
            timeView.Visible = true;
        }
        
        private void OnStartRecording()
        {
            startRecBtn.Enabled = false;
            stopRecBtn.Enabled = true;
        }

        private void RecTime_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;
                }
            }
            timeView.Text = TimeFormatter(sec, min, hour);
        }

        private string TimeFormatter(int sec, int min, int hour)
        {
            string secStr = "", minStr = "", hourStr = "";
            if (sec < 10)
            {
                secStr = "0" + sec;
            }
            else { secStr = sec.ToString(); }

            if (min < 10)
            {
                minStr = "0" + min;
            }
            else { minStr = min.ToString(); }

            if (hour < 10)
            {
                hourStr = "0" + hour;
            }
            else { hourStr = hour.ToString(); }
            return string.Format("{0}:{1}:{2}", hourStr, minStr, secStr);
        }
    }
}
