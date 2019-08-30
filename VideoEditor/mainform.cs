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
using System.Runtime.Serialization;
using System.IO;

using Emgu.CV;
using Emgu.CV.Structure;

using MediaToolkit;
using NAudio;

namespace VideoEditor
{
    public partial class mainform : Form
    {
        #region program_variables

        DynamicMediaControl mMediaContainer; // 

        Interface inResources;

        VideoProject vCurrentProject;

        VideoPlayer vVideoPlayer;

        FFMPEG mainEngine;

        ToolTipsList tToolList;
        ToolTip tToolTips;

        #endregion

        public mainform()
        {
            InitializeComponent();
        }

        #region interface_functions

        private void load_interface(Interface.GraphicTheme  mode)
        {
            //Main Background
            inResources.SetBackground(this,                 mode);

            //Flow Layout Panels
            inResources.SetBackground(fMediaList,           mode);
            inResources.SetBackground(fMediaBoxPanel,       mode);
            inResources.SetBackground(fControlPanel,        mode);
            inResources.SetBackground(fTrackPanel,          mode);
            inResources.SetBackground(fTrackInterfacePanel, mode);

            //Labels
            inResources.SetBackground(lFrameStamp,          mode);
            inResources.SetBackground(lTimeStamp,           mode);
            inResources.SetBackground(lProFolder,           mode);
            inResources.SetBackground(lProFps,              mode);
            inResources.SetBackground(lProLabel,            mode);
            inResources.SetBackground(lProResolution,       mode);
            inResources.SetBackground(lProTitle,            mode);
            inResources.SetBackground(lCommsConsole,        mode);

            //Buttons
            inResources.SetBackground(vShrinkButton,        mode);
            inResources.SetBackground(vGrowButton,          mode);
            inResources.SetBackground(fPlayerButtons,       mode);

            //TrackBar
            inResources.SetBackground(vVideoSlider,         mode);
           
        }

        #endregion


        #region mainform_events

        private void mainForm_Load(object sender, EventArgs e)
        {
            inResources = new Interface();

            vVideoPlayer = new VideoPlayer(vMainScreen);

            mMediaContainer = new DynamicMediaControl(fMediaBoxPanel, fMediaList, fMainTrackPanel, vVideoPlayer, sTotalPlayTime);

            vVideoPlayer.SetControls(new EditorControls(vVideoSlider, trackTimeLine, lFrameStamp, lTimeStamp, mMediaContainer, vVideoPlayer));       

            tToolList = new ToolTipsList();
            tToolTips = new ToolTip();

            vCurrentProject = new VideoProject();

            trackTimeLine.Value = 0;

            mainEngine = new FFMPEG("ffmpeg.exe");

            load_interface(Interface.GraphicTheme.Dark);

            generateToolTips();

            setMessage("Ready");
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs closingEvents)
        {
            if (vCurrentProject != null && vCurrentProject.wasChanged())
            {
                DialogResult dResult = MessageBox.Show("Do you want to save current project ?", "Closing Video Editor", MessageBoxButtons.YesNoCancel);
                switch (dResult)
                {
                    case DialogResult.Yes:
                        if (vCurrentProject.getProFolder() == "")
                        {
                            vCurrentProject.setProFolder(chooseFolder());
                        }
                        vCurrentProject.saveProject();
                        break;
                    case DialogResult.Cancel:
                        closingEvents.Cancel = true;
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        private void vPlayButtonClick(object sender, EventArgs e)
        {

            if (!vVideoPlayer.IsEmpty() && !vVideoPlayer.IsPlaying())
            {
                vVideoPlayer.Play();
                setMessage("Playing.");
            }
        }

        private void vGrowButton_Click(object sender, EventArgs e)
        {
            mMediaContainer.Strech();
        }

        private void vPauseButton_Click(object sender, EventArgs e)
        {
            if (!vVideoPlayer.IsEmpty() && vVideoPlayer.IsPlaying())
            {
                vVideoPlayer.Pause();
                setMessage("Paused.");
            }
        }

        private void vStopButton_Click(object sender, EventArgs e)
        {
            if (!vVideoPlayer.IsEmpty())
            {
                vVideoPlayer.Stop();
                setMessage("Paused.");
            }
        }

        private void vPrevButton_Click(object sender, EventArgs e)
        {
            if (!vVideoPlayer.IsEmpty())
            {
                int iVideoIndex = mMediaContainer.vcVideoResources.IndexOf(vVideoPlayer.vcCurrentFile) - 1;
                if(mMediaContainer.vcVideoResources.Count() > 0 && iVideoIndex >= 0)
                {
                    mMediaContainer.Load(iVideoIndex);
                }
            }
        }

        private void vNextButton_Click(object sender, EventArgs e)
        {
            if (!vVideoPlayer.IsEmpty())
            {
                int iVideoIndex = mMediaContainer.vcVideoResources.IndexOf(vVideoPlayer.vcCurrentFile) + 1;
                if (iVideoIndex < mMediaContainer.vcVideoResources.Count())
                {
                    mMediaContainer.Load(iVideoIndex);
                }
            }
        }

        #region button_events_edit_main

        private void addVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePicker = new OpenFileDialog();

            if (filePicker.ShowDialog() == DialogResult.OK)
            {

                vCurrentProject.addMedia(filePicker.FileName);
                setMessage("Wait...");

                addVideo(filePicker.FileName);
            }
        }

        private void tAudioRemove_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(vCurrentProject.getProFolder()))
            {
                MessageBox.Show("You need to specify project folder!");
                vCurrentProject.setProFolder(chooseFolder());
            }

            if (mMediaContainer.Active() > -1)
            {
                if (vVideoPlayer.IsPlaying())
                {
                    vVideoPlayer.Pause();
                }

                setMessage("Wait...");
                String sResultMedia = mainEngine.removeAudio
                (
                    vCurrentProject.sMediaResources.ElementAt(mMediaContainer.Active()),
                    vCurrentProject.getProFolder()
                );

                if (sResultMedia != "")
                {
                    mMediaContainer.Remove();
                    addVideo(sResultMedia);
                    vCurrentProject.addMedia(sResultMedia);

                    setMessage("Audio successfully removed.");
                }

            }
        }

        private void tAudioExtract_Click(object sender, EventArgs e)
        {
            if (mMediaContainer.Active() > -1)
            {
                if (!Directory.Exists(vCurrentProject.getProFolder()))
                {
                    MessageBox.Show("You need to specify project folder!");
                    vCurrentProject.setProFolder(chooseFolder());
                }

                if (vVideoPlayer.IsPlaying())
                {
                    vVideoPlayer.Pause();
                }

                setMessage("Wait...");
                mainEngine.extractAudio
                (
                    vCurrentProject.sMediaResources.ElementAt(mMediaContainer.Active()), 
                    vCurrentProject.getProFolder()
                );
            }
        }

        private void tEditSpeedChange_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(vCurrentProject.getProFolder()))
            {
                MessageBox.Show("You need to specify project folder!");
                vCurrentProject.setProFolder(chooseFolder());
            }

            if (mMediaContainer.Active() > -1)
            {
                double dSpeedModifier = 1.0;

                using (menuSpeed smMenuSpeed = new menuSpeed())
                {
                    smMenuSpeed.Activate();

                    if (smMenuSpeed.ShowDialog(this) == DialogResult.OK)
                    {
                        dSpeedModifier = smMenuSpeed.dValue;

                        if (vVideoPlayer.IsPlaying())
                        {
                            vVideoPlayer.Pause();
                        }

                        setMessage("Wait...");
                        String sResultMedia = mainEngine.changeSpeed
                        (
                            vCurrentProject.sMediaResources.ElementAt(mMediaContainer.Active()), 
                            vCurrentProject.getProFolder(), dSpeedModifier
                        );

                        if (sResultMedia != "")
                        {
                            vCurrentProject.removeMedia(mMediaContainer.Active());
                            mMediaContainer.Remove();

                            addVideo(sResultMedia);
                            vCurrentProject.addMedia(sResultMedia);

                            setMessage("Speed successfully changed.");

                        }
                    }
                }
            }
        }

        private void tCutInsert_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(vCurrentProject.getProFolder()))
            {
                MessageBox.Show("You need to specify project folder!");
                vCurrentProject.setProFolder(chooseFolder());
            }

            if (mMediaContainer.Active() > -1)
            {
                if (vVideoPlayer.IsPlaying())
                {
                    vVideoPlayer.Pause();
                }

                setMessage("Wait...");
                List<String> sResultMediaList = mainEngine.cutVideo(vCurrentProject.sMediaResources.ElementAt
                (
                    mMediaContainer.Active()), 
                    vCurrentProject.getProFolder(),
                    trackTimeLine.Value - mMediaContainer.iNavigator[mMediaContainer.Active()]
                );

                if (sResultMediaList.Count() > 0)
                {
                    mMediaContainer.Remove();

                    foreach (String sMediaPath in sResultMediaList)
                    {
                        vCurrentProject.addMedia(sMediaPath);
                        addVideo(sMediaPath);
                        
                    }
                    setMessage("Video has been successfully cut.");
                }
            }
        }

        private void tCutRegion_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(vCurrentProject.getProFolder()))
            {
                MessageBox.Show("You need to specify project folder!");
                vCurrentProject.setProFolder(chooseFolder());
            }

            if (mMediaContainer.Active() > -1)
            {
                if (vVideoPlayer.IsPlaying())
                {
                    vVideoPlayer.Pause();
                }

                int iStartPosition = 0, iEndPosition = mMediaContainer.iNavigator[mMediaContainer.Active()] + (vVideoPlayer.tPlayerControls.cRangeTrackbar.getEnd() - vVideoPlayer.tPlayerControls.cRangeTrackbar.getStart()) / mMediaContainer.iSecondsToPixelRatio;

                if ( (vVideoPlayer.tPlayerControls.cRangeTrackbar.getStart() / mMediaContainer.iSecondsToPixelRatio) > mMediaContainer.iNavigator[mMediaContainer.Active()])
                {
                    iStartPosition = mMediaContainer.iNavigator[mMediaContainer.Active()] + (vVideoPlayer.tPlayerControls.cRangeTrackbar.getStart() / mMediaContainer.iSecondsToPixelRatio);
                }

                MessageBox.Show(Convert.ToString(vVideoPlayer.tPlayerControls.cRangeTrackbar.getStart()));
                MessageBox.Show(Convert.ToString(vVideoPlayer.tPlayerControls.cRangeTrackbar.getEnd()));

                setMessage("Wait...");
                String sResultMedia = mainEngine.trimVideo(
                        mainEngine.trimVideo(
                            vCurrentProject.sMediaResources.ElementAt(mMediaContainer.Active()),
                            vCurrentProject.getProFolder(),
                            iStartPosition,
                            true
                            ),
                        vCurrentProject.getProFolder(),
                        iEndPosition,
                        false
                );

                if (sResultMedia != "")
                {
                    vCurrentProject.removeMedia(mMediaContainer.Active());

                    mMediaContainer.Remove();

                    addVideo(sResultMedia);

                    setMessage("Cut region successfull.");
                }
            }
        }

        #endregion

        #region button_events_project_menu

        private void tProNew_Click(object sender, EventArgs e)
        {
            if (vCurrentProject != null && vCurrentProject.wasChanged())
            {
                if (MessageBox.Show("Do you want to save current project ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Directory.Exists(vCurrentProject.getProFolder()))
                    {
                        vCurrentProject.setProFolder(chooseFolder());
                    }
                    vCurrentProject.saveProject();
                }
            }

            if (vVideoPlayer.IsPlaying())
            {
                vVideoPlayer.Pause();
            }

            mMediaContainer.Clear();

            using (menuProject pmProjectMenu = new menuProject())
            {
                pmProjectMenu.Activate();

                if (pmProjectMenu.ShowDialog(this) == DialogResult.OK)
                {
                    vCurrentProject = pmProjectMenu.getProject();

                    refreshProjectInfoPanel();
                    setMessage("Project \"" + vCurrentProject.getProName() + "\" created.");
                }
            }
        }

        private void tProLoad_Click(object sender, EventArgs e)
        {
            if (vCurrentProject != null && vCurrentProject.wasChanged())
            {
                if (MessageBox.Show("Do you want to save current project before loading ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vCurrentProject.saveProject();
                }
            }

            string sProjectFilePath = chooseFile();

            if (File.Exists(sProjectFilePath))
            {

                /* wszystkie sciezki do mediów sa zaladowane ta metodą */
                vCurrentProject = VideoProject.loadProject(sProjectFilePath);

                if (vVideoPlayer.IsPlaying())
                {
                    vVideoPlayer.Pause();
                }
                /* usuwamy wczesniejsze media */
                mMediaContainer.Clear();

                /* mega zaawansowana petla wykrywajaca czy wszystkie pliki z projektu istnieja na dysku */
                for (int iTemp = 0; iTemp < vCurrentProject.sMediaResources.Count(); iTemp++)
                {
                    if (!File.Exists(vCurrentProject.sMediaResources.ElementAt(iTemp)))
                    {
                        do
                        {
                            if (MessageBox.Show("File named " + vCurrentProject.sMediaResources.ElementAt(iTemp) + " couldn't be found, do you want to specify its location manually ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                vCurrentProject.sMediaResources[iTemp] = chooseFile();
                            }
                            else
                            {
                                vCurrentProject.sMediaResources.RemoveAt(iTemp);
                            }

                        }while(!File.Exists(vCurrentProject.sMediaResources.ElementAt(iTemp)));
                    }
                    addVideo(vCurrentProject.sMediaResources.ElementAt(iTemp));
                }

                refreshProjectInfoPanel();
                setMessage("Project \"" + vCurrentProject.getProName() + "\" loaded.");
            }
        }

        private void tProSave_Click(object sender, EventArgs e)
        {
            if (vCurrentProject != null)
            {
                if (!Directory.Exists(vCurrentProject.getProFolder()))
                {
                    vCurrentProject.setProFolder(chooseFolder());
                }
                vCurrentProject.saveProject();

                refreshProjectInfoPanel();
                setMessage("Project \"" + vCurrentProject.getProName() + "\" saved.");
            }

        }

        private void tProSaveAs_Click(object sender, EventArgs e)
        {
            if (vCurrentProject != null)
            {
                vCurrentProject.setProName(chooseFolder());
                vCurrentProject.saveProject();

                refreshProjectInfoPanel();
                setMessage("Project \"" + vCurrentProject.getProName() + "\" saved.");
            }
        }

        private void tProSettings_Click(object sender, EventArgs e)
        {
            if (vCurrentProject != null)
            {
                using (menuProject pmProjectMenu = new menuProject(vCurrentProject))
                {
                    pmProjectMenu.Activate();

                    if (pmProjectMenu.ShowDialog(this) == DialogResult.OK)
                    {
                        pmProjectMenu.transferProject(ref vCurrentProject);
                    }
                }
                refreshProjectInfoPanel();
            }
        }

        private void tProExport_Click(object sender, EventArgs e)
        {
            if (!mMediaContainer.IsEmpty())
            {
                if (!Directory.Exists(vCurrentProject.getProFolder()))
                {
                    MessageBox.Show("You need to specify output folder!");
                    vCurrentProject.setProFolder(chooseFolder());
                }

                if (vVideoPlayer.IsPlaying())
                {
                    vVideoPlayer.Pause();
                }

                vCurrentProject.saveSubs();

                setMessage("Wait...");
                String sResultMedia = mainEngine.concatVideos(vCurrentProject.sMediaResources, vCurrentProject.getProFolder(), vCurrentProject.getProName(), ".mp4", vCurrentProject.getFrameWidth(), vCurrentProject.getFrameHeight(), vCurrentProject.getFramerate());

                setMessage("Project succesfully exported.");
            }
        }

        private void tProSubtitles_Click(object sender, EventArgs e)
        {
            using (SubtitlesMainMenu sbSubsMenu = new SubtitlesMainMenu(vCurrentProject.sSubtitles))
            {
                sbSubsMenu.Activate();
                if (sbSubsMenu.ShowDialog(this) == DialogResult.OK)
                {
                    vCurrentProject.setSubtitles(sbSubsMenu.sSubtitles);
                }
            }
        }

        #endregion

        #region button_events_settings_menu

        private void setColorScheme_Click(object sender, EventArgs e)
        {
            using (SettingsTheme st_menu = new SettingsTheme())
            {
                st_menu.Activate();
                if (st_menu.ShowDialog(this) == DialogResult.OK)
                {
                    load_interface(st_menu.GetTheme());
                }
            }
            
        }

        #endregion

        #region general_functions

        public void setMessage(String sMessage)
        {
            lCommsConsole.Text = sMessage;
        }

        private void generateToolTips()
        {
            tToolTips.SetToolTip(vPlayButton, tToolList.PlayButton);

            tToolTips.SetToolTip(lTimeStamp, tToolList.TimeLabel);
        }

        private bool addVideo(string FileName)
        {
            VideoFile vcTempFile = new VideoFile(FileName);

            if (vcTempFile != null)
            {
                mMediaContainer.Add(vcTempFile);

                refreshProjectInfoPanel();

                setMessage(vcTempFile.sFileName.Substring(vcTempFile.sFileName.LastIndexOf("\\") + 1) + " added.");

                return true;
            }

            return false;
        }

        public void refreshProjectInfoPanel()
        {
            this.Text = "";

            if (vCurrentProject != null)
            {
                lProTitle.Text = vCurrentProject.getProName();
                lProFolder.Text = vCurrentProject.getProFolder();

                lProFps.Text = "Frames per socond: " + Convert.ToString(vCurrentProject.getFramerate());
                lProResolution.Text = "Resolution: " + Convert.ToString(vCurrentProject.getFrameWidth()) + " x " + Convert.ToString(vCurrentProject.getFrameHeight());

                if (vCurrentProject.wasChanged())
                {
                    Text = "*";
                }

            }
            this.Text = Text + vCurrentProject.getProName() + " - BakeWare Video Editor";
        }

        #endregion

        public string chooseFolder()
        {
            string sResultFolder = "";

            using (FolderBrowserDialog tFileDialog = new FolderBrowserDialog())
            {
                if (tFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(tFileDialog.SelectedPath))
                {
                    sResultFolder = tFileDialog.SelectedPath;
                }
            }

            return sResultFolder;
        }

        public string chooseFile()
        {
            string sResultFile = "";

            using (OpenFileDialog tFileDialog = new OpenFileDialog())
            {
                if (tFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(tFileDialog.FileName))
                {
                    sResultFile = tFileDialog.FileName;
                }
            }

            return sResultFile;
        }

        private void mainform_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void mainform_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();
        }

        private void tSettingsColorScheme_Click(object sender, EventArgs e)
        {
            using (SettingsTheme SM_menu = new SettingsTheme())
            {
                SM_menu.Activate();

                if (SM_menu.ShowDialog(this) == DialogResult.OK)
                {
                    load_interface(SM_menu.GetTheme());
                    mMediaContainer.ChangeColorScheme(SM_menu.Default, SM_menu.Active, SM_menu.Loaded);
                }
            }
        }

        private void vShrinkButton_Click(object sender, EventArgs e)
        {
            mMediaContainer.Shrink();
        }

        private void warningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to concaternate several files, please take a notice, that they should have exactly same aspect ratio (3:4 for eg.) - otherwise operation will produce corrupted files.");
        }

        private void tMainAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple base of what should be a Video Editor. Authors: Igor Dołomisiewicz, Konrad Nalewajski");
        }

        private void colorCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Default - color of media element that is neither selected, nor loaded into the media player.");
            MessageBox.Show("Active - color of media element that is active, which means that you can perform edit operation on it. If there is no active element, then it must be loaded that is active.");
            MessageBox.Show("Loaded - color of media element that is at the current moment in media player.");

        }

        private void FoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, when starting a project create new folder to set it as the project folder, otherwise bad things can happen (and I do mean BAD).");
        }

        private void typesOfFormatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently, only mp4 is supported (although some features may work with other formats).");
        }
    }
}