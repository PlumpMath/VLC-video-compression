using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using System.IO;

namespace KompresjaVideo
{
    public class VlcManager
    {
        private string _vlcPath;
        private bool _isInitialized;
        private string _fileName;
        private string _fileDest;

        public bool IsInitialized { get => _isInitialized; set => _isInitialized = value; }
        public string VlcPath { get => _vlcPath; set => _vlcPath = value; }
        public string FileDest
        {
            get => _fileDest;
            set => _fileDest = value.Replace("\"", "\\");
        }
        public string FileName
        {
            get => _fileName;
            set => _fileName = value.Replace("\"", "\\");
        }

        public VlcManager(string vlcPath)
        {
            if (vlcPath.EndsWith("vlc.exe"))
            {
                VlcPath = vlcPath;
                IsInitialized = true;
            }
            else
            {
                IsInitialized = false;
            }
        }

        public VlcManager()
        {
            IsInitialized = false;
        }

        public bool Export(string vCodec, string aCodec, int vBitRate, int aBitRate, double fps, double scale)
        {
            var vlcDir = VlcPath.Replace("vlc.exe", "");

            if (IsInitialized)
            {
                var command = "vlc \"" + FileName + "\" --sout=#transcode{vcodec=" + vCodec + ",acodec=" + aCodec + ",vb=" + vBitRate + ",ab=" + aBitRate + ",scale=" + scale + ",fps=" + fps + "}:standard{access=file,mux=ts,dst=\"" + FileDest + "\"} vlc://quit";

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.Verb = "runas";
                cmd.Start();
                cmd.StandardInput.WriteLine("cd " + vlcDir);
                cmd.StandardInput.WriteLine(command);                
                return true;
            }
            else
                return false;            
        }        
    }
}
