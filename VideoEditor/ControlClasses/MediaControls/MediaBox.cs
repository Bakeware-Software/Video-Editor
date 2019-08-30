using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    class MediaInfoBox : FlowLayoutPanel
    {
        private DynamicMediaControl ParentContainer;

        private FlowLayoutPanel      fMainPanel;
        private FlowLayoutPanel      fSecondaryPanel;

        private Label        lFps;
        private Label        lResolution;
        private Label        lName;

        private PictureBox pbxThumbnails;

        private ContextMenuStrip PrimaryMediaMenu;

        public MediaInfoBox(DynamicMediaControl parent, VideoFile videoResource)
        {
            ParentContainer     = parent;
            Cursor              = Cursors.Hand;

            PrimaryMediaMenu = new ContextMenuStrip();
            PrimaryMediaMenu.Items.AddRange
            (
                new ToolStripItem[]
                {
                    new ToolStripMenuItem("Remove", null, RemoveEventHandler)
                }
            );

            ContextMenuStrip = PrimaryMediaMenu;

            BackColor = ParentContainer.ColorScheme[Convert.ToInt16(MediaColor.Default)];
            AutoSize  = true;
    
            FlowDirection = FlowDirection.RightToLeft;

            BorderStyle = BorderStyle.FixedSingle;

            FlowLayoutPanel fMainPanel = new FlowLayoutPanel();

            FlowLayoutPanel fSecondaryPanel = new FlowLayoutPanel();

            fSecondaryPanel.FlowDirection = FlowDirection.TopDown;
            fSecondaryPanel.Width = 150;

            Label lResolution   = new Label();
            lResolution.Text    = "Resolution: " + Convert.ToString(videoResource.mThumbnail.Bitmap.Width) + " x " + Convert.ToString(videoResource.mThumbnail.Bitmap.Height);
            lResolution.Height  = 24;
            lResolution.Width   = 128;

            Label lFps      = new Label();
            lFps.Text       = "Frames Per Second: " + Convert.ToString(videoResource.iFramesPerSecond);
            lFps.Height     = 24;
            lFps.Width      = 128;

            Label lName     = new Label();
            lName.Text      = "Name: " + videoResource.sFileName.Substring(videoResource.sFileName.LastIndexOf("\\") + 1);
            lName.Height    = 24;
            lName.Width     = 128;

            PictureBox pbxThumbnails = new PictureBox();
            pbxThumbnails.SizeMode  = PictureBoxSizeMode.Zoom;
            pbxThumbnails.Image     = videoResource.mThumbnail.Bitmap;
            pbxThumbnails.Height    = 64;
            pbxThumbnails.Width     = 64;

            Controls.Add(pbxThumbnails);

            fSecondaryPanel.Controls.Add(lName);
            fSecondaryPanel.Controls.Add(lFps);
            fSecondaryPanel.Controls.Add(lResolution);
            fSecondaryPanel.BackColor = Color.Transparent;

            Controls.Add(fSecondaryPanel);

            Click += mediabox_Click;
            DoubleClick += mediabox_DoubleClick;

        }

        private void mediabox_DoubleClick(object sender, EventArgs e)
        {
            ParentContainer.Load(Parent.Controls.GetChildIndex(this));
        }

        private void mediabox_Click(object sender, EventArgs e)
        {
            ParentContainer.Activate(Parent.Controls.GetChildIndex(this));
        }

        private void RemoveEventHandler(object sender, EventArgs e)
        {
            ParentContainer.RemoveAt(Parent.Controls.GetChildIndex(this));   
        }
    }
}
