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
            LoadUI();
        }

        private void LoadUI()
        {
            for(int i = 0; i< Customizer.Data.getData("files").GetLength(0); i++)
            {
                EdList.Items.Add(Customizer.Data.getData("files")[i, 0].Replace("vs_", "").Replace(".exe", ""));

            }
            EdList.SelectedIndex = 0;
            for (int i = 0; i < Customizer.Data.getData("Language").GetLength(0); i++)
            {
                LangList.Items.Add(Customizer.Data.getData("Language")[i, 0] + " (" + Customizer.Data.getData("Language")[i, 1] + ")");
            }
            LangList.SelectedIndex = 0;
            for (int i = 0; i < Customizer.Data.getData("Workload").GetLength(0); i++)
            {
                WorkList.Items.Add(Customizer.Data.getData("Workload")[i, 0].Replace("Microsoft.VisualStudio.Workload.", ""));
            }
            WorkList.SelectedIndex = 0;
        }

        private void LangSelBtn_Click(object sender, EventArgs e)
        {
            Customizer.AddRemoveID(Customizer.Data.getData("Language")[LangList.SelectedIndex, 0], Customizer.SelLang);
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
            Customizer.AddRemoveID(Customizer.Data.getData("Workload")[WorkList.SelectedIndex, 0], Customizer.SelWorkload);
            UpdateUI(CurrWork, Customizer.SelWorkload);
        }

        private void WorkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desc.Text = Customizer.Data.getData("Workload")[WorkList.SelectedIndex, 1];
        }

        private void EdSelBtn_Click(object sender, EventArgs e)
        {
            if (!Customizer.PreInit(EdList.SelectedItem.ToString()))
            {
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
                Process.Start(Customizer.Paths[Customizer.EdID],args);
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
            MessageBox.Show(Application.ProductVersion);
        }
    }
}
