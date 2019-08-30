using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEditor
{
    /// <summary>
    /// List of all tooltip items and dynamic tooltip allocation for playlist
    /// </summary>

    class ToolTipsList 
    {
        public string PlayButton { get; set; }
        public string StopButton { get; set; }
        public string AddButton  { get; set; }
        public string AudioButton { get; set; }
        public string TimeLabel { get; set; }

        public ToolTipsList()
        {
            PlayButton  =               "Use this button to play the video";
            StopButton  = "Use this button to stop currently playing video";
            AddButton   =    "Use this button to add video to the playlist";
            TimeLabel   = "Displays current media playback time";
            AudioButton = "Add audio file";
        }


    }
}
