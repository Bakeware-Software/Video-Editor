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

namespace VideoEditor
{
    //class AudioTrack : FlowLayoutPanel
    //{
    //    List<PictureBox> Thumbnails;
    //}

    class VideoTrack : FlowLayoutPanel
    {
        private DynamicMediaControl ParentContainer;

        private  ContextMenuStrip PrimaryMediaMenu;

        List<PictureBox> Thumbnails;

        public VideoTrack(DynamicMediaControl parent, VideoFile videoResource, int iFramesToPixelRatio)
        {
            ParentContainer     = parent;
            Cursor              = Cursors.Hand;

            PrimaryMediaMenu = new ContextMenuStrip();
            PrimaryMediaMenu.Items.AddRange
            (
                new ToolStripItem[]
                {
                    new ToolStripMenuItem("Remove", null, RemoveEventHandler),
                    new ToolStripMenuItem("Move Left", null, MoveLeftEventHandler),
                    new ToolStripMenuItem("Move Right", null, MoveRightEventHandler)
                }
            );

            ContextMenuStrip = PrimaryMediaMenu;

            Width = (videoResource.iTotalFrames / videoResource.iFramesPerSecond) * iFramesToPixelRatio;
            Height = 56;

            BorderStyle = BorderStyle.FixedSingle;

            Margin = new Padding(0, 3, 0, 3);

            BackColor = ParentContainer.ColorScheme[Convert.ToInt16(MediaColor.Default)];

            Thumbnails = new List<PictureBox>();

            Thumbnails.Add(new PictureBox { Image = videoResource.mThumbnail.Bitmap, SizeMode = PictureBoxSizeMode.Zoom });

            Controls.Add(Thumbnails[0]);

            Click += mediatrack_Click;
            DoubleClick += mediatrack_DoubleClick;

          
        }

        public void rescale(int iValue = 1, bool bShrink = false)
        {
            if(bShrink)
            {
                Width = Width / iValue;
            }
            else
            {
                Width = Width * iValue;
            }            
        }

        private void mediatrack_DoubleClick(object sender, EventArgs e)
        {
            ParentContainer.Load(Parent.Controls.GetChildIndex(this));
        }

        private void mediatrack_Click(object sender, EventArgs e)
        {
            ParentContainer.Activate(Parent.Controls.GetChildIndex(this));
        }

        private void RemoveEventHandler(object sender, EventArgs e)
        {
            ParentContainer.RemoveAt(Parent.Controls.GetChildIndex(this));
        }

        private void MoveLeftEventHandler(object sender, EventArgs e)
        {
            ParentContainer.MoveLeft(Parent.Controls.GetChildIndex(this));
        }

        private void MoveRightEventHandler(object sender, EventArgs e)
        {
            ParentContainer.MoveRight(Parent.Controls.GetChildIndex(this));
        }

    } 
}
