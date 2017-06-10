using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace VS2017OfflineCustomizer
{
    class Customizer
    {
        private String CurrentPath, SaveTo = "";
        private String[] Paths;
        private WebClient webby;
        private int i, EdID;
        public List<String> SelLang = new List<String>(), SelWorkload = new List<String>();

        public Customizer(String CurrentPath)
        {
            Paths = new String[DataContainer.GetData("files").GetLength(0)];
            webby = new WebClient();
            this.CurrentPath = CurrentPath + "\\" + DataContainer.GetFolderName();
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
                    MessageBox.Show("VS files aren't here. I will download the latest .exe version avaible.\nI will freeze for 1-2 minutes,\nSorry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DownloadExes();
                    MessageBox.Show("Download Completed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    Log(ex);
                    if(ex is UnauthorizedAccessException || ex is IOException)
                    {
                        MessageBox.Show("Access Denied. Retry running as Admin", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex is WebException)
                    {
                        MessageBox.Show("Download Error. Check Network", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                    
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        private void Log(Exception ex)
        {
            File.WriteAllText(CurrentPath + "\\log.txt", ex.ToString());
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

        public void CheckForUpdate(Boolean visual, String currver)
        {
            String ver = "";
            try
            {
                ver = webby.DownloadString(DataContainer.GetLinkResouce("onlinever"));
                if (!ver.Equals(currver))
                {
                    if(MessageBox.Show("There is a update avaible!\nDo you want to open the topic?", "Check for Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(DataContainer.GetLinkResouce("forum"));
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
            catch (WebException wex)
            {
                Log(wex);
                if(visual)
                {
                    MessageBox.Show("Network unavaible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public String GetArgs(int componentaction)
        {
            String args = "--layout \"" + SaveTo + "\"";
            if (SelWorkload.Count > 0 && SelWorkload.Count < 17)
            {
                String workarg = "";
                foreach (String s in SelWorkload)
                {
                    workarg = workarg + " " + "--add " + DataContainer.GetWorkload_prefix() + s;
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
            if (componentaction == 0)
            {
                return args;
            }
            else
            {
                return (args + " " + DataContainer.GetData("Components")[componentaction,1]);
            }
        }

        public int GetID()
        {
            return EdID;
        }

        public String[] GetPaths()
        {
            return Paths;
        }

        public void setSaveTo(String folder)
        {
            SaveTo = folder;
        }
        
        public String getSaveTo()
        {
            return SaveTo;
        }

        public void InstallCerts()
        {
            try
            {
                string[] certs = Directory.GetFiles(SaveTo + "\\certificates");
                if (certs.Length == 0)
                {
                    MessageBox.Show("No certificates inside folder... Wrong Folder or Layout corrupted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (String cert in certs)
                    {
                        var x = System.Diagnostics.Process.Start(cert);
                        x.WaitForExit();
                    }
                    MessageBox.Show("Installation Completed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Can't find or unable to access to certificates' folder. Retry running as Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveTo = "";
        }
    }
}
