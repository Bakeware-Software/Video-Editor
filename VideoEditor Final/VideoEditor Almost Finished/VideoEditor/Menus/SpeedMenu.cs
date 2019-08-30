using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class menuSpeed : Form
    {
        public double dValue;

        private FlowLayoutPanel msMainLayout;
        private Label lSpeedLabel;
        private TrackBar smSpeedTrackbar;
        private FlowLayoutPanel smSecondaryLayout;
        private Label msValueLabel;

        public menuSpeed()
        {
            InitializeComponent();
            dValue = 0.0;
        }

        private void InitializeComponent()
        {
            this.msMainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lSpeedLabel = new System.Windows.Forms.Label();
            this.smSpeedTrackbar = new System.Windows.Forms.TrackBar();
            this.msValueLabel = new System.Windows.Forms.Label();
            this.smSecondaryLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.smConfirmButton = new System.Windows.Forms.Button();
            this.smCancelButton = new System.Windows.Forms.Button();
            this.msMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smSpeedTrackbar)).BeginInit();
            this.smSecondaryLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainLayout
            // 
            this.msMainLayout.AutoSize = true;
            this.msMainLayout.Controls.Add(this.lSpeedLabel);
            this.msMainLayout.Controls.Add(this.smSpeedTrackbar);
            this.msMainLayout.Controls.Add(this.msValueLabel);
            this.msMainLayout.Controls.Add(this.smSecondaryLayout);
            this.msMainLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.msMainLayout.Location = new System.Drawing.Point(0, 0);
            this.msMainLayout.MaximumSize = new System.Drawing.Size(146, 134);
            this.msMainLayout.MinimumSize = new System.Drawing.Size(146, 134);
            this.msMainLayout.Name = "msMainLayout";
            this.msMainLayout.Size = new System.Drawing.Size(146, 134);
            this.msMainLayout.TabIndex = 0;
            // 
            // lSpeedLabel
            // 
            this.lSpeedLabel.AutoSize = true;
            this.lSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSpeedLabel.Location = new System.Drawing.Point(3, 0);
            this.lSpeedLabel.Name = "lSpeedLabel";
            this.lSpeedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lSpeedLabel.Size = new System.Drawing.Size(140, 13);
            this.lSpeedLabel.TabIndex = 1;
            this.lSpeedLabel.Text = "Choose Speed";
            this.lSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // smSpeedTrackbar
            // 
            this.smSpeedTrackbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smSpeedTrackbar.LargeChange = 1;
            this.smSpeedTrackbar.Location = new System.Drawing.Point(3, 16);
            this.smSpeedTrackbar.Maximum = 5;
            this.smSpeedTrackbar.Minimum = 1;
            this.smSpeedTrackbar.Name = "smSpeedTrackbar";
            this.smSpeedTrackbar.Size = new System.Drawing.Size(140, 45);
            this.smSpeedTrackbar.TabIndex = 0;
            this.smSpeedTrackbar.Value = 3;
            this.smSpeedTrackbar.Scroll += new System.EventHandler(this.smSpeedTrackbar_Scroll);
            // 
            // msValueLabel
            // 
            this.msValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.msValueLabel.AutoSize = true;
            this.msValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msValueLabel.Location = new System.Drawing.Point(3, 64);
            this.msValueLabel.Name = "msValueLabel";
            this.msValueLabel.Size = new System.Drawing.Size(140, 13);
            this.msValueLabel.TabIndex = 0;
            this.msValueLabel.Text = "x1.0";
            this.msValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smSecondaryLayout
            // 
            this.smSecondaryLayout.Controls.Add(this.smConfirmButton);
            this.smSecondaryLayout.Controls.Add(this.smCancelButton);
            this.smSecondaryLayout.Location = new System.Drawing.Point(3, 80);
            this.smSecondaryLayout.Name = "smSecondaryLayout";
            this.smSecondaryLayout.Size = new System.Drawing.Size(140, 30);
            this.smSecondaryLayout.TabIndex = 3;
            // 
            // smConfirmButton
            // 
            this.smConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.smConfirmButton.AutoSize = true;
            this.smConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smConfirmButton.Location = new System.Drawing.Point(3, 3);
            this.smConfirmButton.Name = "smConfirmButton";
            this.smConfirmButton.Size = new System.Drawing.Size(62, 23);
            this.smConfirmButton.TabIndex = 0;
            this.smConfirmButton.Text = "Confirm";
            this.smConfirmButton.UseVisualStyleBackColor = true;
            this.smConfirmButton.Click += new System.EventHandler(this.smConfirmButton_Click);
            // 
            // smCancelButton
            // 
            this.smCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.smCancelButton.AutoSize = true;
            this.smCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.smCancelButton.Location = new System.Drawing.Point(71, 3);
            this.smCancelButton.Name = "smCancelButton";
            this.smCancelButton.Size = new System.Drawing.Size(61, 23);
            this.smCancelButton.TabIndex = 1;
            this.smCancelButton.Text = "Cancel";
            this.smCancelButton.UseVisualStyleBackColor = true;
            // 
            // menuSpeed
            // 
            this.AcceptButton = this.smConfirmButton;
            this.CancelButton = this.smCancelButton;
            this.ClientSize = new System.Drawing.Size(147, 136);
            this.Controls.Add(this.msMainLayout);
            this.Name = "menuSpeed";
            this.Text = "Change Speed";
            this.msMainLayout.ResumeLayout(false);
            this.msMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smSpeedTrackbar)).EndInit();
            this.smSecondaryLayout.ResumeLayout(false);
            this.smSecondaryLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void smCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void smSpeedTrackbar_Scroll(object sender, EventArgs e)
        {
            dValue = Convert.ToDouble(smSpeedTrackbar.Value) * 0.25;
            msValueLabel.Text = "x" + Convert.ToString(dValue);
        }

        private void smConfirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
