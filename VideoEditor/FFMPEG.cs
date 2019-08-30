using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEditor
{
    class FFMPEG
    {
        private Int16 iMediaCounter;

        public String sMediaLabel { get; set; }

        public String sEnginePath { get; set; }


        public FFMPEG(String sEnginePath)
        {
            this.sEnginePath = sEnginePath;

            sMediaLabel = "Media";

            iMediaCounter = 0;
        }

        public List<String> cutVideo(String sVideoFile, String sOutputFolder, int iCutPosition)
        {
            List<String> sResultMedia = new List<String>();
            String sOutputPath = "", sArguments = "";

            sOutputPath = sOutputFolder + "\\" + sMediaLabel + "_" + Convert.ToString(iMediaCounter) + sVideoFile.Substring(sVideoFile.LastIndexOf("."));

            sArguments = " -t " + Convert.ToString(iCutPosition) + " -i " + '\"' + sVideoFile + '\"' + " -c " + " copy " + '\"' + sOutputPath + '\"';
            Console.WriteLine(sArguments);
            if (performAction(sArguments))
            {
                sResultMedia.Add(sOutputPath);

                sOutputPath = sOutputFolder + "\\" + sMediaLabel + "_" + Convert.ToString(iMediaCounter) + sVideoFile.Substring(sVideoFile.LastIndexOf("."));

                sArguments = " -ss " + Convert.ToString(iCutPosition) + " -i " + '\"' + sVideoFile + '\"' + " -c " + " copy " + '\"' + sOutputPath + '\"';

                if (performAction(sArguments))
                {
                    sResultMedia.Add(sOutputPath);
                }
            }
            
            return sResultMedia;
        }

        public String trimVideo(String sVideoFile, String sOutputFolder, int iCutPosition, bool bFromStart)
        {
            String sResultMedia = "";
            String sOutputPath = "", sArguments = "";

            sOutputPath = sOutputFolder + "\\" + sMediaLabel + "_" + Convert.ToString(iMediaCounter) + sVideoFile.Substring(sVideoFile.LastIndexOf("."));

            sArguments = (bFromStart ? " -ss " + Convert.ToString(iCutPosition) : " -t " + Convert.ToString(iCutPosition)) + " -i " + '\"' + sVideoFile + '\"' + " -c " + " copy " + '\"' + sOutputPath + '\"';

            if (performAction(sArguments))
            {
                sResultMedia = sOutputPath;
            }

            return sResultMedia;

        }

        public String removeAudio(String sVideoFile, String sOutputFolder)
        {
            String sOutputPath = "", sArguments = "";

            sOutputPath = sOutputFolder + "//" + "na_" + sMediaLabel + "_" + Convert.ToString(iMediaCounter) + sVideoFile.Substring(sVideoFile.LastIndexOf("."));
            sArguments = " -i " + '\"' + sVideoFile + '\"' + " -c " + " copy " + " -an " + '\"' + sOutputPath + '\"';

            performAction(sArguments);

            return sOutputPath;
        }

        public String extractAudio(String sVideoFile, String sOutputFolder)
        {
            String sOutputPath = "", sArguments = "";

            sOutputPath = sOutputFolder + "//" + "exa_" + sMediaLabel + Convert.ToString(iMediaCounter) + ".aac";

            sArguments = " -y " + "-i " + '\"' + sVideoFile + '\"' + " -vn " + " -acodec " + " copy " + '\"' + sOutputPath + '\"';

            performAction(sArguments);

            return sOutputPath;
        }

        public String changeSpeed(String sVideoFile, String sOutputFolder, Double dSpeedModifier)
        {
            String sArguments = "", sOutputPath = "";

            sOutputPath = sOutputFolder + "//" + sMediaLabel + "_" + Convert.ToString(iMediaCounter) + Convert.ToString(dSpeedModifier) + "_s_" + sVideoFile.Substring(sVideoFile.LastIndexOf("."));

            sArguments = " -y " + " -i " + '\"' + sVideoFile + '\"' + " -q " + " 1 " + " -vf " + " setpts=" + String.Format("{0:0.00}", 1.0 / dSpeedModifier).Replace(',', '.') + "*PTS " + " -filter:a " + " atempo=" + Convert.ToString(dSpeedModifier).Replace(',', '.') + " " + '\"' + sOutputPath + '\"';

            performAction(sArguments);

            return sOutputPath;
        }

        /* format handling needed */

        public String concatVideos(List<String> sVideoFiles, String sOutputFolder, String sFileName, String sVideoFormat, int iWidth, int iHeight, int iFramerate)
        {
            String sArguments = "", sOutputPath = "";

            sOutputPath = "\"" + sOutputFolder + "//" + sFileName + sVideoFormat + "\"";

            String sMediaList = "", sFilters = "-filter_complex " + '\"', sMapping = " -map \"[v]\"  -map \"[a]\" " + sOutputPath, sMappedStreams = "";

            List<String> sTempList = new List<String>();

            for (Int32 iMediaCounter = 0; iMediaCounter < sVideoFiles.Count(); iMediaCounter++)
            {
                sTempList.Add("[v" + Convert.ToString(iMediaCounter) + "]");
                sMediaList = sMediaList + " -i \"" + sVideoFiles.ElementAt(iMediaCounter) + '\"';
                sFilters = sFilters + "[" + Convert.ToString(iMediaCounter) + ":v]fps=" + Convert.ToString(iFramerate) + ",scale=" + Convert.ToString(iWidth) + ":" + Convert.ToString(iHeight) + sTempList[iMediaCounter] + ";";
                sMappedStreams = sMappedStreams + sTempList[iMediaCounter] + "[" + Convert.ToString(iMediaCounter) + ":a] ";
            }

            sFilters = sFilters + sMappedStreams + " concat=n=" + Convert.ToString(sVideoFiles.Count()) + ":v=1:a=1 [v] [a] \"";
            sArguments = " -y " + sMediaList + " " + sFilters + " " + sMapping;

            performAction(sArguments);

            String sSubsFileName = "\"" + sOutputFolder + "//" + sFileName + ".srt" + "\"";

            sArguments = " -y " + " -i " + sOutputPath + " -i " + sSubsFileName + " -c " + " copy " + " -c:s mov_text " + sOutputPath;

            performAction(sArguments);

            return sOutputPath;
        }



        private bool performAction(String sArgumentList)
        {
            Debug.WriteLine("---------------------------------------------------------------------------------------");
            Debug.WriteLine(sArgumentList);
            Debug.WriteLine("---------------------------------------------------------------------------------------");

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = sEnginePath;
            startInfo.Arguments = sArgumentList;
            startInfo.RedirectStandardOutput = true;

            using (Process process = Process.Start(startInfo))
            {
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    Debug.WriteLine(line);
                }

                process.WaitForExit();
            }

            iMediaCounter++;

            return true;
        }
    }
}
