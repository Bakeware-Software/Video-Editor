using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

using Emgu.CV;
using Emgu.CV.Structure;

using NAudio;
using NAudio.Wave;

using MediaToolkit;
using MediaToolkit.Model;

namespace VideoEditor
{
    /// <summary>
    /// Generates new WaveViever with is a Winforms object clas in NAudio dll.
    /// </summary>
    class AudioFile
    {
        public WaveChannel32 wcWave { get; set; }

        public AudioFile(string AudioName)
        {
            /* DODALEM ZABEZPIECZONKO BO WYPIERDALALO */
            try
            {
                wcWave = new WaveChannel32(new WaveFileReader(AudioName));
            }catch
            {
                MessageBox.Show("Unexpected error while audio loading.");
            }
        }
    }
}
