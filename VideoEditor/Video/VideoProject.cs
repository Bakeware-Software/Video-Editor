using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;


namespace VideoEditor
{
    [DataContract()]
    public class VideoProject
    {
        [DataMember(Name = "Media Resources")]
        public List<string> sMediaResources { get; private set; }

        [DataMember(Name = "Subtitles")]
        public List<string> sSubtitles { get; private set; }

        [DataMember(Name = "Name")]
        private string sProjectName { get; set; }
        [DataMember(Name = "Folder")]
        private string sProjectFolderPath { get; set; }

        [DataMember(Name = "Framerate")]
        private int iFramesPerSecond { get; set; }

        [DataMember(Name = "Width")]
        private int iWidth { get; set; }

        [DataMember(Name = "Height")]
        private int iHeight { get; set; }

        private bool bWasChanged;

        public VideoProject()
        {
            sMediaResources = new List<String>();

            sProjectName        = "Untitled";
            sProjectFolderPath  = "";

            iFramesPerSecond = 30;

            iWidth  = 640;
            iHeight = 480;

            sSubtitles = new List<string>();

            bWasChanged = false;
        }

        public VideoProject(VideoProject vTempProject)
        {
            sMediaResources = new List<String>();

            for (int iTemp = 0; iTemp < vTempProject.sMediaResources.Count(); iTemp++)
            {
                sMediaResources.Add(vTempProject.sMediaResources.ElementAt(iTemp));
            }

            sProjectName            = vTempProject.sProjectName;
            sProjectFolderPath      = vTempProject.sProjectFolderPath;

            iFramesPerSecond        = vTempProject.iFramesPerSecond;

            iWidth      = vTempProject.iWidth;
            iHeight     = vTempProject.iHeight;

            for (int iTemp = 0; iTemp < vTempProject.sSubtitles.Count(); iTemp++)
            {
                sMediaResources.Add(vTempProject.sSubtitles.ElementAt(iTemp));
            }

            bWasChanged = false;

        }

        public void addMedia(String sMediaUrl)
        {
            sMediaResources.Add(sMediaUrl);

            bWasChanged = true;
        }

        public void removeMedia(int iMediaIndex)
        {
            sMediaResources.RemoveAt(iMediaIndex);

            bWasChanged = true;
        }

        public bool saveProject()
        {
            DataContractSerializer outputSerializer = new DataContractSerializer(typeof(VideoProject));
            using (XmlWriter outputWriter = XmlWriter.Create(sProjectFolderPath + "\\" + sProjectName + ".xml"))
            {
                outputSerializer.WriteObject(outputWriter, this);
            }

            bWasChanged = false;

            return true;
        }

        static public VideoProject loadProject(string sPath)
        {
            VideoProject loadedProject;
            DataContractSerializer inputSerializer = new DataContractSerializer(typeof(VideoProject));
            using (XmlReader inputReader = XmlReader.Create(sPath))
            {
                loadedProject = new VideoProject((VideoProject)inputSerializer.ReadObject(inputReader));
            }

            loadedProject.bWasChanged = false;

            return loadedProject;
        }

        public void saveSubs()
        {
            using (StreamWriter sFile = new StreamWriter(sProjectFolderPath + "\\" + sProjectName + ".srt"))
            {
                if (sSubtitles != null)
                {
                    foreach (string sLine in sSubtitles)
                    {
                        sFile.WriteLine(sLine);
                    }
                }
            }
        }

        public bool wasChanged()
        {
            return bWasChanged;
        }

        public string getProName()
        {
            return sProjectName;
        }

        public string getProFolder()
        {
            return sProjectFolderPath;
        }

        public int getFramerate()
        {
            return iFramesPerSecond;
        }

        public int getFrameWidth()
        {
            return iWidth;
        }

        public int getFrameHeight()
        {
            return iHeight;
        }

        public void setProName(string sNewName)
        {
            sProjectName = sNewName;
            bWasChanged = true;
        }

        public void setProFolder(string sFolderPath)
        {
            sProjectFolderPath = sFolderPath;
            bWasChanged = true;
        }

        public void setFramerate(int iFramerate)
        {
            iFramesPerSecond = iFramerate;
            bWasChanged = true;
        }

        public void setFrameWidth(int iWidth)
        {
            this.iWidth = iWidth;
            bWasChanged = true;
        }

        public void setFrameHeight(int iHeight)
        {
            this.iHeight = iHeight;
            bWasChanged = true;
        }

        public void setSubtitles(List<string> sSubtitles)
        {
            this.sSubtitles = sSubtitles;
            bWasChanged = true;
        }
    }
}
