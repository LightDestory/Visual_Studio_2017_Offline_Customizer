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
            for(int i = 0; i< Customizer.GetData().getData("files").GetLength(0); i++)
            {
                EdList.Items.Add(Customizer.GetData().getData("files")[i, 0].Replace("vs_", "").Replace(".exe", ""));

            }
            EdList.SelectedIndex = 0;
            for (int i = 0; i < Customizer.GetData().getData("Language").GetLength(0); i++)
            {
                LangList.Items.Add(Customizer.GetData().getData("Language")[i, 0] + " (" + Customizer.GetData().getData("Language")[i, 1] + ")");
            }
            LangList.SelectedIndex = 0;
            for (int i = 0; i < Customizer.GetData().getData("Workload").GetLength(0); i++)
            {
                WorkList.Items.Add(Customizer.GetData().getData("Workload")[i, 0]);
            }
            WorkList.SelectedIndex = 0;
        }

        private void LangSelBtn_Click(object sender, EventArgs e)
        {
            Customizer.AddRemoveID(Customizer.GetData().getData("Language")[LangList.SelectedIndex, 0], Customizer.SelLang);
            UpdateUI(CurrLang, Customizer.SelLang);
        }

        private void UpdateUI(Label component, List<String> data)
        {
            String newtext = "";
            foreach(String c in data)
            {
                if(newtext == "")
                {
                    newtext = c;
                }
                else
                {
                    newtext = newtext + ", " + c;
                }
            }
            component.Text = newtext;
        }

        private void WorkSelBtn_Click(object sender, EventArgs e)
        {
            Customizer.AddRemoveID(Customizer.GetData().getData("Workload")[WorkList.SelectedIndex, 0], Customizer.SelWorkload);
            UpdateUI(CurrWork, Customizer.SelWorkload);
        }

        private void WorkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desc.Text = Customizer.GetData().getData("Workload")[WorkList.SelectedIndex, 1];
        }

        private void EdSelBtn_Click(object sender, EventArgs e)
        {
            if (!Customizer.PreInit(EdList.SelectedItem.ToString()))
            {
                MessageBox.Show("Unable to complete \"rReInit\".\nClosing...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                EdSel.Enabled = false;
                LangSel.Enabled = true;
                WorkSel.Enabled = true;
                StartBtn.Enabled = true;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(FolderSel.ShowDialog()!= DialogResult.Cancel)
            {
                String args = Customizer.GetArgs(FolderSel.SelectedPath);
                Process.Start(Customizer.GetPaths()[Customizer.GetID()],args);
                LangSel.Enabled = false;
                WorkSel.Enabled = false;
                StartBtn.Enabled = false;
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
            Process.Start(Customizer.GetData().GetGitHub());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(Customizer.GetData().GetMyWebsite());
        }
    }
}
