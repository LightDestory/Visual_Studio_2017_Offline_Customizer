using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VS2017OfflineCustomizer
{
    class Customizer
    {
        public DataContainer Data;
        private String CurrentPath;
        public String[] Paths;
        private WebClient webby;
        public int i, EdID;
        public List<String> SelLang = new List<String>(), SelWorkload = new List<String>();

        public Customizer(String CurrentPath)
        {
            Data = new DataContainer();
            Paths = new String[Data.getData("files").Length];
            webby = new WebClient();
            this.CurrentPath = CurrentPath + "\\" + Data.getFoldername();
            GetPaths();
        }

        public Boolean PreInit(String edition)
        {
            SelectEdition(edition);
            if (!(File.Exists(Paths[0]) && File.Exists(Paths[1]) && File.Exists(Paths[2])))
            {
                try
                {
                    if (!Directory.Exists(CurrentPath))
                    {
                        Directory.CreateDirectory(CurrentPath);
                    }
                    DownloadExes();

                }

                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access Denied. Retry running as Admin");
                    return false;
                    
                }
                catch (WebException)
                {
                    MessageBox.Show("Download Error. Check Network");
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        public void AddRemoveID(String ID, List<String> List)
        {
            Boolean remove = false;
            foreach (String c in List)
            {
                if (c.Equals(ID))
                {
                    remove = true;
                    break;
                }
            }
            if (remove)
            {
                List.Remove(ID);
            }
            else
            {
                List.Add(ID);
            }

        }

        private void GetPaths()
        {
            for(i = 0; i<Data.getData("files").GetLength(0); i++)
            {
                Paths[i] = CurrentPath + "\\" + Data.getData("files")[i, 0];
            }
        }

        private void DownloadExes()
        {
            for(i = 0; i<Data.getData("files").GetLength(0); i++)
            {
                webby.DownloadFile(Data.getData("files")[i, 1], Paths[i]);
            }
        }

        private void SelectEdition(String edition)
        {
            switch (edition)
            {
                case "Community":
                    EdID = 0;
                    break;
                case "Professional":
                    EdID = 1;
                    break;
                case "Enterprise":
                    EdID = 2;
                    break;
            }
        }

        public String GetArgs(String saveto)
        {
            String args = "--layout " + saveto;
            if (SelWorkload.Count != 0)
            {
                String workarg = " --add";
                foreach (String s in SelWorkload)
                {
                    workarg = workarg + " " + s;
                }
                args = args + workarg;
            }
            if (SelLang.Count != 0)
            {
                String langarg = " --lang";
                foreach(String s in SelLang)
                {
                    langarg = langarg + " " + s;
                }
                args = args + langarg;
            }

            return args;
        }
    }
}
