using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;


namespace VLCHandler
{
    class Program
    {
        static string FindByDisplayName(RegistryKey parentKey, string name)
        {
            string[] nameList = parentKey.GetSubKeyNames();
            for (int i = 0; i < nameList.Length; i++)
            {
                RegistryKey regKey = parentKey.OpenSubKey(nameList[i]);
                try
                {
                    if (regKey.GetValue("DisplayName").ToString() == name)
                    {
                        return regKey.GetValue("DisplayIcon").ToString();
                    }
                }
                catch { }
            }
            return "";
        }
        static string processFile(string arg)
        {
            string file = arg.Replace("vlchandler:","");
            return file;
        }



        static void Main(string[] args)
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
            string vlc_path = FindByDisplayName(regKey, "VLC media player");
            string video_file = "";

            foreach (string s in args)
            {
                video_file = processFile(s);
            }

            System.Diagnostics.Process.Start(vlc_path, video_file);
 
        }
    }
}
