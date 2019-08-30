using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class SubtitlesMainMenu : Form
    {

        public List<string> sSubtitles { get; private set; }

        public List<Int16> iNavigator;

        Int16 iCurrentIndex;

        public SubtitlesMainMenu(List<string> sList)
        {
            InitializeComponent();

            sSubtitles = new List<string>(sList);

            iNavigator = new List<Int16>(); iNavigator.Add(0);

            iCurrentIndex = 0;

            if (sSubtitles.Count() >= 3)
            {
                tSubIndex.Text = sSubtitles.ElementAt(0);
             
                string sLine = sSubtitles.ElementAt(1);

                tStartPoint.Text = sLine.Substring(0, sLine.IndexOf(" ") + 1);
          
                tEndPoint.Text = sLine.Substring(sLine.LastIndexOf(" "));

                Int16 iTemp;

                for (iTemp = 0; sLine != string.Empty; iTemp++)
                {
                    sLine = sSubtitles.ElementAt(iCurrentIndex + 2 + iTemp);

                    if (sLine == string.Empty)
                    {
                        break;
                    }

                    tMainBox.AppendText(sLine);
                    tMainBox.AppendText(Environment.NewLine);
                }

                iNavigator.Add(Convert.ToInt16(iCurrentIndex + 3 + iTemp));
            }
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            string sSubFile = "";

            using (OpenFileDialog tFileDialog = new OpenFileDialog())
            {
                if (tFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(tFileDialog.FileName))
                {
                    sSubFile = tFileDialog.FileName;
                }
            }

            if (sSubFile.Substring(sSubFile.LastIndexOf(".") + 1) == "srt")
            {
                using (FileStream sFilestream = new FileStream(sSubFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sFile = new StreamReader(sFilestream, Encoding.UTF8, true))
                    {
                        string sLineOfText = "";

                        Int16 iTempIndex = 0;

                        while (sLineOfText != null)
                        {
                            iNavigator.Add(iTempIndex);

                            while ((sLineOfText = sFile.ReadLine()) != string.Empty && sLineOfText != null)
                            {
                                sSubtitles.Add(sLineOfText);
                                iTempIndex++;
                            }

                            sSubtitles.Add(string.Empty);
                            iTempIndex++;
                        }
                    }
                }
            }
        }

        private void bErase_Click(object sender, EventArgs e)
        {
            tSubIndex.Text = "";
            tStartPoint.Text = "";
            tEndPoint.Text = "";
            tMainBox.Text = "";

            sSubtitles.Clear();
            iNavigator.Clear();

            iCurrentIndex = 0;

        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            if (iCurrentIndex > 0)
            {
                Int16 iStartingPoint = iNavigator.ElementAt(--iCurrentIndex);

                tSubIndex.Text = sSubtitles.ElementAt(iStartingPoint);

                string sLine = sSubtitles.ElementAt(iStartingPoint + 1);

                tStartPoint.Text = sLine.Substring(0, sLine.IndexOf(" ") + 1);

                tEndPoint.Text = sLine.Substring(sLine.LastIndexOf(" "));

                Int16 iTemp = iStartingPoint;

                tMainBox.Text = "";
                for (iTemp = 0; sLine != string.Empty; iTemp++)
                {
                    sLine = sSubtitles.ElementAt(iStartingPoint + 2 + iTemp);

                    if (sLine == string.Empty)
                    {
                        break;
                    }

                    tMainBox.AppendText(sLine);
                    tMainBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (iCurrentIndex + 1 < iNavigator.Count())
            {
                Int16 iStartingPoint = iNavigator.ElementAt(++iCurrentIndex);

                tSubIndex.Text = sSubtitles.ElementAt(iStartingPoint);

                string sLine = sSubtitles.ElementAt(iStartingPoint + 1);

                tStartPoint.Text = sLine.Substring(0, sLine.IndexOf(" ") + 1);

                tEndPoint.Text = sLine.Substring(sLine.LastIndexOf(" "));

                Int16 iTemp;

                tMainBox.Text = "";
                for (iTemp = 0; sLine != string.Empty; iTemp++)
                {
                    sLine = sSubtitles.ElementAt(iStartingPoint + 2 + iTemp);

                    if (sLine == string.Empty)
                    {
                        break;
                    }

                    tMainBox.AppendText(sLine);
                    tMainBox.AppendText(Environment.NewLine);
                }
            }
        }

        private void tMainBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
