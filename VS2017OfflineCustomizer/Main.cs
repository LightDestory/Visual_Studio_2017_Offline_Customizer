using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2017OfflineCustomizer
{
    public partial class Main : Form
    {
        Customizer c;
        public Main()
        {
            InitializeComponent();
            c = new Customizer(Application.StartupPath);
            LoadUI();
        }

        private void LoadUI()
        {
            for(int i = 0; i<c.Data.getData("files").GetLength(0); i++)
            {
                EdList.Items.Add(c.Data.getData("files")[i, 0].Replace("vs_", "").Replace(".exe", ""));

            }
            EdList.SelectedIndex = 0;
            for (int i = 0; i < c.Data.getData("Language").GetLength(0); i++)
            {
                LangList.Items.Add(c.Data.getData("Language")[i, 0] + " (" + c.Data.getData("Language")[i, 1] + ")");
            }
            LangList.SelectedIndex = 0;
            for (int i = 0; i < c.Data.getData("Workload").GetLength(0); i++)
            {
                WorkList.Items.Add(c.Data.getData("Workload")[i, 0].Replace("Microsoft.VisualStudio.Workload.", ""));
            }
            WorkList.SelectedIndex = 0;
        }

        private void LangSelBtn_Click(object sender, EventArgs e)
        {
            c.AddRemoveID(c.Data.getData("Language")[LangList.SelectedIndex, 0], c.SelLang);
            UpdateUI(CurrLang, c.SelLang);
        }

        private void UpdateUI(Label component, List<String> data)
        {
            String newtext = "";
            foreach(String c in data)
            {
                newtext = newtext + ", " + c;
            }
            component.Text = newtext;
        }

        private void WorkSelBtn_Click(object sender, EventArgs e)
        {
            c.AddRemoveID(c.Data.getData("Workload")[WorkList.SelectedIndex, 0], c.SelWorkload);
            UpdateUI(CurrWork, c.SelWorkload);
        }

        private void WorkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desc.Text = c.Data.getData("Workload")[WorkList.SelectedIndex, 1];
        }

        private void EdSelBtn_Click(object sender, EventArgs e)
        {
            if (!c.PreInit(EdList.SelectedItem.ToString()))
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
                String args = c.GetArgs(FolderSel.SelectedPath);
                Process.Start(c.Paths[c.EdID],args);
                LangSel.Enabled = false;
                WorkSel.Enabled = false;
                StartBtn.Enabled = false;
            }
        }
    }
}
