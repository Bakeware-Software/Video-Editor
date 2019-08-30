using System.Windows.Forms;

namespace VideoEditor
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.sMediaMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fMain = new System.Windows.Forms.TableLayoutPanel();
            this.fProjectInfoPanel = new System.Windows.Forms.Panel();
            this.lProResolution = new System.Windows.Forms.Label();
            this.lProTitle = new System.Windows.Forms.Label();
            this.lProFolder = new System.Windows.Forms.Label();
            this.lProFps = new System.Windows.Forms.Label();
            this.lProLabel = new System.Windows.Forms.Label();
            this.fControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vVideoSlider = new System.Windows.Forms.TrackBar();
            this.fPlayerButtons = new System.Windows.Forms.Panel();
            this.vNextButton = new System.Windows.Forms.Button();
            this.vPrevButton = new System.Windows.Forms.Button();
            this.vStopButton = new System.Windows.Forms.Button();
            this.vPauseButton = new System.Windows.Forms.Button();
            this.lFrameStamp = new System.Windows.Forms.Label();
            this.lTimeStamp = new System.Windows.Forms.Label();
            this.vPlayButton = new System.Windows.Forms.Button();
            this.vMainScreen = new System.Windows.Forms.PictureBox();
            this.sMainMenu = new System.Windows.Forms.MenuStrip();
            this.tMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainFileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tCutInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tCutRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.tEditAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tAudioRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tAudioExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.tEditEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.tEffectsAddSub = new System.Windows.Forms.ToolStripMenuItem();
            this.tEditSpeedChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tProNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tProLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tProSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tProSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tProSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tProExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tProSubtitles = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tSettingsColorScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.warningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fMediaList = new System.Windows.Forms.FlowLayoutPanel();
            this.fMediaBoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fTrackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.trackTimeLine = new System.Windows.Forms.TrackBar();
            this.fMainTrackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fTrackInterfacePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vShrinkButton = new System.Windows.Forms.Button();
            this.vGrowButton = new System.Windows.Forms.Button();
            this.sTotalPlayTime = new System.Windows.Forms.Label();
            this.lCommsConsole = new System.Windows.Forms.Label();
            this.tAddVideoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.typesOfFormatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMediaMenu.SuspendLayout();
            this.fMain.SuspendLayout();
            this.fProjectInfoPanel.SuspendLayout();
            this.fControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vVideoSlider)).BeginInit();
            this.fPlayerButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vMainScreen)).BeginInit();
            this.sMainMenu.SuspendLayout();
            this.fTrackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimeLine)).BeginInit();
            this.fTrackInterfacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sMediaMenu
            // 
            this.sMediaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVideoToolStripMenuItem});
            this.sMediaMenu.Name = "contextMenuStrip1";
            this.sMediaMenu.Size = new System.Drawing.Size(130, 26);
            // 
            // addVideoToolStripMenuItem
            // 
            this.addVideoToolStripMenuItem.Name = "addVideoToolStripMenuItem";
            this.addVideoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addVideoToolStripMenuItem.Text = "Add Video";
            this.addVideoToolStripMenuItem.Click += new System.EventHandler(this.addVideoToolStripMenuItem_Click);
            // 
            // fMain
            // 
            this.fMain.AutoSize = true;
            this.fMain.ColumnCount = 5;
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 735F));
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fMain.Controls.Add(this.fProjectInfoPanel, 3, 6);
            this.fMain.Controls.Add(this.fControlPanel, 0, 2);
            this.fMain.Controls.Add(this.vMainScreen, 0, 1);
            this.fMain.Controls.Add(this.sMainMenu, 0, 0);
            this.fMain.Controls.Add(this.fMediaList, 2, 1);
            this.fMain.Controls.Add(this.fMediaBoxPanel, 3, 1);
            this.fMain.Controls.Add(this.fTrackPanel, 0, 6);
            this.fMain.Controls.Add(this.fTrackInterfacePanel, 0, 5);
            this.fMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMain.Location = new System.Drawing.Point(0, 0);
            this.fMain.Name = "fMain";
            this.fMain.RowCount = 8;
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fMain.Size = new System.Drawing.Size(1167, 681);
            this.fMain.TabIndex = 6;
            // 
            // fProjectInfoPanel
            // 
            this.fProjectInfoPanel.Controls.Add(this.lProResolution);
            this.fProjectInfoPanel.Controls.Add(this.lProTitle);
            this.fProjectInfoPanel.Controls.Add(this.lProFolder);
            this.fProjectInfoPanel.Controls.Add(this.lProFps);
            this.fProjectInfoPanel.Controls.Add(this.lProLabel);
            this.fProjectInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fProjectInfoPanel.Location = new System.Drawing.Point(952, 454);
            this.fProjectInfoPanel.Name = "fProjectInfoPanel";
            this.fMain.SetRowSpan(this.fProjectInfoPanel, 2);
            this.fProjectInfoPanel.Size = new System.Drawing.Size(203, 224);
            this.fProjectInfoPanel.TabIndex = 0;
            // 
            // lProResolution
            // 
            this.lProResolution.BackColor = System.Drawing.Color.Silver;
            this.lProResolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProResolution.Location = new System.Drawing.Point(0, 179);
            this.lProResolution.Name = "lProResolution";
            this.lProResolution.Size = new System.Drawing.Size(203, 46);
            this.lProResolution.TabIndex = 4;
            this.lProResolution.Text = "Resolution:";
            this.lProResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lProTitle
            // 
            this.lProTitle.BackColor = System.Drawing.Color.Silver;
            this.lProTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProTitle.Location = new System.Drawing.Point(0, 133);
            this.lProTitle.Name = "lProTitle";
            this.lProTitle.Size = new System.Drawing.Size(203, 46);
            this.lProTitle.TabIndex = 5;
            this.lProTitle.Text = "Untitled";
            this.lProTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lProFolder
            // 
            this.lProFolder.BackColor = System.Drawing.Color.Silver;
            this.lProFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProFolder.Location = new System.Drawing.Point(0, 93);
            this.lProFolder.Name = "lProFolder";
            this.lProFolder.Size = new System.Drawing.Size(203, 40);
            this.lProFolder.TabIndex = 1;
            this.lProFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lProFps
            // 
            this.lProFps.BackColor = System.Drawing.Color.Silver;
            this.lProFps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProFps.Location = new System.Drawing.Point(0, 48);
            this.lProFps.Name = "lProFps";
            this.lProFps.Size = new System.Drawing.Size(203, 45);
            this.lProFps.TabIndex = 3;
            this.lProFps.Text = "Frames Per Second:";
            this.lProFps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lProLabel
            // 
            this.lProLabel.BackColor = System.Drawing.Color.Silver;
            this.lProLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lProLabel.Location = new System.Drawing.Point(0, 0);
            this.lProLabel.Name = "lProLabel";
            this.lProLabel.Size = new System.Drawing.Size(203, 48);
            this.lProLabel.TabIndex = 2;
            this.lProLabel.Text = "Current Project: ";
            this.lProLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fControlPanel
            // 
            this.fControlPanel.AutoSize = true;
            this.fControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fControlPanel.BackColor = System.Drawing.Color.DarkGray;
            this.fMain.SetColumnSpan(this.fControlPanel, 2);
            this.fControlPanel.Controls.Add(this.vVideoSlider);
            this.fControlPanel.Controls.Add(this.fPlayerButtons);
            this.fControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fControlPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fControlPanel.Location = new System.Drawing.Point(3, 309);
            this.fControlPanel.Name = "fControlPanel";
            this.fControlPanel.Size = new System.Drawing.Size(737, 101);
            this.fControlPanel.TabIndex = 3;
            // 
            // vVideoSlider
            // 
            this.vVideoSlider.BackColor = System.Drawing.Color.Maroon;
            this.vVideoSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vVideoSlider.Location = new System.Drawing.Point(3, 3);
            this.vVideoSlider.Maximum = 0;
            this.vVideoSlider.Name = "vVideoSlider";
            this.vVideoSlider.Size = new System.Drawing.Size(728, 45);
            this.vVideoSlider.TabIndex = 1;
            // 
            // fPlayerButtons
            // 
            this.fPlayerButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fPlayerButtons.BackColor = System.Drawing.Color.Maroon;
            this.fPlayerButtons.Controls.Add(this.vNextButton);
            this.fPlayerButtons.Controls.Add(this.vPrevButton);
            this.fPlayerButtons.Controls.Add(this.vStopButton);
            this.fPlayerButtons.Controls.Add(this.vPauseButton);
            this.fPlayerButtons.Controls.Add(this.lFrameStamp);
            this.fPlayerButtons.Controls.Add(this.lTimeStamp);
            this.fPlayerButtons.Controls.Add(this.vPlayButton);
            this.fPlayerButtons.Location = new System.Drawing.Point(3, 54);
            this.fPlayerButtons.Name = "fPlayerButtons";
            this.fPlayerButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fPlayerButtons.Size = new System.Drawing.Size(728, 32);
            this.fPlayerButtons.TabIndex = 0;
            // 
            // vNextButton
            // 
            this.vNextButton.BackColor = System.Drawing.Color.Transparent;
            this.vNextButton.BackgroundImage = global::VideoEditor.Properties.Resources.VE_NEXT2;
            this.vNextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vNextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vNextButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vNextButton.FlatAppearance.BorderSize = 0;
            this.vNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vNextButton.Location = new System.Drawing.Point(128, 0);
            this.vNextButton.Name = "vNextButton";
            this.vNextButton.Size = new System.Drawing.Size(32, 32);
            this.vNextButton.TabIndex = 7;
            this.vNextButton.UseVisualStyleBackColor = false;
            this.vNextButton.Click += new System.EventHandler(this.vNextButton_Click);
            // 
            // vPrevButton
            // 
            this.vPrevButton.BackColor = System.Drawing.Color.Transparent;
            this.vPrevButton.BackgroundImage = global::VideoEditor.Properties.Resources.VE_PREV2;
            this.vPrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vPrevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vPrevButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vPrevButton.FlatAppearance.BorderSize = 0;
            this.vPrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vPrevButton.Location = new System.Drawing.Point(96, 0);
            this.vPrevButton.Name = "vPrevButton";
            this.vPrevButton.Size = new System.Drawing.Size(32, 32);
            this.vPrevButton.TabIndex = 6;
            this.vPrevButton.UseVisualStyleBackColor = false;
            this.vPrevButton.Click += new System.EventHandler(this.vPrevButton_Click);
            // 
            // vStopButton
            // 
            this.vStopButton.BackColor = System.Drawing.Color.Transparent;
            this.vStopButton.BackgroundImage = global::VideoEditor.Properties.Resources.VE_STOP3;
            this.vStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vStopButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vStopButton.FlatAppearance.BorderSize = 0;
            this.vStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vStopButton.Location = new System.Drawing.Point(64, 0);
            this.vStopButton.Name = "vStopButton";
            this.vStopButton.Size = new System.Drawing.Size(32, 32);
            this.vStopButton.TabIndex = 5;
            this.vStopButton.UseVisualStyleBackColor = false;
            this.vStopButton.Click += new System.EventHandler(this.vStopButton_Click);
            // 
            // vPauseButton
            // 
            this.vPauseButton.BackColor = System.Drawing.Color.Transparent;
            this.vPauseButton.BackgroundImage = global::VideoEditor.Properties.Resources.VE_PAUSE2;
            this.vPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vPauseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vPauseButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.vPauseButton.FlatAppearance.BorderSize = 0;
            this.vPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vPauseButton.Location = new System.Drawing.Point(32, 0);
            this.vPauseButton.Name = "vPauseButton";
            this.vPauseButton.Size = new System.Drawing.Size(32, 32);
            this.vPauseButton.TabIndex = 4;
            this.vPauseButton.UseVisualStyleBackColor = false;
            this.vPauseButton.Click += new System.EventHandler(this.vPauseButton_Click);
            // 
            // lFrameStamp
            // 
            this.lFrameStamp.BackColor = System.Drawing.Color.Silver;
            this.lFrameStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFrameStamp.Location = new System.Drawing.Point(390, 5);
            this.lFrameStamp.Margin = new System.Windows.Forms.Padding(3);
            this.lFrameStamp.Name = "lFrameStamp";
            this.lFrameStamp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lFrameStamp.Size = new System.Drawing.Size(188, 20);
            this.lFrameStamp.TabIndex = 3;
            this.lFrameStamp.Text = "Frame: ";
            // 
            // lTimeStamp
            // 
            this.lTimeStamp.BackColor = System.Drawing.Color.Silver;
            this.lTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTimeStamp.Location = new System.Drawing.Point(584, 5);
            this.lTimeStamp.Margin = new System.Windows.Forms.Padding(3);
            this.lTimeStamp.Name = "lTimeStamp";
            this.lTimeStamp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTimeStamp.Size = new System.Drawing.Size(141, 20);
            this.lTimeStamp.TabIndex = 2;
            this.lTimeStamp.Text = "00:00:00/00:00:00";
            this.lTimeStamp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vPlayButton
            // 
            this.vPlayButton.AutoSize = true;
            this.vPlayButton.BackColor = System.Drawing.Color.Transparent;
            this.vPlayButton.BackgroundImage = global::VideoEditor.Properties.Resources.VE_PLAY2;
            this.vPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vPlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vPlayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vPlayButton.FlatAppearance.BorderSize = 0;
            this.vPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vPlayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vPlayButton.Location = new System.Drawing.Point(0, 0);
            this.vPlayButton.Name = "vPlayButton";
            this.vPlayButton.Size = new System.Drawing.Size(32, 32);
            this.vPlayButton.TabIndex = 0;
            this.vPlayButton.UseVisualStyleBackColor = false;
            this.vPlayButton.Click += new System.EventHandler(this.vPlayButtonClick);
            // 
            // vMainScreen
            // 
            this.vMainScreen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vMainScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fMain.SetColumnSpan(this.vMainScreen, 2);
            this.vMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vMainScreen.Location = new System.Drawing.Point(3, 28);
            this.vMainScreen.Name = "vMainScreen";
            this.fMain.SetRowSpan(this.vMainScreen, 3);
            this.vMainScreen.Size = new System.Drawing.Size(737, 275);
            this.vMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.vMainScreen.TabIndex = 2;
            this.vMainScreen.TabStop = false;
            // 
            // sMainMenu
            // 
            this.sMainMenu.AutoSize = false;
            this.sMainMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fMain.SetColumnSpan(this.sMainMenu, 5);
            this.sMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMainFile,
            this.tMainEdit,
            this.tMainProject,
            this.tMainSettings,
            this.tMainHelp,
            this.tMainAbout});
            this.sMainMenu.Location = new System.Drawing.Point(0, 0);
            this.sMainMenu.Name = "sMainMenu";
            this.sMainMenu.Size = new System.Drawing.Size(1167, 25);
            this.sMainMenu.TabIndex = 4;
            // 
            // tMainFile
            // 
            this.tMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMainFileAdd});
            this.tMainFile.Name = "tMainFile";
            this.tMainFile.Size = new System.Drawing.Size(37, 21);
            this.tMainFile.Text = "File";
            // 
            // tMainFileAdd
            // 
            this.tMainFileAdd.Name = "tMainFileAdd";
            this.tMainFileAdd.Size = new System.Drawing.Size(129, 22);
            this.tMainFileAdd.Text = "Add Video";
            this.tMainFileAdd.Click += new System.EventHandler(this.tProExport_Click);
            // 
            // tMainEdit
            // 
            this.tMainEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEditCut,
            this.tEditAudio,
            this.tEditEffects,
            this.tEditSpeedChange});
            this.tMainEdit.Name = "tMainEdit";
            this.tMainEdit.Size = new System.Drawing.Size(39, 21);
            this.tMainEdit.Text = "Edit";
            // 
            // tEditCut
            // 
            this.tEditCut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCutInsert,
            this.tCutRegion});
            this.tEditCut.Name = "tEditCut";
            this.tEditCut.Size = new System.Drawing.Size(150, 22);
            this.tEditCut.Text = "Cut";
            // 
            // tCutInsert
            // 
            this.tCutInsert.Name = "tCutInsert";
            this.tCutInsert.Size = new System.Drawing.Size(133, 22);
            this.tCutInsert.Text = "Insert Cut";
            this.tCutInsert.Click += new System.EventHandler(this.tCutInsert_Click);
            // 
            // tCutRegion
            // 
            this.tCutRegion.Name = "tCutRegion";
            this.tCutRegion.Size = new System.Drawing.Size(133, 22);
            this.tCutRegion.Text = "Region Cut";
            this.tCutRegion.Click += new System.EventHandler(this.tCutRegion_Click);
            // 
            // tEditAudio
            // 
            this.tEditAudio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAudioRemove,
            this.tAudioExtract});
            this.tEditAudio.Name = "tEditAudio";
            this.tEditAudio.Size = new System.Drawing.Size(150, 22);
            this.tEditAudio.Text = "Audio";
            // 
            // tAudioRemove
            // 
            this.tAudioRemove.Name = "tAudioRemove";
            this.tAudioRemove.Size = new System.Drawing.Size(117, 22);
            this.tAudioRemove.Text = "Remove";
            this.tAudioRemove.Click += new System.EventHandler(this.tAudioRemove_Click);
            // 
            // tAudioExtract
            // 
            this.tAudioExtract.Name = "tAudioExtract";
            this.tAudioExtract.Size = new System.Drawing.Size(117, 22);
            this.tAudioExtract.Text = "Extract";
            this.tAudioExtract.Click += new System.EventHandler(this.tAudioExtract_Click);
            // 
            // tEditEffects
            // 
            this.tEditEffects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEffectsAddSub});
            this.tEditEffects.Name = "tEditEffects";
            this.tEditEffects.Size = new System.Drawing.Size(150, 22);
            this.tEditEffects.Text = "Effects";
            // 
            // tEffectsAddSub
            // 
            this.tEffectsAddSub.Name = "tEffectsAddSub";
            this.tEffectsAddSub.Size = new System.Drawing.Size(144, 22);
            this.tEffectsAddSub.Text = "Add Subtitles";
            // 
            // tEditSpeedChange
            // 
            this.tEditSpeedChange.Name = "tEditSpeedChange";
            this.tEditSpeedChange.Size = new System.Drawing.Size(150, 22);
            this.tEditSpeedChange.Text = "Change Speed";
            this.tEditSpeedChange.Click += new System.EventHandler(this.tEditSpeedChange_Click);
            // 
            // tMainProject
            // 
            this.tMainProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tProNew,
            this.tProLoad,
            this.tProSave,
            this.tProSaveAs,
            this.tProSettings,
            this.toolStripSeparator4,
            this.tProExport,
            this.toolStripSeparator1,
            this.tProSubtitles});
            this.tMainProject.Name = "tMainProject";
            this.tMainProject.Size = new System.Drawing.Size(56, 21);
            this.tMainProject.Text = "Project";
            // 
            // tProNew
            // 
            this.tProNew.Name = "tProNew";
            this.tProNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tProNew.Size = new System.Drawing.Size(177, 22);
            this.tProNew.Text = "New";
            this.tProNew.Click += new System.EventHandler(this.tProNew_Click);
            // 
            // tProLoad
            // 
            this.tProLoad.Name = "tProLoad";
            this.tProLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tProLoad.Size = new System.Drawing.Size(177, 22);
            this.tProLoad.Text = "Open";
            this.tProLoad.Click += new System.EventHandler(this.tProLoad_Click);
            // 
            // tProSave
            // 
            this.tProSave.Name = "tProSave";
            this.tProSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tProSave.Size = new System.Drawing.Size(177, 22);
            this.tProSave.Text = "Save";
            this.tProSave.Click += new System.EventHandler(this.tProSave_Click);
            // 
            // tProSaveAs
            // 
            this.tProSaveAs.Name = "tProSaveAs";
            this.tProSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tProSaveAs.Size = new System.Drawing.Size(177, 22);
            this.tProSaveAs.Text = "Save As";
            this.tProSaveAs.Click += new System.EventHandler(this.tProSaveAs_Click);
            // 
            // tProSettings
            // 
            this.tProSettings.Name = "tProSettings";
            this.tProSettings.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tProSettings.Size = new System.Drawing.Size(177, 22);
            this.tProSettings.Text = "Settings";
            this.tProSettings.Click += new System.EventHandler(this.tProSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(174, 6);
            // 
            // tProExport
            // 
            this.tProExport.Name = "tProExport";
            this.tProExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tProExport.Size = new System.Drawing.Size(177, 22);
            this.tProExport.Text = "Export";
            this.tProExport.Click += new System.EventHandler(this.tProExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // tProSubtitles
            // 
            this.tProSubtitles.Name = "tProSubtitles";
            this.tProSubtitles.Size = new System.Drawing.Size(177, 22);
            this.tProSubtitles.Text = "Subtitles";
            this.tProSubtitles.Click += new System.EventHandler(this.tProSubtitles_Click);
            // 
            // tMainSettings
            // 
            this.tMainSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSettingsColorScheme});
            this.tMainSettings.Name = "tMainSettings";
            this.tMainSettings.Size = new System.Drawing.Size(61, 21);
            this.tMainSettings.Text = "Settings";
            // 
            // tSettingsColorScheme
            // 
            this.tSettingsColorScheme.Name = "tSettingsColorScheme";
            this.tSettingsColorScheme.Size = new System.Drawing.Size(172, 22);
            this.tSettingsColorScheme.Text = "Select color theme";
            this.tSettingsColorScheme.Click += new System.EventHandler(this.tSettingsColorScheme_Click);
            // 
            // tMainHelp
            // 
            this.tMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warningToolStripMenuItem,
            this.colorCodesToolStripMenuItem,
            this.FoldersToolStripMenuItem,
            this.typesOfFormatsToolStripMenuItem});
            this.tMainHelp.Name = "tMainHelp";
            this.tMainHelp.Size = new System.Drawing.Size(44, 21);
            this.tMainHelp.Text = "Help";
            // 
            // warningToolStripMenuItem
            // 
            this.warningToolStripMenuItem.Name = "warningToolStripMenuItem";
            this.warningToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.warningToolStripMenuItem.Text = "Exporting Project";
            this.warningToolStripMenuItem.Click += new System.EventHandler(this.warningToolStripMenuItem_Click);
            // 
            // colorCodesToolStripMenuItem
            // 
            this.colorCodesToolStripMenuItem.Name = "colorCodesToolStripMenuItem";
            this.colorCodesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.colorCodesToolStripMenuItem.Text = "Color Codes";
            this.colorCodesToolStripMenuItem.Click += new System.EventHandler(this.colorCodesToolStripMenuItem_Click);
            // 
            // FoldersToolStripMenuItem
            // 
            this.FoldersToolStripMenuItem.Name = "FoldersToolStripMenuItem";
            this.FoldersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.FoldersToolStripMenuItem.Text = "Project Folder";
            this.FoldersToolStripMenuItem.Click += new System.EventHandler(this.FoldersToolStripMenuItem_Click);
            // 
            // tMainAbout
            // 
            this.tMainAbout.Name = "tMainAbout";
            this.tMainAbout.Size = new System.Drawing.Size(52, 21);
            this.tMainAbout.Text = "About";
            this.tMainAbout.Click += new System.EventHandler(this.tMainAbout_Click);
            // 
            // fMediaList
            // 
            this.fMediaList.AutoScroll = true;
            this.fMediaList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fMediaList.BackColor = System.Drawing.Color.DarkGray;
            this.fMediaList.ContextMenuStrip = this.sMediaMenu;
            this.fMediaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMediaList.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fMediaList.Location = new System.Drawing.Point(746, 28);
            this.fMediaList.Name = "fMediaList";
            this.fMain.SetRowSpan(this.fMediaList, 4);
            this.fMediaList.Size = new System.Drawing.Size(200, 382);
            this.fMediaList.TabIndex = 6;
            // 
            // fMediaBoxPanel
            // 
            this.fMediaBoxPanel.AutoScroll = true;
            this.fMediaBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fMediaBoxPanel.BackColor = System.Drawing.Color.DarkGray;
            this.fMediaBoxPanel.ContextMenuStrip = this.sMediaMenu;
            this.fMediaBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMediaBoxPanel.Location = new System.Drawing.Point(952, 28);
            this.fMediaBoxPanel.Name = "fMediaBoxPanel";
            this.fMain.SetRowSpan(this.fMediaBoxPanel, 4);
            this.fMediaBoxPanel.Size = new System.Drawing.Size(203, 382);
            this.fMediaBoxPanel.TabIndex = 11;
            // 
            // fTrackPanel
            // 
            this.fTrackPanel.AutoScroll = true;
            this.fTrackPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fTrackPanel.BackColor = System.Drawing.Color.Maroon;
            this.fMain.SetColumnSpan(this.fTrackPanel, 3);
            this.fTrackPanel.ContextMenuStrip = this.sMediaMenu;
            this.fTrackPanel.Controls.Add(this.trackTimeLine);
            this.fTrackPanel.Controls.Add(this.fMainTrackPanel);
            this.fTrackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTrackPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fTrackPanel.Location = new System.Drawing.Point(3, 454);
            this.fTrackPanel.Name = "fTrackPanel";
            this.fMain.SetRowSpan(this.fTrackPanel, 2);
            this.fTrackPanel.Size = new System.Drawing.Size(943, 224);
            this.fTrackPanel.TabIndex = 12;
            this.fTrackPanel.WrapContents = false;
            // 
            // trackTimeLine
            // 
            this.trackTimeLine.AutoSize = false;
            this.trackTimeLine.Location = new System.Drawing.Point(3, 3);
            this.trackTimeLine.Maximum = 0;
            this.trackTimeLine.Name = "trackTimeLine";
            this.trackTimeLine.Size = new System.Drawing.Size(933, 45);
            this.trackTimeLine.SmallChange = 0;
            this.trackTimeLine.TabIndex = 2;
            // 
            // fMainTrackPanel
            // 
            this.fMainTrackPanel.AutoSize = true;
            this.fMainTrackPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fMainTrackPanel.BackColor = System.Drawing.Color.Gray;
            this.fMainTrackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMainTrackPanel.Location = new System.Drawing.Point(12, 54);
            this.fMainTrackPanel.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.fMainTrackPanel.MinimumSize = new System.Drawing.Size(0, 10);
            this.fMainTrackPanel.Name = "fMainTrackPanel";
            this.fMainTrackPanel.Size = new System.Drawing.Size(924, 10);
            this.fMainTrackPanel.TabIndex = 4;
            this.fMainTrackPanel.WrapContents = false;
            // 
            // fTrackInterfacePanel
            // 
            this.fTrackInterfacePanel.AutoSize = true;
            this.fTrackInterfacePanel.BackColor = System.Drawing.Color.Maroon;
            this.fMain.SetColumnSpan(this.fTrackInterfacePanel, 4);
            this.fTrackInterfacePanel.Controls.Add(this.vShrinkButton);
            this.fTrackInterfacePanel.Controls.Add(this.vGrowButton);
            this.fTrackInterfacePanel.Controls.Add(this.sTotalPlayTime);
            this.fTrackInterfacePanel.Controls.Add(this.lCommsConsole);
            this.fTrackInterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTrackInterfacePanel.Location = new System.Drawing.Point(3, 416);
            this.fTrackInterfacePanel.Name = "fTrackInterfacePanel";
            this.fTrackInterfacePanel.Size = new System.Drawing.Size(1152, 32);
            this.fTrackInterfacePanel.TabIndex = 5;
            // 
            // vShrinkButton
            // 
            this.vShrinkButton.AutoSize = true;
            this.vShrinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vShrinkButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vShrinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vShrinkButton.Location = new System.Drawing.Point(3, 3);
            this.vShrinkButton.Name = "vShrinkButton";
            this.vShrinkButton.Size = new System.Drawing.Size(40, 25);
            this.vShrinkButton.TabIndex = 1;
            this.vShrinkButton.Text = "Shrink";
            this.vShrinkButton.UseVisualStyleBackColor = true;
            this.vShrinkButton.Click += new System.EventHandler(this.vShrinkButton_Click);
            // 
            // vGrowButton
            // 
            this.vGrowButton.AutoSize = true;
            this.vGrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vGrowButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.vGrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vGrowButton.Location = new System.Drawing.Point(49, 3);
            this.vGrowButton.Name = "vGrowButton";
            this.vGrowButton.Size = new System.Drawing.Size(40, 25);
            this.vGrowButton.TabIndex = 2;
            this.vGrowButton.Text = "Grow";
            this.vGrowButton.UseVisualStyleBackColor = true;
            this.vGrowButton.Click += new System.EventHandler(this.vGrowButton_Click);
            // 
            // sTotalPlayTime
            // 
            this.sTotalPlayTime.BackColor = System.Drawing.Color.Silver;
            this.sTotalPlayTime.Location = new System.Drawing.Point(95, 6);
            this.sTotalPlayTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.sTotalPlayTime.Name = "sTotalPlayTime";
            this.sTotalPlayTime.Size = new System.Drawing.Size(180, 12);
            this.sTotalPlayTime.TabIndex = 4;
            this.sTotalPlayTime.Text = "Total Time: 00:00:00/00:00:00";
            // 
            // lCommsConsole
            // 
            this.lCommsConsole.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lCommsConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCommsConsole.Location = new System.Drawing.Point(281, 3);
            this.lCommsConsole.Margin = new System.Windows.Forms.Padding(3);
            this.lCommsConsole.Name = "lCommsConsole";
            this.lCommsConsole.Size = new System.Drawing.Size(840, 25);
            this.lCommsConsole.TabIndex = 3;
            this.lCommsConsole.Text = "Ready";
            this.lCommsConsole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tAddVideoFile
            // 
            this.tAddVideoFile.Name = "tAddVideoFile";
            this.tAddVideoFile.Size = new System.Drawing.Size(161, 22);
            this.tAddVideoFile.Text = "Instert Video File";
            // 
            // typesOfFormatsToolStripMenuItem
            // 
            this.typesOfFormatsToolStripMenuItem.Name = "typesOfFormatsToolStripMenuItem";
            this.typesOfFormatsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.typesOfFormatsToolStripMenuItem.Text = "Types of Formats";
            this.typesOfFormatsToolStripMenuItem.Click += new System.EventHandler(this.typesOfFormatsToolStripMenuItem_Click);
            // 
            // mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1167, 681);
            this.Controls.Add(this.fMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.Text = "BakeWare Video Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.mainform_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.mainform_ResizeEnd);
            this.sMediaMenu.ResumeLayout(false);
            this.fMain.ResumeLayout(false);
            this.fMain.PerformLayout();
            this.fProjectInfoPanel.ResumeLayout(false);
            this.fControlPanel.ResumeLayout(false);
            this.fControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vVideoSlider)).EndInit();
            this.fPlayerButtons.ResumeLayout(false);
            this.fPlayerButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vMainScreen)).EndInit();
            this.sMainMenu.ResumeLayout(false);
            this.sMainMenu.PerformLayout();
            this.fTrackPanel.ResumeLayout(false);
            this.fTrackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimeLine)).EndInit();
            this.fTrackInterfacePanel.ResumeLayout(false);
            this.fTrackInterfacePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer mainTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip sMediaMenu;
        private System.Windows.Forms.TableLayoutPanel fMain;
        private System.Windows.Forms.FlowLayoutPanel fControlPanel;
        private System.Windows.Forms.TrackBar vVideoSlider;
        private System.Windows.Forms.Panel fPlayerButtons;
        private System.Windows.Forms.Button vPlayButton;
        private System.Windows.Forms.MenuStrip sMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tMainEdit;
        private System.Windows.Forms.ToolStripMenuItem tEditCut;
        private System.Windows.Forms.ToolStripMenuItem tCutInsert;
        private System.Windows.Forms.ToolStripMenuItem tCutRegion;
        private System.Windows.Forms.ToolStripMenuItem tEditAudio;
        private System.Windows.Forms.ToolStripMenuItem tAudioRemove;
        private System.Windows.Forms.ToolStripMenuItem tAudioExtract;
        private System.Windows.Forms.ToolStripMenuItem tEditEffects;
        private System.Windows.Forms.ToolStripMenuItem tEffectsAddSub;
        private System.Windows.Forms.ToolStripMenuItem tEditSpeedChange;
        private System.Windows.Forms.ToolStripMenuItem tMainProject;
        private System.Windows.Forms.ToolStripMenuItem tProNew;
        private System.Windows.Forms.ToolStripMenuItem tProLoad;
        private System.Windows.Forms.ToolStripMenuItem tProSave;
        private System.Windows.Forms.ToolStripMenuItem tProSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tProSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tProExport;
        private System.Windows.Forms.ToolStripMenuItem tMainSettings;
        private System.Windows.Forms.ToolStripMenuItem tSettingsColorScheme;
        private System.Windows.Forms.ToolStripMenuItem tMainHelp;
        private System.Windows.Forms.ToolStripMenuItem tMainAbout;
        private System.Windows.Forms.FlowLayoutPanel fTrackInterfacePanel;
        private System.Windows.Forms.Button vShrinkButton;
        private System.Windows.Forms.Button vGrowButton;
        private System.Windows.Forms.Label lCommsConsole;
        private System.Windows.Forms.FlowLayoutPanel fMediaList;
        private System.Windows.Forms.Label lTimeStamp;
        private System.Windows.Forms.Label lProLabel;
        private System.Windows.Forms.Label lProFolder;
        private System.Windows.Forms.Label lProFps;
        private System.Windows.Forms.Label lProResolution;
        private System.Windows.Forms.Label lProTitle;
        private System.Windows.Forms.FlowLayoutPanel fMediaBoxPanel;
        private System.Windows.Forms.FlowLayoutPanel fTrackPanel;
        private System.Windows.Forms.TrackBar trackTimeLine;
        private System.Windows.Forms.FlowLayoutPanel fMainTrackPanel;
        private Label lFrameStamp;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tProSubtitles;
        private Label sTotalPlayTime;
        private Button vNextButton;
        private Button vPrevButton;
        private Button vStopButton;
        private Button vPauseButton;
        private ToolStripMenuItem tMainFile;
        private ToolStripMenuItem tMainFileAdd;
        private Panel fProjectInfoPanel;
        private PictureBox vMainScreen;
        private ToolStripMenuItem tAddVideoFile;
        private ToolStripMenuItem addVideoToolStripMenuItem;
        private ToolStripMenuItem warningToolStripMenuItem;
        private ToolStripMenuItem colorCodesToolStripMenuItem;
        private ToolStripMenuItem FoldersToolStripMenuItem;
        private ToolStripMenuItem typesOfFormatsToolStripMenuItem;
    }
}

