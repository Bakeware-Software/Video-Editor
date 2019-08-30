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
using MediaToolkit;


namespace VideoEditor
{
    class VideoPlayer
    {
        public String sTotalPlayTime;

        private Timer tPlayerEngine { get; set; }
        public EditorControls tPlayerControls { get; private set; }

        private PictureBox vOutput { get; set; }
        public Mat mCurrentFrame { get; set; }

        public NAudio.Wave.DirectSoundOut aOutput { get; set; }

        public VideoFile vcCurrentFile { get; set; }

        public bool bIsPlaying { get; private set; }

        public int iCurrentFrameNo { get; set; }
        public int iFrameToAudioRatio { get; private set; }

        public VideoPlayer(PictureBox vPictureBox)
        {
            tPlayerEngine = new Timer();
            tPlayerEngine.Tick += TimerTick;
            tPlayerEngine.Enabled = false;

            mCurrentFrame = new Mat();
            vOutput = vPictureBox;

            vOutput.SizeMode = PictureBoxSizeMode.Zoom;

            aOutput = new NAudio.Wave.DirectSoundOut();

            vcCurrentFile = null;

            iCurrentFrameNo = 0;
            iFrameToAudioRatio = 0;

            sTotalPlayTime = "00:00:00";

        }

        public void SetControls(EditorControls tControls)
        {
            tPlayerControls = tControls;
        }

        public bool LoadVideo(VideoFile vcSource)
        {
            if (tPlayerEngine.Enabled)
            {
                tPlayerEngine.Stop();
            }

            if (aOutput != null && aOutput.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                aOutput.Pause();
            }

            vcCurrentFile = vcSource;

            iCurrentFrameNo = 0;

            sTotalPlayTime = tPlayerControls.getTimeLabel(vcCurrentFile.iTotalFrames / vcCurrentFile.iFramesPerSecond);

            tPlayerControls.Init();

            if (vcCurrentFile.acSource != null)
            {
                aOutput.Init(new NAudio.Wave.WaveChannel32(vcCurrentFile.acSource));
            }

            vcCurrentFile.vcSource.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, iCurrentFrameNo);

            iFrameToAudioRatio = 1;
            if (vcCurrentFile.acSource != null)
            {
                iFrameToAudioRatio = Convert.ToInt32(vcCurrentFile.acSource.Length / vcCurrentFile.iTotalFrames);
            }

            tPlayerEngine.Interval = (vcCurrentFile.iTotalFrames / vcCurrentFile.iFramesPerSecond);

            vcCurrentFile.acSource.Position = 0;

            LoadFrame();

            return true;
        }

        public bool UnloadVideo()
        {
            if (vcCurrentFile != null)
            {
                if (tPlayerEngine.Enabled)
                {
                    tPlayerEngine.Stop();
                }

                if (aOutput != null && vcCurrentFile.acSource != null)
                {
                    aOutput.Pause();
                }

                vcCurrentFile = null;

                sTotalPlayTime = "00:00:00";

                iCurrentFrameNo = 0;
                iFrameToAudioRatio = 1;

                vOutput.Image = null;

            }

            return true;
        }

        public void Play()
        {
            if (vcCurrentFile != null)
            {
                if ((vcCurrentFile.acSource != null) && (aOutput != null))
                {
                    aOutput.Play();
                }

                tPlayerEngine.Start();
            }
        }

        public void Pause()
        {
            if (vcCurrentFile != null)
            {
                if ((vcCurrentFile.acSource != null) && (aOutput != null))
                {
                    aOutput.Pause();
                }

                tPlayerEngine.Stop();
            }
        }

        public void Stop()
        {
            if (vcCurrentFile != null)
            {
                if ((vcCurrentFile.acSource != null) && (aOutput != null))
                {
                    vcCurrentFile.acSource.CurrentTime = new TimeSpan(0, 0, 0, 0, 0);
                    aOutput.Pause();
                }

                tPlayerEngine.Stop();

                iCurrentFrameNo = 0;

                LoadFrame();

                tPlayerControls.Sync();
            }
        }

        public bool IsPlaying()
        {
            return tPlayerEngine.Enabled ? true : false;
        }

        public bool IsEmpty()
        {
            return vcCurrentFile == null ? true : false;
        }

        public void LoadFrame()
        {
            vcCurrentFile.vcSource.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, iCurrentFrameNo);

            vcCurrentFile.vcSource.Read(mCurrentFrame);

            vOutput.Image = mCurrentFrame.Bitmap;

            iCurrentFrameNo++;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (vcCurrentFile.acSource != null && (iCurrentFrameNo / vcCurrentFile.iFramesPerSecond) < Convert.ToInt32(vcCurrentFile.acSource.CurrentTime.TotalSeconds))
            {
                iCurrentFrameNo = Convert.ToInt32(vcCurrentFile.acSource.CurrentTime.TotalSeconds * vcCurrentFile.iFramesPerSecond);
            }

            if (iCurrentFrameNo >= vcCurrentFile.iTotalFrames)
            {

                if ((tPlayerControls.vConnectedControls.vcVideoResources.IndexOf(vcCurrentFile)) == tPlayerControls.vConnectedControls.vcVideoResources.Count() - 1)
                {
                    tPlayerControls.vConnectedControls.Load(0);

                    Stop();

                    return;
                }

                tPlayerControls.vConnectedControls.Load(tPlayerControls.vConnectedControls.vcVideoResources.IndexOf(vcCurrentFile) + 1);

                Play();

                return;
            }

            LoadFrame();

            tPlayerControls.Sync();

        }
    }

    class EditorControls
    {
        public CustomRangeSlider cRangeTrackbar { get; private set; }

        public TrackBar tFrameTrackBar { get; private set; }
        public TrackBar tTimeTrackBar { get; private set; }

        public Label lFrameStamp { get; private set; }
        public Label lTimeStamp { get; private set; }

        public Label lTotalTime { get; private set; }

        public VideoPlayer vMediaPlayer { get; private set; }
        public DynamicMediaControl vConnectedControls { get; private set; }


        public EditorControls(TrackBar t_frametrack, TrackBar t_timetrack, Label l_frameStamp, Label l_timeStamp, DynamicMediaControl v_ConnectedControls, VideoPlayer v_Associate)
        {
            vMediaPlayer = v_Associate;
            vConnectedControls = v_ConnectedControls;

            tFrameTrackBar = t_frametrack;
            tFrameTrackBar.Scroll += frameTrackScroll;

            tTimeTrackBar = t_timetrack;
            tTimeTrackBar.Scroll += timeTrackScroll;
            tTimeTrackBar.Resize += timeTrackResize;

            cRangeTrackbar = new CustomRangeSlider(tTimeTrackBar);

            tTimeTrackBar.Parent.Controls.Add(cRangeTrackbar);
            tTimeTrackBar.Parent.Controls.SetChildIndex(cRangeTrackbar, 1);

            cRangeTrackbar.Width = tTimeTrackBar.Width;
            cRangeTrackbar.Margin = new Padding(12, 0, 3, 0);

            lTotalTime = vConnectedControls.lTotalTime;

            lFrameStamp = l_frameStamp;
            lTimeStamp = l_timeStamp;

        }

        private void frameTrackScroll(object sender, EventArgs e)
        {
            if (!vMediaPlayer.IsEmpty())
            {
                int iTrackValue = (sender as TrackBar).Value;
                if (iTrackValue + 1 < (sender as TrackBar).Maximum)
                {
                    vMediaPlayer.iCurrentFrameNo = iTrackValue;

                    if (vMediaPlayer.vcCurrentFile.acSource != null)
                    {
                        vMediaPlayer.vcCurrentFile.acSource.CurrentTime = new TimeSpan(0, 0, 0, vMediaPlayer.iCurrentFrameNo / vMediaPlayer.vcCurrentFile.iFramesPerSecond, 0);
                    }

                    vMediaPlayer.LoadFrame();

                    Sync();
                }
            }
        }

        private void timeTrackScroll(object sender, EventArgs e)
        {
            int iTrackBarValue = (sender as TrackBar).Value;

            if (vMediaPlayer.IsEmpty())
            {
                if (vConnectedControls.vcVideoResources.Count() > 0)
                {
                    int iVideoIndex = vConnectedControls.FindNavigatorIndex(iTrackBarValue);
                    if(iVideoIndex >= 0)
                    {
                        vConnectedControls.Load(iVideoIndex);
                    }
                }

                return;
            }
            
            while (iTrackBarValue >= vConnectedControls.iNavigator[vConnectedControls.vcVideoResources.IndexOf(vMediaPlayer.vcCurrentFile)] + (vMediaPlayer.vcCurrentFile.iTotalFrames / vMediaPlayer.vcCurrentFile.iFramesPerSecond))
            {
                int iVideoIndex = vConnectedControls.vcVideoResources.IndexOf(vMediaPlayer.vcCurrentFile) + 1;

                if (iVideoIndex < vConnectedControls.vcVideoResources.Count())
                {
                    vConnectedControls.Load(iVideoIndex);
                }
                else
                {
                    return;
                }

            }

            while (iTrackBarValue < vConnectedControls.iNavigator[vConnectedControls.vcVideoResources.IndexOf(vMediaPlayer.vcCurrentFile)])
            {
                int iVideoIndex = vConnectedControls.vcVideoResources.IndexOf(vMediaPlayer.vcCurrentFile) - 1;

                if (iVideoIndex > -1)
                {
                    vConnectedControls.Load(iVideoIndex);
                }
                else
                {
                    return;
                }
            }

            vMediaPlayer.iCurrentFrameNo = (iTrackBarValue - vConnectedControls.iNavigator.ElementAt(vConnectedControls.vcVideoResources.IndexOf(vMediaPlayer.vcCurrentFile)))
                * vMediaPlayer.vcCurrentFile.iFramesPerSecond;

            if (vMediaPlayer.vcCurrentFile.acSource != null)
            {
                vMediaPlayer.vcCurrentFile.acSource.CurrentTime = new TimeSpan(0, 0, 0, vMediaPlayer.iCurrentFrameNo / vMediaPlayer.vcCurrentFile.iFramesPerSecond, 0);
            }

            vMediaPlayer.LoadFrame();

            Sync();

        }

        private void timeTrackResize(object sender, EventArgs e)
        {
            cRangeTrackbar.Width = (sender as TrackBar).Width;
        }

        public void Sync()
        {
            if (vMediaPlayer.vcCurrentFile != null && vMediaPlayer.vcCurrentFile.iFramesPerSecond > 0)
            {
                tFrameTrackBar.Value = vMediaPlayer.iCurrentFrameNo;
                tTimeTrackBar.Value = vConnectedControls.iNavigator.ElementAt(vConnectedControls.vcVideoResources.IndexOf(vMediaPlayer.vcCurrentFile)) +
                                           tFrameTrackBar.Value / vMediaPlayer.vcCurrentFile.iFramesPerSecond;

                lTimeStamp.Text = getTimeLabel(vMediaPlayer.iCurrentFrameNo / vMediaPlayer.vcCurrentFile.iFramesPerSecond) + "/" + vMediaPlayer.sTotalPlayTime;
                lFrameStamp.Text = "Frame: " + Convert.ToString(tFrameTrackBar.Value);

                lTotalTime.Text = "Total time: " + getTimeLabel(tTimeTrackBar.Value) + "/" + getTimeLabel(vConnectedControls.iTotalTime);
            }
        }

        public void Init()
        {
            if (vMediaPlayer.vcCurrentFile != null)
            {
                tFrameTrackBar.Minimum = 0;
                tFrameTrackBar.Maximum = vMediaPlayer.vcCurrentFile.iTotalFrames + 1;

                tTimeTrackBar.Minimum = 0;

                lTimeStamp.Text = "00:00:00/" + vMediaPlayer.sTotalPlayTime;
                lFrameStamp.Text = "Frame: ";
            }
        }

        public string getTimeLabel(int iSeconds)
        {
            string sResult = "00:00:00";

            if (iSeconds != 0)
            {
                sResult = "";

                int iTemp = iSeconds / 3600;
                sResult = sResult + (iTemp < 10 ? "0" + Convert.ToString(iTemp) + ":" : Convert.ToString(iTemp) + ":");

                iTemp = (iSeconds - (iSeconds / 3600) * 3600) / 60;
                sResult = sResult + (iTemp < 10 ? "0" + Convert.ToString(iTemp) + ":" : Convert.ToString(iTemp) + ":");

                iTemp = iSeconds - ((iSeconds / 60) * 60);
                sResult = sResult + (iTemp < 10 ? "0" + Convert.ToString(iTemp) : Convert.ToString(iTemp));
            }

            return sResult;
        }

        public int convertToSeconds(string sTimeLabel)
        {
            int iResult = 0;

            if (sTimeLabel.Length > 1)
            {
                iResult = iResult + Convert.ToInt32(sTimeLabel.Substring(0, 2)) * 3600;
            }

            if (sTimeLabel.Length > 4)
            {
                iResult = iResult + Convert.ToInt32(sTimeLabel.Substring(3, 2)) * 60;
            }

            if (sTimeLabel.Length > 7)
            {
                iResult = iResult + Convert.ToInt32(sTimeLabel.Substring(6, 2));
            }

            return iResult;
        }
    }
}
