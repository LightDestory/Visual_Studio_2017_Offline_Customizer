using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace VS2017OfflineCustomizer
{
    public partial class Main : Form
    {
        Customizer Customizer;

        public Main()
        {
            InitializeComponent();
            Customizer = new Customizer(Application.StartupPath);
            Customizer.CheckForUpdate(false, Application.ProductVersion);
            LoadUI();
        }

        private void LoadUI()
        {
            ver.Text = Application.ProductVersion;
            for(int i = 0; i< DataContainer.GetData("files").GetLength(0); i++)
            {
                EdList.Items.Add(DataContainer.GetData("files")[i, 0].Replace("vs_", "").Replace(".exe", ""));

            }
            for (int i = 0; i < DataContainer.GetData("Language").GetLength(0); i++)
            {
                LangList.Items.Add(DataContainer.GetData("Language")[i, 0] + " (" + DataContainer.GetData("Language")[i, 1] + ")");
            }
            for (int i = 0; i < DataContainer.GetData("Workload").GetLength(0); i++)
            {
                WorkList.Items.Add(DataContainer.GetData("Workload")[i, 0]);
            }
            for (int i = 0; i < DataContainer.GetData("Components").GetLength(0); i++)
            {
                ComponentAction.Items.Add(DataContainer.GetData("Components")[i, 0]);
            }
            EdList.SelectedIndex = 0;
            LangList.SelectedIndex = 0;
            WorkList.SelectedIndex = 0;
            ComponentAction.SelectedIndex = 0;
        }

        private void LangSelBtn_Click(object sender, EventArgs e)
        {
            Customizer.AddRemoveID(DataContainer.GetData("Language")[LangList.SelectedIndex, 0], Customizer.SelLang);
            CurrLang.Text = UpdateUI(Customizer.SelLang);
        }

        private String UpdateUI(List<String> data)
        {
            String text = "";
            foreach(String c in data)
            {
                if(text == "")
                {
                    text = c;
                }
                else
                {
                    text = text + ", " + c;
                }
            }
            return text;
        }

        private void WorkSelBtn_Click(object sender, EventArgs e)
        {
            Customizer.AddRemoveID(DataContainer.GetData("Workload")[WorkList.SelectedIndex, 0], Customizer.SelWorkload);
            CurrWork.Text = UpdateUI(Customizer.SelWorkload);
        }

        private void WorkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desc.Text = DataContainer.GetData("Workload")[WorkList.SelectedIndex, 1];
        }

        private void EdSelBtn_Click(object sender, EventArgs e)
        {
            if (!Customizer.PreInit())
            {
                MessageBox.Show("Unable to complete \"PreInit\".\nClosing...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                LangSel.Enabled = true;
                WorkSel.Enabled = true;
                StartBtn.Enabled = true;
                CurrEd.Text = Customizer.SelectEdition(EdList.SelectedItem.ToString());
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(FolderSel.ShowDialog()!= DialogResult.Cancel)
            {
                Customizer.setSaveTo(FolderSel.SelectedPath);
                String args = Customizer.GetArgs(ComponentAction.SelectedIndex);
                Process.Start(Customizer.GetPaths()[Customizer.GetID()],args);
                EdSel.Enabled = false;
                LangSel.Enabled = false;
                WorkSel.Enabled = false;
                StartBtn.Enabled = false;
                MessageBox.Show("Visual Studio Installation successfully runned. You can close me!\nIf after bootstrapper doesn't show up nothing (like a cmd window) please Contact me!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using my app!\r\n- LightDestory", "Good Bye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void CheckUpdateBtn_Click(object sender, EventArgs e)
        {
            Customizer.CheckForUpdate(true, Application.ProductVersion);
        }

        private void OpenGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(DataContainer.GetLinkResouce("github"));
        }

        private void OpenWeb_Click(object sender, EventArgs e)
        {
            Process.Start(DataContainer.GetLinkResouce("website"));
        }

        private void installcert_Click(object sender, EventArgs e)
        {
            if (Customizer.getSaveTo().Equals(""))
            {
                if (FolderSel.ShowDialog()!= DialogResult.Cancel)
                {
                    Customizer.setSaveTo(FolderSel.SelectedPath);
                    Customizer.InstallCerts();
                }
            }
            else
            {
                Customizer.InstallCerts();
            }
        }
    }
}
