using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoEditor
{

    public partial class menuProject : Form
    {
        private VideoProject vProject;

        public menuProject()
        {
            InitializeComponent();

            vProject = new VideoProject();

            vProject.setProName("Unknown");
            vProject.setProFolder("");

            vProject.setFramerate(Convert.ToInt32(tFpsTrackBar.Value));

            vProject.setFrameWidth(Convert.ToInt32(tWidth.Text));
            vProject.setFrameHeight(Convert.ToInt32(tHigh.Text));

        }

        public menuProject(VideoProject vTempPro)
        {
            InitializeComponent();

            vProject = new VideoProject(vTempPro);

            tProjectName.Text = vProject.getProName();
            tProFolder.Text = vProject.getProFolder();

            tFpsTrackBar.Value = vTempPro.getFramerate();

            tWidth.Text = Convert.ToString(vTempPro.getFrameWidth());
            tHigh.Text = Convert.ToString(vTempPro.getFrameHeight());

        }

        private void tConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tFolderChoose_Click(object sender, EventArgs e)
        {
            string sResultFolder = "";

            using (FolderBrowserDialog tFileDialog = new FolderBrowserDialog())
            {
                if (tFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(tFileDialog.SelectedPath))
                {
                    sResultFolder = tFileDialog.SelectedPath;
                }
            }
            tProFolder.Text = sResultFolder;
            vProject.setProFolder(sResultFolder);
        }

        private void tFpsTrackBar_Scroll(object sender, EventArgs e)
        {
            vProject.setFramerate(tFpsTrackBar.Value);
            lFps.Text = "Frames Per Second: " + Convert.ToString(tFpsTrackBar.Value);
        }

        private void tProjectName_TextChanged(object sender, EventArgs e)
        {
            vProject.setProName(tProjectName.Text);
        }

        private void tProFolder_TextChanged(object sender, EventArgs e)
        {
            vProject.setProFolder(tProFolder.Text);
        }

        public VideoProject getProject()
        {
            VideoProject vResult = new VideoProject(vProject);
            return vResult;  
        }

        public VideoProject transferProject(ref VideoProject vTempPro)
        {
            vTempPro.setProName(vProject.getProName());
            vTempPro.setProFolder(vProject.getProFolder());

            vTempPro.setFrameWidth(vProject.getFramerate());

            vTempPro.setFrameWidth(vProject.getFrameWidth());
            vTempPro.setFrameHeight(vProject.getFrameHeight());

            return vTempPro;
        }

        private void tProFolder_Leave(object sender, EventArgs e)
        {
            if(!Directory.Exists(tProFolder.Text))
            {
                MessageBox.Show("Specified path is invalid.");

                tProFolder.Text = "";
            }
        }
    }
}
