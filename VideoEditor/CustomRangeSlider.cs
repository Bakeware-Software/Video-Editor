using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class CustomRangeSlider : PictureBox
    {
        private class Tick : PictureBox
        {
            private CustomRangeSlider parentControl;

            private Point MouseDownLocation;

            public Tick(CustomRangeSlider parent)
            {
                parentControl = parent;

                Cursor = Cursors.Hand;

                MouseDown += new MouseEventHandler(MouseDownEvent);
                MouseMove += new MouseEventHandler(MouseMoveEvent);

                SetBounds(parentControl.Location.X, parentControl.Location.Y, parentControl.Width, parentControl.Height);
            }

            private void MouseDownEvent(object sender, MouseEventArgs mEvents)
            {
                if (mEvents.Button == MouseButtons.Left)
                {
                    MouseDownLocation = mEvents.Location;
                }
            }

            private void MouseMoveEvent(object sender, MouseEventArgs mEvents)
            {
                if (mEvents.Button == MouseButtons.Left)
                {
                    this.Left = mEvents.X + this.Left - MouseDownLocation.X;
                    parentControl.ValidateTicks();
                }
            }         
        }

        private Tick RegBegin, RegEnd;
        private TrackBar ParentTrackBar;

        public CustomRangeSlider(TrackBar ParentTrackBar)
        {
            InitializeComponent();

            this.ParentTrackBar = ParentTrackBar;

            this.BackColor          = Color.Black;
            this.Width              = ParentTrackBar.Width;
            this.Height             = 10;

            RegBegin            = new Tick(this);
            RegBegin.BackColor  = Color.Yellow;
            RegBegin.Width      = 5;
            RegBegin.Height     = 10;

            this.Controls.Add(RegBegin);

            RegEnd              = new Tick(this);
            RegEnd.BackColor    = Color.Red;
            RegEnd.Width        = 5;
            RegEnd.Height       = 10;

            this.Controls.Add(RegEnd);

        }

        public int getStart()
        {
            return RegBegin.Location.X;
        }

        public int getEnd()
        {
            return RegEnd.Location.X;
        }

        private void ValidateTicks()
        {
            if(RegBegin.Location.X > RegEnd.Location.X)
            {
                Tick TempTick = RegBegin;

                RegBegin = RegEnd;
                RegEnd = TempTick;

                RegBegin.BackColor = Color.Yellow;
                RegEnd.BackColor = Color.Red;
            }
        }
    }
}
