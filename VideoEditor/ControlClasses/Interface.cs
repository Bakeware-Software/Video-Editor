using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;


namespace VideoEditor
{
    public class Interface
    {
        public enum GraphicTheme { Dark, Light, Blue};

        public Interface()
        {

        }

        public void SetBackground(object recived, GraphicTheme mode)
        {
            var send = recived;

            if (send is FlowLayoutPanel) {

                if (mode == GraphicTheme.Dark) {
                    (send as FlowLayoutPanel).BackColor = Color.FromArgb(30, 30, 30);
                    (send as FlowLayoutPanel).BorderStyle = BorderStyle.FixedSingle;

                } else if (mode == GraphicTheme.Light) {
                    (send as FlowLayoutPanel).BackColor = Color.FromArgb(150, 150, 150);
                    (send as FlowLayoutPanel).BorderStyle = BorderStyle.FixedSingle;

                } else if (mode == GraphicTheme.Blue) {
                    (send as FlowLayoutPanel).BackColor = Color.FromArgb(213, 219, 233);
                    (send as FlowLayoutPanel).BorderStyle = BorderStyle.FixedSingle;
                }

            } else if (send is Form) {

                if (mode == GraphicTheme.Dark) {
                    (send as Form).BackColor = Color.FromArgb(45, 45, 48);

                } else if (mode == GraphicTheme.Light) {
                    (send as Form).BackColor = Color.White;

                } else if (mode == GraphicTheme.Blue) {
                    (send as Form).BackColor = Color.FromArgb(42, 57, 86);
                }

            } else if (send is Panel) {

                if (mode == GraphicTheme.Dark) {
                    (send as Panel).BackColor = Color.FromArgb(45, 45, 48);

                } else if (mode == GraphicTheme.Light) {
                    (send as Panel).BackColor = Color.White;

                } else if (mode == GraphicTheme.Blue) {
                    (send as Panel).BackColor = Color.FromArgb(42, 57, 86);
                }

            } else if (send is Button) {

                if (mode == GraphicTheme.Dark) {
                    (send as Button).BackColor = Color.FromArgb(30, 30, 30);
                    (send as Button).ForeColor = Color.FromArgb(100, 100, 100);
                    (send as Button).FlatStyle = FlatStyle.Flat;

                    (send as Button).FlatAppearance.BorderSize = 1;

                } else if (mode == GraphicTheme.Light) {
                    (send as Button).BackColor = Color.White;
                    (send as Button).ForeColor = Color.FromArgb(0, 0, 0);
                    (send as Button).FlatStyle = FlatStyle.Flat;

                } else if (mode == GraphicTheme.Blue) {
                    (send as Button).BackColor = Color.FromArgb(69, 89, 124);
                    (send as Button).ForeColor = Color.FromArgb(0, 0, 0);
                    (send as Button).FlatStyle = FlatStyle.Flat;
                }

            } else if (send is TrackBar) {

                if (mode == GraphicTheme.Dark) {
                    (send as TrackBar).BackColor = Color.FromArgb(30, 30, 30);

                } else if (mode == GraphicTheme.Light) {
                    (send as TrackBar).BackColor = Color.White;

                } else if (mode == GraphicTheme.Blue) {
                    (send as TrackBar).BackColor = Color.FromArgb(213, 219, 233);
                }

            } else if (send is Label) {

                if (mode == GraphicTheme.Dark) {
                    (send as Label).BackColor = Color.FromArgb(30, 30, 30);
                    (send as Label).ForeColor = Color.FromArgb(100, 100, 100);
                    (send as Label).BorderStyle = BorderStyle.FixedSingle;

                } else if (mode == GraphicTheme.Light) {
                    (send as Label).BackColor = Color.White;
                    (send as Label).ForeColor = Color.FromArgb(0, 0, 0);
                    (send as Label).BorderStyle = BorderStyle.FixedSingle;

                } else if (mode == GraphicTheme.Blue) {
                    (send as Label).BackColor = Color.FromArgb(213, 219, 233);
                    (send as Label).ForeColor = Color.FromArgb(0, 0, 0);
                    (send as Label).BorderStyle = BorderStyle.FixedSingle;

                }

            } else {
                throw new System.ArgumentException("INCORRECT OBJECT FORMAT");

            }
        }

        public void SetColor(GraphicTheme mode)
        {
            switch(mode)
            {
                case GraphicTheme.Dark:
                    break;
                case GraphicTheme.Light:
                    break;
                case GraphicTheme.Blue:
                    break;
                default:
                    break;
            }
        }
    }
}

