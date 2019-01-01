using System;
using NAudio.Wave;
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
                waveFileWriter = new WaveFileWriter(outputFilePath, wasapiLoopbackCapture.WaveFormat);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "App Error" , MessageBoxButtons.OK);
            }
                
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
            
        }

        /// <summary>
        /// Stops recording wave data from SoundCard and releases all resources
        /// </summary>
        public void StopRecording()
        {
            wasapiLoopbackCapture.StopRecording();
            RecordingState = false;
            
       
            waveFileWriter.Dispose();
            waveFileWriter = null;

            wasapiLoopbackCapture.Dispose();
            
        }

        //Writes wave data to file.
        private void WasapiLoopbackCapture_DataAvailable(object sender, WaveInEventArgs e)
        {
            waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
        }

        /// <summary>
        /// Release resources after use
        /// </summary>
        public void Dispose()
        {
            if(RecordingState == true && wasapiLoopbackCapture != null)
            {
                wasapiLoopbackCapture.StopRecording();
            }
            if(wasapiLoopbackCapture != null && waveFileWriter != null)
            {
                wasapiLoopbackCapture.Dispose();
                waveFileWriter.Close();
                waveFileWriter.Dispose();
            }
                
        }
        
    }
}
