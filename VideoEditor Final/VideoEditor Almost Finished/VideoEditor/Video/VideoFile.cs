using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Emgu.CV;
using Emgu.CV.Structure;



using NAudio;
using NAudio.Wave;

using MediaToolkit;
using MediaToolkit.Model;

namespace VideoEditor
{
   
    class VideoFile
    {
        public VideoCapture vcSource    { get; set; }
        public MediaFoundationReader acSource { get; set; }

        public Mat mThumbnail           { get; set; }

        public string sFileName         { get; set; }

        public int iTotalFrames         { get; set; }
        public int iFramesPerSecond     { get; set; }

        public VideoFile()
        {
            sFileName = "";

            vcSource = null;

            iTotalFrames = 0;
            iFramesPerSecond = 0;

            mThumbnail = new Mat();

        }

        public VideoFile(string sFileName)
        {
            var inputFile = new MediaFile { Filename = sFileName };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);
            }

            try
            {
                vcSource = new VideoCapture(sFileName);
            }
            catch
            {
                MessageBox.Show("Error 104");
            }

            try
            {
                acSource = new MediaFoundationReader(sFileName);
            }catch
            {
                Debug.WriteLine("No audio, or it is corrupted.");
            }

            mThumbnail = new Mat();

            this.sFileName = sFileName;

            vcSource.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
            vcSource.Read(mThumbnail);

            iTotalFrames = Convert.ToInt32(vcSource.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount)) + 1;
            iFramesPerSecond = Convert.ToInt32(inputFile.Metadata.VideoData.Fps);

            vcSource.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 10);
            vcSource.Read(mThumbnail);

            vcSource.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
        }
    }
}
