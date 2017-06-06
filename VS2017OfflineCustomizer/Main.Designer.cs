namespace VS2017OfflineCustomizer
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.EdSelBtn = new System.Windows.Forms.Button();
            this.EdSel = new System.Windows.Forms.GroupBox();
            this.CurrEd = new System.Windows.Forms.Label();
            this.CurrEdInfo = new System.Windows.Forms.Label();
            this.EditionInfo = new System.Windows.Forms.Label();
            this.EdList = new System.Windows.Forms.ComboBox();
            this.LangSel = new System.Windows.Forms.GroupBox();
            this.LangInfo = new System.Windows.Forms.Label();
            this.CurrLang = new System.Windows.Forms.Label();
            this.CurrLangInfo = new System.Windows.Forms.Label();
            this.LangSelBtn = new System.Windows.Forms.Button();
            this.LangList = new System.Windows.Forms.ComboBox();
            this.WorkSel = new System.Windows.Forms.GroupBox();
            this.CurrWork = new System.Windows.Forms.TextBox();
            this.WorkloadInfo = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.DescInfo = new System.Windows.Forms.Label();
            this.CurrWorkInfo = new System.Windows.Forms.Label();
            this.WorkSelBtn = new System.Windows.Forms.Button();
            this.WorkList = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FolderSel = new System.Windows.Forms.FolderBrowserDialog();
            this.TabbedMain = new System.Windows.Forms.TabControl();
            this.CreateTab = new System.Windows.Forms.TabPage();
            this.HowInstallTab = new System.Windows.Forms.TabPage();
            this.HowUpdateInfoPanel = new System.Windows.Forms.GroupBox();
            this.Updateinfo = new System.Windows.Forms.Label();
            this.OfflineInstallInfoPanel = new System.Windows.Forms.GroupBox();
            this.offinstallinfo = new System.Windows.Forms.Label();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.OpenWebBtn = new System.Windows.Forms.Button();
            this.OpenGitHub = new System.Windows.Forms.Button();
            this.CheckUpdateBtn = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.GroupBox();
            this.Dev = new System.Windows.Forms.Label();
            this.DevInfo = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Label();
            this.ProjectInfo = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.Label();
            this.CurrVerInfo = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            this.ComponentsInfo = new System.Windows.Forms.Label();
            this.ComponentAction = new System.Windows.Forms.ComboBox();
            this.EdSel.SuspendLayout();
            this.LangSel.SuspendLayout();
            this.WorkSel.SuspendLayout();
            this.TabbedMain.SuspendLayout();
            this.CreateTab.SuspendLayout();
            this.HowInstallTab.SuspendLayout();
            this.HowUpdateInfoPanel.SuspendLayout();
            this.OfflineInstallInfoPanel.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EdSelBtn
            // 
            this.EdSelBtn.BackColor = System.Drawing.Color.DimGray;
            this.EdSelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EdSelBtn.FlatAppearance.BorderSize = 2;
            this.EdSelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EdSelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EdSelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdSelBtn.ForeColor = System.Drawing.Color.White;
            this.EdSelBtn.Location = new System.Drawing.Point(232, 25);
            this.EdSelBtn.Name = "EdSelBtn";
            this.EdSelBtn.Size = new System.Drawing.Size(89, 29);
            this.EdSelBtn.TabIndex = 0;
            this.EdSelBtn.Text = "Select Edition";
            this.EdSelBtn.UseVisualStyleBackColor = false;
            this.EdSelBtn.Click += new System.EventHandler(this.EdSelBtn_Click);
            // 
            // EdSel
            // 
            this.EdSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.EdSel.Controls.Add(this.CurrEd);
            this.EdSel.Controls.Add(this.CurrEdInfo);
            this.EdSel.Controls.Add(this.EditionInfo);
            this.EdSel.Controls.Add(this.EdList);
            this.EdSel.Controls.Add(this.EdSelBtn);
            this.EdSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdSel.ForeColor = System.Drawing.Color.White;
            this.EdSel.Location = new System.Drawing.Point(10, 10);
            this.EdSel.Name = "EdSel";
            this.EdSel.Size = new System.Drawing.Size(333, 79);
            this.EdSel.TabIndex = 1;
            this.EdSel.TabStop = false;
            this.EdSel.Text = "Edition:";
            // 
            // CurrEd
            // 
            this.CurrEd.AutoSize = true;
            this.CurrEd.ForeColor = System.Drawing.Color.Red;
            this.CurrEd.Location = new System.Drawing.Point(100, 60);
            this.CurrEd.Name = "CurrEd";
            this.CurrEd.Size = new System.Drawing.Size(0, 13);
            this.CurrEd.TabIndex = 3;
            // 
            // CurrEdInfo
            // 
            this.CurrEdInfo.AutoSize = true;
            this.CurrEdInfo.Location = new System.Drawing.Point(10, 60);
            this.CurrEdInfo.Name = "CurrEdInfo";
            this.CurrEdInfo.Size = new System.Drawing.Size(87, 13);
            this.CurrEdInfo.TabIndex = 2;
            this.CurrEdInfo.Text = "Selected Edition:";
            // 
            // EditionInfo
            // 
            this.EditionInfo.AutoSize = true;
            this.EditionInfo.Location = new System.Drawing.Point(5, 15);
            this.EditionInfo.Name = "EditionInfo";
            this.EditionInfo.Size = new System.Drawing.Size(189, 13);
            this.EditionInfo.TabIndex = 1;
            this.EditionInfo.Text = "Please select the Visual Studio edition:";
            // 
            // EdList
            // 
            this.EdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EdList.FormattingEnabled = true;
            this.EdList.Location = new System.Drawing.Point(10, 35);
            this.EdList.Name = "EdList";
            this.EdList.Size = new System.Drawing.Size(184, 21);
            this.EdList.TabIndex = 0;
            // 
            // LangSel
            // 
            this.LangSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.LangSel.Controls.Add(this.LangInfo);
            this.LangSel.Controls.Add(this.CurrLang);
            this.LangSel.Controls.Add(this.CurrLangInfo);
            this.LangSel.Controls.Add(this.LangSelBtn);
            this.LangSel.Controls.Add(this.LangList);
            this.LangSel.Enabled = false;
            this.LangSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LangSel.ForeColor = System.Drawing.Color.White;
            this.LangSel.Location = new System.Drawing.Point(10, 89);
            this.LangSel.Name = "LangSel";
            this.LangSel.Size = new System.Drawing.Size(333, 116);
            this.LangSel.TabIndex = 2;
            this.LangSel.TabStop = false;
            this.LangSel.Text = "Language";
            // 
            // LangInfo
            // 
            this.LangInfo.AutoSize = true;
            this.LangInfo.Location = new System.Drawing.Point(5, 15);
            this.LangInfo.Name = "LangInfo";
            this.LangInfo.Size = new System.Drawing.Size(190, 13);
            this.LangInfo.TabIndex = 4;
            this.LangInfo.Text = "Please select your prefered languages:";
            // 
            // CurrLang
            // 
            this.CurrLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.CurrLang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurrLang.ForeColor = System.Drawing.Color.White;
            this.CurrLang.Location = new System.Drawing.Point(10, 77);
            this.CurrLang.Name = "CurrLang";
            this.CurrLang.Size = new System.Drawing.Size(311, 30);
            this.CurrLang.TabIndex = 3;
            // 
            // CurrLangInfo
            // 
            this.CurrLangInfo.AutoSize = true;
            this.CurrLangInfo.Location = new System.Drawing.Point(10, 60);
            this.CurrLangInfo.Name = "CurrLangInfo";
            this.CurrLangInfo.Size = new System.Drawing.Size(103, 13);
            this.CurrLangInfo.TabIndex = 2;
            this.CurrLangInfo.Text = "Selected Language:";
            // 
            // LangSelBtn
            // 
            this.LangSelBtn.BackColor = System.Drawing.Color.DimGray;
            this.LangSelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LangSelBtn.FlatAppearance.BorderSize = 2;
            this.LangSelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LangSelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LangSelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LangSelBtn.Location = new System.Drawing.Point(187, 35);
            this.LangSelBtn.Name = "LangSelBtn";
            this.LangSelBtn.Size = new System.Drawing.Size(134, 35);
            this.LangSelBtn.TabIndex = 1;
            this.LangSelBtn.Text = "Add/Remove Language";
            this.LangSelBtn.UseVisualStyleBackColor = false;
            this.LangSelBtn.Click += new System.EventHandler(this.LangSelBtn_Click);
            // 
            // LangList
            // 
            this.LangList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangList.FormattingEnabled = true;
            this.LangList.Location = new System.Drawing.Point(10, 35);
            this.LangList.Name = "LangList";
            this.LangList.Size = new System.Drawing.Size(151, 21);
            this.LangList.TabIndex = 0;
            // 
            // WorkSel
            // 
            this.WorkSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.WorkSel.Controls.Add(this.ComponentAction);
            this.WorkSel.Controls.Add(this.ComponentsInfo);
            this.WorkSel.Controls.Add(this.CurrWork);
            this.WorkSel.Controls.Add(this.WorkloadInfo);
            this.WorkSel.Controls.Add(this.Desc);
            this.WorkSel.Controls.Add(this.DescInfo);
            this.WorkSel.Controls.Add(this.CurrWorkInfo);
            this.WorkSel.Controls.Add(this.WorkSelBtn);
            this.WorkSel.Controls.Add(this.WorkList);
            this.WorkSel.Enabled = false;
            this.WorkSel.ForeColor = System.Drawing.Color.White;
            this.WorkSel.Location = new System.Drawing.Point(10, 205);
            this.WorkSel.Name = "WorkSel";
            this.WorkSel.Size = new System.Drawing.Size(333, 231);
            this.WorkSel.TabIndex = 4;
            this.WorkSel.TabStop = false;
            this.WorkSel.Text = "Workload";
            // 
            // CurrWork
            // 
            this.CurrWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.CurrWork.ForeColor = System.Drawing.Color.White;
            this.CurrWork.Location = new System.Drawing.Point(10, 141);
            this.CurrWork.Multiline = true;
            this.CurrWork.Name = "CurrWork";
            this.CurrWork.ReadOnly = true;
            this.CurrWork.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CurrWork.Size = new System.Drawing.Size(307, 42);
            this.CurrWork.TabIndex = 7;
            // 
            // WorkloadInfo
            // 
            this.WorkloadInfo.AutoSize = true;
            this.WorkloadInfo.Location = new System.Drawing.Point(5, 15);
            this.WorkloadInfo.Name = "WorkloadInfo";
            this.WorkloadInfo.Size = new System.Drawing.Size(192, 13);
            this.WorkloadInfo.TabIndex = 6;
            this.WorkloadInfo.Text = "Please select your prefered Workloads:";
            // 
            // Desc
            // 
            this.Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.Desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Desc.Location = new System.Drawing.Point(10, 77);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(307, 42);
            this.Desc.TabIndex = 5;
            // 
            // DescInfo
            // 
            this.DescInfo.AutoSize = true;
            this.DescInfo.Location = new System.Drawing.Point(10, 60);
            this.DescInfo.Name = "DescInfo";
            this.DescInfo.Size = new System.Drawing.Size(142, 13);
            this.DescInfo.TabIndex = 4;
            this.DescInfo.Text = "Description of the Workload:";
            // 
            // CurrWorkInfo
            // 
            this.CurrWorkInfo.AutoSize = true;
            this.CurrWorkInfo.Location = new System.Drawing.Point(10, 124);
            this.CurrWorkInfo.Name = "CurrWorkInfo";
            this.CurrWorkInfo.Size = new System.Drawing.Size(101, 13);
            this.CurrWorkInfo.TabIndex = 2;
            this.CurrWorkInfo.Text = "Selected Workload:";
            // 
            // WorkSelBtn
            // 
            this.WorkSelBtn.BackColor = System.Drawing.Color.DimGray;
            this.WorkSelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WorkSelBtn.FlatAppearance.BorderSize = 2;
            this.WorkSelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WorkSelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.WorkSelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkSelBtn.Location = new System.Drawing.Point(188, 31);
            this.WorkSelBtn.Name = "WorkSelBtn";
            this.WorkSelBtn.Size = new System.Drawing.Size(133, 35);
            this.WorkSelBtn.TabIndex = 1;
            this.WorkSelBtn.Text = "Add/Remove Workload";
            this.WorkSelBtn.UseVisualStyleBackColor = false;
            this.WorkSelBtn.Click += new System.EventHandler(this.WorkSelBtn_Click);
            // 
            // WorkList
            // 
            this.WorkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkList.FormattingEnabled = true;
            this.WorkList.Location = new System.Drawing.Point(10, 35);
            this.WorkList.Name = "WorkList";
            this.WorkList.Size = new System.Drawing.Size(151, 21);
            this.WorkList.TabIndex = 0;
            this.WorkList.SelectedIndexChanged += new System.EventHandler(this.WorkList_SelectedIndexChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.StartBtn.Enabled = false;
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StartBtn.FlatAppearance.BorderSize = 2;
            this.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(10, 442);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(333, 34);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start Process";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // FolderSel
            // 
            this.FolderSel.Description = "Select the folder where download VS. Suggestion: C:\\vs_2017";
            // 
            // TabbedMain
            // 
            this.TabbedMain.Controls.Add(this.CreateTab);
            this.TabbedMain.Controls.Add(this.HowInstallTab);
            this.TabbedMain.Controls.Add(this.InfoTab);
            this.TabbedMain.HotTrack = true;
            this.TabbedMain.ItemSize = new System.Drawing.Size(80, 18);
            this.TabbedMain.Location = new System.Drawing.Point(10, 146);
            this.TabbedMain.Name = "TabbedMain";
            this.TabbedMain.SelectedIndex = 0;
            this.TabbedMain.Size = new System.Drawing.Size(361, 508);
            this.TabbedMain.TabIndex = 7;
            // 
            // CreateTab
            // 
            this.CreateTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CreateTab.Controls.Add(this.EdSel);
            this.CreateTab.Controls.Add(this.LangSel);
            this.CreateTab.Controls.Add(this.WorkSel);
            this.CreateTab.Controls.Add(this.StartBtn);
            this.CreateTab.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateTab.Location = new System.Drawing.Point(4, 22);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTab.Size = new System.Drawing.Size(353, 482);
            this.CreateTab.TabIndex = 0;
            this.CreateTab.Text = "Create";
            // 
            // HowInstallTab
            // 
            this.HowInstallTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.HowInstallTab.Controls.Add(this.HowUpdateInfoPanel);
            this.HowInstallTab.Controls.Add(this.OfflineInstallInfoPanel);
            this.HowInstallTab.Location = new System.Drawing.Point(4, 22);
            this.HowInstallTab.Name = "HowInstallTab";
            this.HowInstallTab.Size = new System.Drawing.Size(353, 482);
            this.HowInstallTab.TabIndex = 2;
            this.HowInstallTab.Text = "Guides";
            // 
            // HowUpdateInfoPanel
            // 
            this.HowUpdateInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.HowUpdateInfoPanel.Controls.Add(this.Updateinfo);
            this.HowUpdateInfoPanel.ForeColor = System.Drawing.Color.White;
            this.HowUpdateInfoPanel.Location = new System.Drawing.Point(10, 82);
            this.HowUpdateInfoPanel.Name = "HowUpdateInfoPanel";
            this.HowUpdateInfoPanel.Size = new System.Drawing.Size(333, 64);
            this.HowUpdateInfoPanel.TabIndex = 1;
            this.HowUpdateInfoPanel.TabStop = false;
            this.HowUpdateInfoPanel.Text = "How Update a Layout";
            // 
            // Updateinfo
            // 
            this.Updateinfo.AutoSize = true;
            this.Updateinfo.Location = new System.Drawing.Point(10, 20);
            this.Updateinfo.MaximumSize = new System.Drawing.Size(313, 40);
            this.Updateinfo.Name = "Updateinfo";
            this.Updateinfo.Size = new System.Drawing.Size(291, 26);
            this.Updateinfo.TabIndex = 0;
            this.Updateinfo.Text = "1) Select the same edition of your current layout\r\n2) Press \'Start Process\' and p" +
    "oint the folder of existent layout";
            // 
            // OfflineInstallInfoPanel
            // 
            this.OfflineInstallInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.OfflineInstallInfoPanel.Controls.Add(this.offinstallinfo);
            this.OfflineInstallInfoPanel.ForeColor = System.Drawing.Color.White;
            this.OfflineInstallInfoPanel.Location = new System.Drawing.Point(10, 10);
            this.OfflineInstallInfoPanel.Name = "OfflineInstallInfoPanel";
            this.OfflineInstallInfoPanel.Size = new System.Drawing.Size(333, 72);
            this.OfflineInstallInfoPanel.TabIndex = 0;
            this.OfflineInstallInfoPanel.TabStop = false;
            this.OfflineInstallInfoPanel.Text = "How Install from Offline Layout";
            // 
            // offinstallinfo
            // 
            this.offinstallinfo.AutoSize = true;
            this.offinstallinfo.Location = new System.Drawing.Point(10, 20);
            this.offinstallinfo.MaximumSize = new System.Drawing.Size(313, 40);
            this.offinstallinfo.Name = "offinstallinfo";
            this.offinstallinfo.Size = new System.Drawing.Size(297, 39);
            this.offinstallinfo.TabIndex = 0;
            this.offinstallinfo.Text = "1) Install certificates from \'certificates\' folder inside your layout folder\r\n2) " +
    "Run vs_EDITION.exe";
            // 
            // InfoTab
            // 
            this.InfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.InfoTab.Controls.Add(this.OpenWebBtn);
            this.InfoTab.Controls.Add(this.OpenGitHub);
            this.InfoTab.Controls.Add(this.CheckUpdateBtn);
            this.InfoTab.Controls.Add(this.InfoPanel);
            this.InfoTab.Location = new System.Drawing.Point(4, 22);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(353, 482);
            this.InfoTab.TabIndex = 1;
            this.InfoTab.Text = "Info";
            // 
            // OpenWebBtn
            // 
            this.OpenWebBtn.BackColor = System.Drawing.Color.DimGray;
            this.OpenWebBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenWebBtn.FlatAppearance.BorderSize = 2;
            this.OpenWebBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenWebBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OpenWebBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenWebBtn.ForeColor = System.Drawing.Color.White;
            this.OpenWebBtn.Location = new System.Drawing.Point(10, 329);
            this.OpenWebBtn.Name = "OpenWebBtn";
            this.OpenWebBtn.Size = new System.Drawing.Size(337, 33);
            this.OpenWebBtn.TabIndex = 3;
            this.OpenWebBtn.Text = "Open My Website";
            this.OpenWebBtn.UseVisualStyleBackColor = false;
            this.OpenWebBtn.Click += new System.EventHandler(this.OpenWeb_Click);
            // 
            // OpenGitHub
            // 
            this.OpenGitHub.BackColor = System.Drawing.Color.DimGray;
            this.OpenGitHub.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenGitHub.FlatAppearance.BorderSize = 2;
            this.OpenGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OpenGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenGitHub.ForeColor = System.Drawing.Color.White;
            this.OpenGitHub.Location = new System.Drawing.Point(10, 368);
            this.OpenGitHub.Name = "OpenGitHub";
            this.OpenGitHub.Size = new System.Drawing.Size(337, 33);
            this.OpenGitHub.TabIndex = 2;
            this.OpenGitHub.Text = "Open GitHub\'s Page";
            this.OpenGitHub.UseVisualStyleBackColor = false;
            this.OpenGitHub.Click += new System.EventHandler(this.OpenGitHub_Click);
            // 
            // CheckUpdateBtn
            // 
            this.CheckUpdateBtn.BackColor = System.Drawing.Color.DimGray;
            this.CheckUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckUpdateBtn.FlatAppearance.BorderSize = 2;
            this.CheckUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CheckUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.CheckUpdateBtn.Location = new System.Drawing.Point(10, 407);
            this.CheckUpdateBtn.Name = "CheckUpdateBtn";
            this.CheckUpdateBtn.Size = new System.Drawing.Size(337, 33);
            this.CheckUpdateBtn.TabIndex = 1;
            this.CheckUpdateBtn.Text = "Check for Updates";
            this.CheckUpdateBtn.UseVisualStyleBackColor = false;
            this.CheckUpdateBtn.Click += new System.EventHandler(this.CheckUpdateBtn_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.Dev);
            this.InfoPanel.Controls.Add(this.DevInfo);
            this.InfoPanel.Controls.Add(this.project);
            this.InfoPanel.Controls.Add(this.ProjectInfo);
            this.InfoPanel.Controls.Add(this.ver);
            this.InfoPanel.Controls.Add(this.CurrVerInfo);
            this.InfoPanel.ForeColor = System.Drawing.Color.White;
            this.InfoPanel.Location = new System.Drawing.Point(10, 16);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(337, 111);
            this.InfoPanel.TabIndex = 0;
            this.InfoPanel.TabStop = false;
            this.InfoPanel.Text = "About";
            // 
            // Dev
            // 
            this.Dev.AutoSize = true;
            this.Dev.Location = new System.Drawing.Point(94, 55);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(66, 13);
            this.Dev.TabIndex = 5;
            this.Dev.Text = "LightDestory";
            // 
            // DevInfo
            // 
            this.DevInfo.AutoSize = true;
            this.DevInfo.Location = new System.Drawing.Point(12, 55);
            this.DevInfo.Name = "DevInfo";
            this.DevInfo.Size = new System.Drawing.Size(59, 13);
            this.DevInfo.TabIndex = 4;
            this.DevInfo.Text = "Developer:";
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Location = new System.Drawing.Point(94, 26);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(214, 13);
            this.project.TabIndex = 3;
            this.project.Text = "Visual Studio 2017 Offline Layout Customize";
            // 
            // ProjectInfo
            // 
            this.ProjectInfo.AutoSize = true;
            this.ProjectInfo.Location = new System.Drawing.Point(12, 26);
            this.ProjectInfo.Name = "ProjectInfo";
            this.ProjectInfo.Size = new System.Drawing.Size(43, 13);
            this.ProjectInfo.TabIndex = 2;
            this.ProjectInfo.Text = "Project:";
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Location = new System.Drawing.Point(94, 85);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(0, 13);
            this.ver.TabIndex = 1;
            // 
            // CurrVerInfo
            // 
            this.CurrVerInfo.AutoSize = true;
            this.CurrVerInfo.Location = new System.Drawing.Point(12, 85);
            this.CurrVerInfo.Name = "CurrVerInfo";
            this.CurrVerInfo.Size = new System.Drawing.Size(82, 13);
            this.CurrVerInfo.TabIndex = 0;
            this.CurrVerInfo.Text = "Current Version:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderSize = 2;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(316, 20);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 23);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HomeImage
            // 
            this.HomeImage.BackColor = System.Drawing.Color.White;
            this.HomeImage.Image = global::VS2017OfflineCustomizer.Properties.Resources.VSCustomizerHome;
            this.HomeImage.InitialImage = global::VS2017OfflineCustomizer.Properties.Resources.VSCustomizerHome;
            this.HomeImage.Location = new System.Drawing.Point(10, 10);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(361, 130);
            this.HomeImage.TabIndex = 6;
            this.HomeImage.TabStop = false;
            // 
            // ComponentsInfo
            // 
            this.ComponentsInfo.AutoSize = true;
            this.ComponentsInfo.Location = new System.Drawing.Point(7, 188);
            this.ComponentsInfo.Name = "ComponentsInfo";
            this.ComponentsInfo.Size = new System.Drawing.Size(146, 13);
            this.ComponentsInfo.TabIndex = 9;
            this.ComponentsInfo.Text = "Select Additional Component:";
            // 
            // ComponentAction
            // 
            this.ComponentAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComponentAction.FormattingEnabled = true;
            this.ComponentAction.Location = new System.Drawing.Point(8, 204);
            this.ComponentAction.Name = "ComponentAction";
            this.ComponentAction.Size = new System.Drawing.Size(153, 21);
            this.ComponentAction.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(381, 666);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TabbedMain);
            this.Controls.Add(this.HomeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Studio 2017 Offline Layout Customizer FIRST RELEASE";
            this.EdSel.ResumeLayout(false);
            this.EdSel.PerformLayout();
            this.LangSel.ResumeLayout(false);
            this.LangSel.PerformLayout();
            this.WorkSel.ResumeLayout(false);
            this.WorkSel.PerformLayout();
            this.TabbedMain.ResumeLayout(false);
            this.CreateTab.ResumeLayout(false);
            this.HowInstallTab.ResumeLayout(false);
            this.HowUpdateInfoPanel.ResumeLayout(false);
            this.HowUpdateInfoPanel.PerformLayout();
            this.OfflineInstallInfoPanel.ResumeLayout(false);
            this.OfflineInstallInfoPanel.PerformLayout();
            this.InfoTab.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EdSelBtn;
        private System.Windows.Forms.GroupBox EdSel;
        private System.Windows.Forms.ComboBox EdList;
        private System.Windows.Forms.GroupBox LangSel;
        private System.Windows.Forms.ComboBox LangList;
        private System.Windows.Forms.Label CurrLang;
        private System.Windows.Forms.Label CurrLangInfo;
        private System.Windows.Forms.Button LangSelBtn;
        private System.Windows.Forms.GroupBox WorkSel;
        private System.Windows.Forms.Label CurrWorkInfo;
        private System.Windows.Forms.Button WorkSelBtn;
        private System.Windows.Forms.ComboBox WorkList;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label DescInfo;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.FolderBrowserDialog FolderSel;
        private System.Windows.Forms.Label EditionInfo;
        private System.Windows.Forms.PictureBox HomeImage;
        private System.Windows.Forms.TabControl TabbedMain;
        private System.Windows.Forms.TabPage CreateTab;
        private System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.Label LangInfo;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label WorkloadInfo;
        private System.Windows.Forms.Button CheckUpdateBtn;
        private System.Windows.Forms.GroupBox InfoPanel;
        private System.Windows.Forms.Label ver;
        private System.Windows.Forms.Label CurrVerInfo;
        private System.Windows.Forms.Label Dev;
        private System.Windows.Forms.Label DevInfo;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.Label ProjectInfo;
        private System.Windows.Forms.Button OpenGitHub;
        private System.Windows.Forms.Button OpenWebBtn;
        private System.Windows.Forms.TextBox CurrWork;
        private System.Windows.Forms.Label CurrEd;
        private System.Windows.Forms.Label CurrEdInfo;
        private System.Windows.Forms.TabPage HowInstallTab;
        private System.Windows.Forms.GroupBox HowUpdateInfoPanel;
        private System.Windows.Forms.Label Updateinfo;
        private System.Windows.Forms.GroupBox OfflineInstallInfoPanel;
        private System.Windows.Forms.Label offinstallinfo;
        private System.Windows.Forms.ComboBox ComponentAction;
        private System.Windows.Forms.Label ComponentsInfo;
    }
}

