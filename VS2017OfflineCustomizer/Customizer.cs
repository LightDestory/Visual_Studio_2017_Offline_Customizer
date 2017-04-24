using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VS2017OfflineCustomizer
{
    class Customizer
    {
        private String CurrentPath;
        private String[] Paths;
        private WebClient webby;
        private int i, EdID;
        public List<String> SelLang = new List<String>(), SelWorkload = new List<String>();

        public Customizer(String CurrentPath)
        {
            Paths = new String[DataContainer.GetData("files").Length];
            webby = new WebClient();
            this.CurrentPath = CurrentPath + "\\" + DataContainer.Getfoldername();
            CreatePaths();
        }

        public Boolean PreInit()
        {
            if (!(File.Exists(Paths[0]) && File.Exists(Paths[1]) && File.Exists(Paths[2])))
            {
                try
                {
                    if (!Directory.Exists(CurrentPath))
                    {
                        Directory.CreateDirectory(CurrentPath);
                    }
                    MessageBox.Show("VS files are not here. I will download the latest version.\nI will freeze for 1-2 minutes,\nSorry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CreatePaths()
        {
            for(i = 0; i< DataContainer.GetData("files").GetLength(0); i++)
            {
                Paths[i] = CurrentPath + "\\" + DataContainer.GetData("files")[i, 0];
            }
        }

        private void DownloadExes()
        {
            for(i = 0; i< DataContainer.GetData("files").GetLength(0); i++)
            {
                webby.DownloadFile(DataContainer.GetData("files")[i, 1], Paths[i]);
            }
        }

        public String SelectEdition(String edition)
        {
            switch (edition)
            {
                case "Community":
                    EdID = 0;
                    return "Community";
                case "Professional":
                    EdID = 1;
                    return "Professional";
                case "Enterprise":
                    EdID = 2;
                    return "Enterprise";
                default:
                    return null;
            }
        }

        public Boolean CheckForUpdate(Boolean visual, String currver)
        {
            Boolean update = false;
            String ver = "";
            try
            {
                ver = webby.DownloadString(DataContainer.GetVersionOnline());
                if (!ver.Equals(currver))
                {
                    update = true;
                    if(MessageBox.Show("There is a update avaible!\nDo you want to open the topic?", "Check for Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(DataContainer.GetMyDigitalTopic());
                    }
                }
                else
                {
                    if (visual)
                    {
                        MessageBox.Show("You are using the latest version.", "Check for Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (WebException)
            {
                if(visual)
                {
                    MessageBox.Show("Network unavaible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return update;
        }

        public String GetArgs(String saveto)
        {
            String args = "--layout " + saveto;
            if (SelWorkload.Count > 0 && SelWorkload.Count < 17)
            {
                String workarg = " --add";
                foreach (String s in SelWorkload)
                {
                    workarg = workarg + " " + DataContainer.GetWorkload_prefix() + s;
                }
                args = args + workarg;
            }
            if (SelLang.Count > 0 && SelLang.Count <14)
            {
                String langarg = " --lang";
                foreach (String s in SelLang)
                {
                    langarg = langarg + " " + s;
                }
                args = args + langarg;
            }

            return args;
        }

        public int GetID()
        {
            return EdID;
        }

        public String[] GetPaths()
        {
            return Paths;
        }
    }
}
