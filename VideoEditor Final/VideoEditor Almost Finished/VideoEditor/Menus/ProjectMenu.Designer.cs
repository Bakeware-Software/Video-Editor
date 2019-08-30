namespace VideoEditor
{
    partial class menuProject
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
            this.fMainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lTitle = new System.Windows.Forms.Label();
            this.fTopLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lName = new System.Windows.Forms.Label();
            this.tProjectName = new System.Windows.Forms.TextBox();
            this.fTopMiddleLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lFps = new System.Windows.Forms.Label();
            this.tFpsTrackBar = new System.Windows.Forms.TrackBar();
            this.fMiddleLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lResolution = new System.Windows.Forms.Label();
            this.tWidth = new System.Windows.Forms.TextBox();
            this.lTemp = new System.Windows.Forms.Label();
            this.tHigh = new System.Windows.Forms.TextBox();
            this.fBottomMiddleLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lFolder = new System.Windows.Forms.Label();
            this.tFolderChoose = new System.Windows.Forms.Button();
            this.fTemp = new System.Windows.Forms.FlowLayoutPanel();
            this.tProFolder = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.tConfirm = new System.Windows.Forms.Button();
            this.tCancel = new System.Windows.Forms.Button();
            this.fMainLayout.SuspendLayout();
            this.fTopLayout.SuspendLayout();
            this.fTopMiddleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFpsTrackBar)).BeginInit();
            this.fMiddleLayout.SuspendLayout();
            this.fBottomMiddleLayout.SuspendLayout();
            this.fTemp.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // fMainLayout
            // 
            this.fMainLayout.AutoSize = true;
            this.fMainLayout.Controls.Add(this.lTitle);
            this.fMainLayout.Controls.Add(this.fTopLayout);
            this.fMainLayout.Controls.Add(this.fTopMiddleLayout);
            this.fMainLayout.Controls.Add(this.fMiddleLayout);
            this.fMainLayout.Controls.Add(this.fBottomMiddleLayout);
            this.fMainLayout.Controls.Add(this.fTemp);
            this.fMainLayout.Controls.Add(this.flowLayoutPanel5);
            this.fMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMainLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fMainLayout.Location = new System.Drawing.Point(0, 0);
            this.fMainLayout.Name = "fMainLayout";
            this.fMainLayout.Size = new System.Drawing.Size(232, 243);
            this.fMainLayout.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Location = new System.Drawing.Point(3, 0);
            this.lTitle.MaximumSize = new System.Drawing.Size(226, 12);
            this.lTitle.MinimumSize = new System.Drawing.Size(226, 12);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(226, 12);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Project Creator";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fTopLayout
            // 
            this.fTopLayout.Controls.Add(this.lName);
            this.fTopLayout.Controls.Add(this.tProjectName);
            this.fTopLayout.Location = new System.Drawing.Point(3, 15);
            this.fTopLayout.Name = "fTopLayout";
            this.fTopLayout.Size = new System.Drawing.Size(226, 26);
            this.fTopLayout.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lName.Location = new System.Drawing.Point(3, 3);
            this.lName.Margin = new System.Windows.Forms.Padding(3);
            this.lName.MaximumSize = new System.Drawing.Size(0, 18);
            this.lName.MinimumSize = new System.Drawing.Size(0, 18);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(77, 18);
            this.lName.TabIndex = 0;
            this.lName.Text = "Project Name: ";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tProjectName
            // 
            this.tProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tProjectName.Location = new System.Drawing.Point(86, 3);
            this.tProjectName.MaximumSize = new System.Drawing.Size(131, 28);
            this.tProjectName.MinimumSize = new System.Drawing.Size(131, 28);
            this.tProjectName.Name = "tProjectName";
            this.tProjectName.Size = new System.Drawing.Size(131, 20);
            this.tProjectName.TabIndex = 1;
            this.tProjectName.TextChanged += new System.EventHandler(this.tProjectName_TextChanged);
            // 
            // fTopMiddleLayout
            // 
            this.fTopMiddleLayout.AutoSize = true;
            this.fTopMiddleLayout.Controls.Add(this.lFps);
            this.fTopMiddleLayout.Controls.Add(this.tFpsTrackBar);
            this.fTopMiddleLayout.Location = new System.Drawing.Point(3, 47);
            this.fTopMiddleLayout.Name = "fTopMiddleLayout";
            this.fTopMiddleLayout.Size = new System.Drawing.Size(223, 51);
            this.fTopMiddleLayout.TabIndex = 3;
            // 
            // lFps
            // 
            this.lFps.Dock = System.Windows.Forms.DockStyle.Top;
            this.lFps.Location = new System.Drawing.Point(3, 3);
            this.lFps.Margin = new System.Windows.Forms.Padding(3);
            this.lFps.Name = "lFps";
            this.lFps.Size = new System.Drawing.Size(102, 45);
            this.lFps.TabIndex = 0;
            this.lFps.Text = "Frames Per Second: 30";
            this.lFps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tFpsTrackBar
            // 
            this.tFpsTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tFpsTrackBar.Location = new System.Drawing.Point(111, 3);
            this.tFpsTrackBar.Maximum = 90;
            this.tFpsTrackBar.Minimum = 1;
            this.tFpsTrackBar.Name = "tFpsTrackBar";
            this.tFpsTrackBar.Size = new System.Drawing.Size(109, 45);
            this.tFpsTrackBar.TabIndex = 4;
            this.tFpsTrackBar.Value = 30;
            this.tFpsTrackBar.Scroll += new System.EventHandler(this.tFpsTrackBar_Scroll);
            // 
            // fMiddleLayout
            // 
            this.fMiddleLayout.Controls.Add(this.lResolution);
            this.fMiddleLayout.Controls.Add(this.tWidth);
            this.fMiddleLayout.Controls.Add(this.lTemp);
            this.fMiddleLayout.Controls.Add(this.tHigh);
            this.fMiddleLayout.Location = new System.Drawing.Point(3, 104);
            this.fMiddleLayout.Name = "fMiddleLayout";
            this.fMiddleLayout.Size = new System.Drawing.Size(226, 26);
            this.fMiddleLayout.TabIndex = 4;
            // 
            // lResolution
            // 
            this.lResolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.lResolution.Location = new System.Drawing.Point(3, 3);
            this.lResolution.Margin = new System.Windows.Forms.Padding(3);
            this.lResolution.Name = "lResolution";
            this.lResolution.Size = new System.Drawing.Size(60, 20);
            this.lResolution.TabIndex = 0;
            this.lResolution.Text = "Resolution:";
            // 
            // tWidth
            // 
            this.tWidth.Location = new System.Drawing.Point(69, 3);
            this.tWidth.Name = "tWidth";
            this.tWidth.Size = new System.Drawing.Size(51, 20);
            this.tWidth.TabIndex = 1;
            this.tWidth.Text = "640";
            // 
            // lTemp
            // 
            this.lTemp.AutoSize = true;
            this.lTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTemp.Location = new System.Drawing.Point(126, 3);
            this.lTemp.Margin = new System.Windows.Forms.Padding(3);
            this.lTemp.Name = "lTemp";
            this.lTemp.Size = new System.Drawing.Size(12, 20);
            this.lTemp.TabIndex = 3;
            this.lTemp.Text = "x";
            // 
            // tHigh
            // 
            this.tHigh.Location = new System.Drawing.Point(144, 3);
            this.tHigh.Name = "tHigh";
            this.tHigh.Size = new System.Drawing.Size(51, 20);
            this.tHigh.TabIndex = 2;
            this.tHigh.Text = "480";
            // 
            // fBottomMiddleLayout
            // 
            this.fBottomMiddleLayout.Controls.Add(this.lFolder);
            this.fBottomMiddleLayout.Controls.Add(this.tFolderChoose);
            this.fBottomMiddleLayout.Location = new System.Drawing.Point(3, 136);
            this.fBottomMiddleLayout.Name = "fBottomMiddleLayout";
            this.fBottomMiddleLayout.Size = new System.Drawing.Size(226, 28);
            this.fBottomMiddleLayout.TabIndex = 2;
            // 
            // lFolder
            // 
            this.lFolder.AutoSize = true;
            this.lFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFolder.Location = new System.Drawing.Point(3, 3);
            this.lFolder.Margin = new System.Windows.Forms.Padding(3);
            this.lFolder.Name = "lFolder";
            this.lFolder.Size = new System.Drawing.Size(117, 22);
            this.lFolder.TabIndex = 0;
            this.lFolder.Text = "Choose Project Folder: ";
            this.lFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tFolderChoose
            // 
            this.tFolderChoose.AutoSize = true;
            this.tFolderChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tFolderChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tFolderChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tFolderChoose.Location = new System.Drawing.Point(126, 3);
            this.tFolderChoose.Name = "tFolderChoose";
            this.tFolderChoose.Size = new System.Drawing.Size(75, 22);
            this.tFolderChoose.TabIndex = 1;
            this.tFolderChoose.Text = "Choose Folder";
            this.tFolderChoose.UseVisualStyleBackColor = true;
            this.tFolderChoose.Click += new System.EventHandler(this.tFolderChoose_Click);
            // 
            // fTemp
            // 
            this.fTemp.Controls.Add(this.tProFolder);
            this.fTemp.Location = new System.Drawing.Point(3, 170);
            this.fTemp.Name = "fTemp";
            this.fTemp.Size = new System.Drawing.Size(226, 33);
            this.fTemp.TabIndex = 6;
            // 
            // tProFolder
            // 
            this.tProFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tProFolder.Location = new System.Drawing.Point(3, 0);
            this.tProFolder.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tProFolder.Name = "tProFolder";
            this.tProFolder.Size = new System.Drawing.Size(220, 20);
            this.tProFolder.TabIndex = 1;
            this.tProFolder.TextChanged += new System.EventHandler(this.tProFolder_TextChanged);
            this.tProFolder.Leave += new System.EventHandler(this.tProFolder_Leave);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.tConfirm);
            this.flowLayoutPanel5.Controls.Add(this.tCancel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 209);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(226, 27);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // tConfirm
            // 
            this.tConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tConfirm.Location = new System.Drawing.Point(3, 3);
            this.tConfirm.Name = "tConfirm";
            this.tConfirm.Size = new System.Drawing.Size(102, 23);
            this.tConfirm.TabIndex = 0;
            this.tConfirm.Text = "Confirm";
            this.tConfirm.UseVisualStyleBackColor = true;
            this.tConfirm.Click += new System.EventHandler(this.tConfirm_Click);
            // 
            // tCancel
            // 
            this.tCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tCancel.Location = new System.Drawing.Point(111, 3);
            this.tCancel.Name = "tCancel";
            this.tCancel.Size = new System.Drawing.Size(109, 23);
            this.tCancel.TabIndex = 1;
            this.tCancel.Text = "Cancel";
            this.tCancel.UseVisualStyleBackColor = true;
            this.tCancel.Click += new System.EventHandler(this.tCancel_Click);
            // 
            // menuProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 243);
            this.Controls.Add(this.fMainLayout);
            this.Name = "menuProject";
            this.Text = "Menu";
            this.fMainLayout.ResumeLayout(false);
            this.fMainLayout.PerformLayout();
            this.fTopLayout.ResumeLayout(false);
            this.fTopLayout.PerformLayout();
            this.fTopMiddleLayout.ResumeLayout(false);
            this.fTopMiddleLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFpsTrackBar)).EndInit();
            this.fMiddleLayout.ResumeLayout(false);
            this.fMiddleLayout.PerformLayout();
            this.fBottomMiddleLayout.ResumeLayout(false);
            this.fBottomMiddleLayout.PerformLayout();
            this.fTemp.ResumeLayout(false);
            this.fTemp.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fMainLayout;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.FlowLayoutPanel fTopLayout;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tProjectName;
        private System.Windows.Forms.FlowLayoutPanel fTopMiddleLayout;
        private System.Windows.Forms.Label lFps;
        private System.Windows.Forms.FlowLayoutPanel fBottomMiddleLayout;
        private System.Windows.Forms.Label lFolder;
        private System.Windows.Forms.Button tFolderChoose;
        private System.Windows.Forms.TrackBar tFpsTrackBar;
        private System.Windows.Forms.FlowLayoutPanel fMiddleLayout;
        private System.Windows.Forms.Label lResolution;
        private System.Windows.Forms.TextBox tWidth;
        private System.Windows.Forms.Label lTemp;
        private System.Windows.Forms.TextBox tHigh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button tConfirm;
        private System.Windows.Forms.Button tCancel;
        private System.Windows.Forms.FlowLayoutPanel fTemp;
        private System.Windows.Forms.TextBox tProFolder;
    }
}