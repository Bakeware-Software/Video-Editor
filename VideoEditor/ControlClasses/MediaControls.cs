using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    enum MediaColor { Default, Active, Loaded };

    class DynamicMediaControl
    {
        private static List<Color> DefaultColorScheme = new List<Color> { Color.DarkRed, Color.Brown, Color.DarkBlue };

        public List<Color> ColorScheme { get; private set; }

        public Label lTotalTime { get; private set; }

        public VideoPlayer vMediaPlayer { get; private set; }

        private FlowLayoutPanel fBoxContainer, fLabelContainer, fTrackBarContainer;

        public List<VideoFile> vcVideoResources { get; private set; }
        public List<int> iNavigator { get; private set; }

        public int iLongestVideo { get; private set; }

        public int iSecondsToPixelRatio { get; private set; }

        private int iCurrentActiveIndex;
        private int iCurrentLoadedIndex;

        public int iTotalTime { get; private set; }
        public int iTotalFrames { get; private set; }

        public DynamicMediaControl(FlowLayoutPanel t_box_container, FlowLayoutPanel t_label_container, FlowLayoutPanel t_trackbar_container, VideoPlayer t_vMediaPlayer, Label t_time)
        {
            vcVideoResources = new List<VideoFile>();
            iNavigator = new List<int>();

            ColorScheme = new List<Color>(DefaultColorScheme);

            vMediaPlayer = t_vMediaPlayer;

            lTotalTime = t_time;

            fBoxContainer = t_box_container;
            fLabelContainer = t_label_container;
            fTrackBarContainer = t_trackbar_container;

            iSecondsToPixelRatio = 12;

            iCurrentActiveIndex = -1;
            iCurrentLoadedIndex = -1;
            iLongestVideo = -1;

            iTotalTime = 0;
            iTotalFrames = 0;

        }

        public void Add(VideoFile vMediaFile)
        {
            fBoxContainer.Controls.Add(new MediaInfoBox(this, vMediaFile));
            fLabelContainer.Controls.Add(new MediaLabel(this, vMediaFile));
            fTrackBarContainer.Controls.Add(new VideoTrack(this, vMediaFile, iSecondsToPixelRatio));

            vcVideoResources.Add(vMediaFile);

            iNavigator.Add(iTotalTime);

            iTotalTime += (vcVideoResources.Last().iTotalFrames / vcVideoResources.Last().iFramesPerSecond);
            iTotalFrames += vcVideoResources.Last().iTotalFrames;

            Adjust();
        }

        public void Remove()
        {
            if (iCurrentActiveIndex > -1 && iCurrentActiveIndex < vcVideoResources.Count())
            {
                if (iCurrentActiveIndex == iCurrentLoadedIndex)
                {
                    vMediaPlayer.UnloadVideo();

                    iCurrentLoadedIndex = -1;
                }

                fBoxContainer.Controls.RemoveAt(iCurrentActiveIndex);
                fLabelContainer.Controls.RemoveAt(iCurrentActiveIndex);
                fTrackBarContainer.Controls.RemoveAt(iCurrentActiveIndex);

                RemoveFromNavigator(iCurrentActiveIndex);

                iTotalTime -= (vcVideoResources.ElementAt(iCurrentActiveIndex).iTotalFrames / vcVideoResources.ElementAt(iCurrentActiveIndex).iFramesPerSecond);
                iTotalFrames -= vcVideoResources.ElementAt(iCurrentActiveIndex).iTotalFrames;

                vcVideoResources.RemoveAt(iCurrentActiveIndex);

                Adjust();

                iCurrentActiveIndex = -1;

            }
        }

        public void RemoveAt(int iMediaIndex)
        {
            if ((iMediaIndex > -1) && (iMediaIndex < vcVideoResources.Count()))
            {
                if (iMediaIndex == iCurrentLoadedIndex)
                {
                    vMediaPlayer.UnloadVideo();

                    iCurrentLoadedIndex = -1;
                }
                else if (iMediaIndex < iCurrentLoadedIndex)
                {
                    iCurrentLoadedIndex--;
                }

                fBoxContainer.Controls.RemoveAt(iMediaIndex);
                fLabelContainer.Controls.RemoveAt(iMediaIndex);
                fTrackBarContainer.Controls.RemoveAt(iMediaIndex);

                RemoveFromNavigator(iMediaIndex);

                iTotalTime -= (vcVideoResources.ElementAt(iMediaIndex).iTotalFrames / vcVideoResources.Last().iFramesPerSecond);
                iTotalFrames -= vcVideoResources.ElementAt(iMediaIndex).iTotalFrames;

                vcVideoResources.RemoveAt(iMediaIndex);

                Adjust();

                if (iMediaIndex == iCurrentActiveIndex)
                {
                    iCurrentActiveIndex = -1;
                }
                else if (iMediaIndex < iCurrentActiveIndex)
                {
                    iCurrentActiveIndex--;
                }
            }
        }

        private void Adjust()
        {
            iLongestVideo = findLongest();

            vMediaPlayer.tPlayerControls.tTimeTrackBar.Width = vMediaPlayer.tPlayerControls.tTimeTrackBar.Parent.Width;
            SyncTrackBar();

            lTotalTime.Text = lTotalTime.Text.Substring(0, lTotalTime.Text.LastIndexOf('/') + 1) + vMediaPlayer.tPlayerControls.getTimeLabel(iTotalTime);
        }

        public void Clear()
        {
            while (vcVideoResources.Count() > 0)
            {
                RemoveAt(vcVideoResources.Count() - 1);
            }

            iCurrentActiveIndex = -1;
            iCurrentLoadedIndex = -1;

            iLongestVideo = -1;

            iNavigator.Clear();
        }

        public void Activate(int iMediaIndex)
        {
            if ((vcVideoResources.Count() > 0) && (iMediaIndex != iCurrentActiveIndex))
            {
                if (iMediaIndex != iCurrentLoadedIndex)
                {
                    fBoxContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                    fLabelContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                    fTrackBarContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                }

                if (iCurrentActiveIndex != -1 && iCurrentActiveIndex != iCurrentLoadedIndex)
                {

                    fBoxContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
                    fLabelContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
                    fTrackBarContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];

                }

                iCurrentActiveIndex = iMediaIndex;
            }
        }

        public void Load(int iMediaIndex)
        {

            if (iCurrentLoadedIndex != -1)
            {
                fBoxContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
                fLabelContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
                fTrackBarContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];

                vMediaPlayer.UnloadVideo();
            }

            fBoxContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
            fLabelContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
            fTrackBarContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];

            vMediaPlayer.LoadVideo(vcVideoResources[iMediaIndex]);

            iCurrentLoadedIndex = iMediaIndex;


        }

        public void MoveLeft(int iMediaIndex)
        {
            if (iMediaIndex > 0)
            {
                Swap(vcVideoResources, iMediaIndex, iMediaIndex - 1);

                fBoxContainer.Controls.SetChildIndex(fBoxContainer.Controls[iMediaIndex], fBoxContainer.Controls.IndexOf(fBoxContainer.Controls[iMediaIndex]) - 1);
                fLabelContainer.Controls.SetChildIndex(fLabelContainer.Controls[iMediaIndex], fLabelContainer.Controls.IndexOf(fLabelContainer.Controls[iMediaIndex]) - 1);
                fTrackBarContainer.Controls.SetChildIndex(fTrackBarContainer.Controls[iMediaIndex], fTrackBarContainer.Controls.IndexOf(fTrackBarContainer.Controls[iMediaIndex]) - 1);

                NavigatorSwap(iMediaIndex, iMediaIndex - 1);

                Load(FindNavigatorIndex(vMediaPlayer.tPlayerControls.tTimeTrackBar.Value));

            }
        }

        public void MoveRight(int iMediaIndex)
        {
            if (iMediaIndex < vcVideoResources.Count() - 1)
            {
                Swap(vcVideoResources, iMediaIndex, iMediaIndex + 1);

                fBoxContainer.Controls.SetChildIndex(fBoxContainer.Controls[iMediaIndex], fBoxContainer.Controls.IndexOf(fBoxContainer.Controls[iMediaIndex]) + 1);
                fLabelContainer.Controls.SetChildIndex(fLabelContainer.Controls[iMediaIndex], fLabelContainer.Controls.IndexOf(fLabelContainer.Controls[iMediaIndex]) + 1);
                fTrackBarContainer.Controls.SetChildIndex(fTrackBarContainer.Controls[iMediaIndex], fTrackBarContainer.Controls.IndexOf(fTrackBarContainer.Controls[iMediaIndex]) + 1);

                NavigatorSwap(iMediaIndex, iMediaIndex + 1);

                Load(FindNavigatorIndex(vMediaPlayer.tPlayerControls.tTimeTrackBar.Value));

            }
        }

        public void ChangeColorScheme(Color Default, Color Active, Color Loaded)
        {
            ColorScheme.Clear();

            ColorScheme.Add(Default); ColorScheme.Add(Active); ColorScheme.Add(Loaded);

            for (int i = 0; i < vcVideoResources.Count(); i++)
            {
                fBoxContainer.Controls[i].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
                fLabelContainer.Controls[i].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
                fTrackBarContainer.Controls[i].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];

            }

            if (iCurrentLoadedIndex != -1)
            {
                fBoxContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
                fLabelContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
                fTrackBarContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
            }

            if (iCurrentActiveIndex != -1 && iCurrentActiveIndex != iCurrentLoadedIndex)
            {
                fBoxContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                fLabelContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                fTrackBarContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
            }

        }

        public void Recolor(int iMediaIndex, MediaColor Color)
        {
            if (iMediaIndex == iCurrentLoadedIndex)
            {
                fBoxContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
                fLabelContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
                fTrackBarContainer.Controls[iCurrentLoadedIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Loaded)];
                return;
            }
            if (iMediaIndex == iCurrentLoadedIndex)
            {
                fBoxContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                fLabelContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                fTrackBarContainer.Controls[iCurrentActiveIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Active)];
                return;
            }

            fBoxContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
            fLabelContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];
            fTrackBarContainer.Controls[iMediaIndex].BackColor = ColorScheme[Convert.ToInt16(MediaColor.Default)];

        }

        private int findLongest()
        {
            int iMaxDuration = 0, iResult = -1;
            for (int i = 0; i < vcVideoResources.Count(); i++)
            {
                if (vcVideoResources[i].iTotalFrames / vcVideoResources[i].iFramesPerSecond > iMaxDuration)
                {
                    iMaxDuration = vcVideoResources[i].iTotalFrames / vcVideoResources[i].iFramesPerSecond;
                    iResult = i;
                }
            }

            return iResult;
        }

        public int Active()
        {
            return iCurrentActiveIndex;
        }

        public int Loaded()
        {
            return iCurrentLoadedIndex;
        }

        public bool IsEmpty()
        {
            return vcVideoResources.Count() == 0 ? true : false;
        }

        public void Shrink()
        {
            if ((iSecondsToPixelRatio / 2) > 0)
            {
                iSecondsToPixelRatio /= 2;

                fTrackBarContainer.SuspendLayout();

                for (int iMediaIndex = 0; iMediaIndex < vcVideoResources.Count(); iMediaIndex++)
                {
                    fTrackBarContainer.Controls[iMediaIndex].Width /= 2;
                }

                SyncTrackBar();

                fTrackBarContainer.ResumeLayout();
            }
        }

        public void Strech()
        {
            if ((iSecondsToPixelRatio * 2) < 30)
            {
                iSecondsToPixelRatio *= 2;

                fTrackBarContainer.SuspendLayout();

                for (int iMediaIndex = 0; iMediaIndex < vcVideoResources.Count(); iMediaIndex++)
                {
                    fTrackBarContainer.Controls[iMediaIndex].Width *= 2;
                }

                SyncTrackBar();
                fTrackBarContainer.ResumeLayout();
            }
        }

        private void SyncTrackBar()
        {
            vMediaPlayer.tPlayerControls.tTimeTrackBar.Maximum = vMediaPlayer.tPlayerControls.tTimeTrackBar.Width / iSecondsToPixelRatio;
        }

        private void RemoveFromNavigator(int iMediaIndex)
        {
            if ((iMediaIndex >= 0) && (iMediaIndex < iNavigator.Count()))
            {
                int iDifference = vcVideoResources[iMediaIndex].iTotalFrames / vcVideoResources[iMediaIndex].iFramesPerSecond;

                iNavigator.RemoveAt(iMediaIndex);

                if (iMediaIndex < iNavigator.Count())
                {
                    for (int iIndex = iMediaIndex; iIndex < iNavigator.Count(); iIndex++)
                    {
                        iNavigator[iIndex] = iNavigator[iIndex] - iDifference;
                    }
                }
            }
        }

        private void NavigatorSwap(int iMediaIndex_1, int iMediaIndex_2)
        {
            if (iNavigator.Count() >= 2)
            {
                if (iMediaIndex_2 < iMediaIndex_1)
                {
                    int iTempValue = iMediaIndex_1;

                    iMediaIndex_1 = iMediaIndex_2;
                    iMediaIndex_2 = iTempValue;
                }

                if (iMediaIndex_2 < iNavigator.Count())
                {
                    int iTempValue = iNavigator[iMediaIndex_1];

                    iNavigator[iMediaIndex_2] =
                        iNavigator[iMediaIndex_1] +
                        (vcVideoResources[iMediaIndex_1].iTotalFrames / vcVideoResources[iMediaIndex_1].iFramesPerSecond);
                }
            }
        }

        public int FindNavigatorIndex(int iSeconds)
        {
            if (iNavigator.Count() > 0)
            {
                for (int iIndex = 0; iIndex < iNavigator.Count() - 1; iIndex++)
                {
                    if (iSeconds >= iNavigator[iIndex])
                    {
                        return iIndex;
                    }
                }
            }

            if( (iNavigator.Count() == 1) && iSeconds <= (vcVideoResources.Last().iTotalFrames / vcVideoResources.Last().iFramesPerSecond) )
            {
                return 0;
            }

            return -1;
        }

        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}
