using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoEditor;

namespace VideoEditor
{
    class MediaLabel : Label
    {
        private DynamicMediaControl ParentContainer;

        private ContextMenuStrip PrimaryMediaMenu;

        public MediaLabel(DynamicMediaControl parent, VideoFile videoResource)
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

            Text = videoResource.sFileName;

            BackColor = ParentContainer.ColorScheme[Convert.ToInt16(MediaColor.Default)];

            Font = new Font("Arial", 8);

            BorderStyle = BorderStyle.FixedSingle;

            Margin = new Padding(0, 1, 0, 1);
            MinimumSize = new Size(216, 16);
            AutoSize = true;

            Click += tempLabel_Click;
            DoubleClick += tempLabel_DoubleClick;

        }

        /*----------------------------------------------------------------------------------------------------------------------------------------*/

        private void tempLabel_DoubleClick(object sender, EventArgs e)
        {
            ParentContainer.Load(Parent.Controls.GetChildIndex(this));
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {
            ParentContainer.Activate(Parent.Controls.GetChildIndex(this));
        }

        private void RemoveEventHandler(object sender, EventArgs e)
        {
            ParentContainer.RemoveAt(Parent.Controls.GetChildIndex(this));
        }
    }
}
