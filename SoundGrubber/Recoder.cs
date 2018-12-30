using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Timers;
using System.Windows.Forms;

namespace SoundGrubber
{
    /// <summary>
    /// Records sound from soundcard using the Naudio WasapiWaveLoopback class
    /// </summary>
    class Recoder 
    {
        private WasapiLoopbackCapture wasapiLoopbackCapture = null;//buffers audio data and provides to us
        private WaveFileWriter waveFileWriter = null;//Writes audio data to output file
        public bool RecordingState { get; set; }
        private System.Timers.Timer recordingTime;
        public string GetTime { get; set; }

        /// <summary>
        /// Initializes new instance of SdOutRecorder and all its resources
        /// </summary>
        /// <param name="outputFilePath"></param>
        
        public Recoder(string outputFilePath)
        {
            wasapiLoopbackCapture = new WasapiLoopbackCapture();

            //Create new instance of WaveFileWriter and takes a filepath outputFilePath 
            //and format of the wave data being receive from WasapiLoopbackCapture
            try
            {
                WaveFileWriter waveFileWriter = new WaveFileWriter(outputFilePath, wasapiLoopbackCapture.WaveFormat);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "App Error" , MessageBoxButtons.OK);
            }
            
            
            recordingTime = new System.Timers.Timer(1000);
            recordingTime.Elapsed += Time_Elapsed;
        }

        /// <summary>
        /// Starts recording wave data from SoundCard
        /// </summary>
        public void StartRecording()
        {
            wasapiLoopbackCapture.StartRecording();
            RecordingState = true;

            //When this event happens it calls WasapiLoopbackCapture_DataAvailable
            //Which data to waveFileWriter
            wasapiLoopbackCapture.DataAvailable += WasapiLoopbackCapture_DataAvailable;
            recordingTime.Start();
        }

        /// <summary>
        /// Stops recording wave data from SoundCard and releases all resources
        /// </summary>
        public void StopRecording()
        {
            wasapiLoopbackCapture.StopRecording();
            RecordingState = false;
            recordingTime.Stop();
       
            waveFileWriter.Dispose();
            waveFileWriter = null;

            wasapiLoopbackCapture.Dispose();
            
        }

        private void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            int min = 0;
            int hour = 0;
            int sec = 0;

            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    hour++;
                }
            }
            GetTime = TimeFormatter(sec, min, hour);

        }
        
        
        //Writes wave data to file.
        private void WasapiLoopbackCapture_DataAvailable(object sender, WaveInEventArgs e)
        {
            waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
        }

        

        private string TimeFormatter(int sec, int min, int hour)
        {
            string secStr = "", minStr = "", hourStr = "";

            if(sec < 10)
            {
                secStr = "0" + sec;
            }
            if (min < 10)
            {
                minStr = "0" + min;
            }
            if (hour < 10)
            {
                hourStr = "0" + hour;
            }

            return string.Format("{0}:{1}:{2}", hourStr, minStr, secStr);
        }
        
    }
}
