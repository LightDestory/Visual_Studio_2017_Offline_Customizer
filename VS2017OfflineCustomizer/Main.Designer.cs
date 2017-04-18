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
            this.EdSelBtn = new System.Windows.Forms.Button();
            this.EdSel = new System.Windows.Forms.GroupBox();
            this.EditionInfo = new System.Windows.Forms.Label();
            this.EdList = new System.Windows.Forms.ComboBox();
            this.LangSel = new System.Windows.Forms.GroupBox();
            this.LangInfo = new System.Windows.Forms.Label();
            this.CurrLang = new System.Windows.Forms.Label();
            this.CurrLangInfo = new System.Windows.Forms.Label();
            this.LangSelBtn = new System.Windows.Forms.Button();
            this.LangList = new System.Windows.Forms.ComboBox();
            this.WorkSel = new System.Windows.Forms.GroupBox();
            this.WorkloadInfo = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.DescInfo = new System.Windows.Forms.Label();
            this.CurrWork = new System.Windows.Forms.Label();
            this.CurrWorkInfo = new System.Windows.Forms.Label();
            this.WorkSelBtn = new System.Windows.Forms.Button();
            this.WorkList = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FolderSel = new System.Windows.Forms.FolderBrowserDialog();
            this.TabbedMain = new System.Windows.Forms.TabControl();
            this.CreateTab = new System.Windows.Forms.TabPage();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.GroupBox();
            this.CheckUpdateBtn = new System.Windows.Forms.Button();
            this.EdSel.SuspendLayout();
            this.LangSel.SuspendLayout();
            this.WorkSel.SuspendLayout();
            this.TabbedMain.SuspendLayout();
            this.CreateTab.SuspendLayout();
            this.InfoTab.SuspendLayout();
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
            this.EdSelBtn.Location = new System.Drawing.Point(304, 31);
            this.EdSelBtn.Name = "EdSelBtn";
            this.EdSelBtn.Size = new System.Drawing.Size(143, 35);
            this.EdSelBtn.TabIndex = 0;
            this.EdSelBtn.Text = "Select Edition";
            this.EdSelBtn.UseVisualStyleBackColor = false;
            this.EdSelBtn.Click += new System.EventHandler(this.EdSelBtn_Click);
            // 
            // EdSel
            // 
            this.EdSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.EdSel.Controls.Add(this.EditionInfo);
            this.EdSel.Controls.Add(this.EdList);
            this.EdSel.Controls.Add(this.EdSelBtn);
            this.EdSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdSel.ForeColor = System.Drawing.Color.White;
            this.EdSel.Location = new System.Drawing.Point(10, 15);
            this.EdSel.Name = "EdSel";
            this.EdSel.Size = new System.Drawing.Size(470, 84);
            this.EdSel.TabIndex = 1;
            this.EdSel.TabStop = false;
            this.EdSel.Text = "Edition:";
            // 
            // EditionInfo
            // 
            this.EditionInfo.AutoSize = true;
            this.EditionInfo.Location = new System.Drawing.Point(7, 20);
            this.EditionInfo.Name = "EditionInfo";
            this.EditionInfo.Size = new System.Drawing.Size(189, 13);
            this.EditionInfo.TabIndex = 1;
            this.EditionInfo.Text = "Please select the Visual Studio edition:";
            // 
            // EdList
            // 
            this.EdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EdList.FormattingEnabled = true;
            this.EdList.Location = new System.Drawing.Point(22, 39);
            this.EdList.Name = "EdList";
            this.EdList.Size = new System.Drawing.Size(201, 21);
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
            this.LangSel.Location = new System.Drawing.Point(10, 105);
            this.LangSel.Name = "LangSel";
            this.LangSel.Size = new System.Drawing.Size(470, 149);
            this.LangSel.TabIndex = 2;
            this.LangSel.TabStop = false;
            this.LangSel.Text = "Language";
            // 
            // LangInfo
            // 
            this.LangInfo.AutoSize = true;
            this.LangInfo.Location = new System.Drawing.Point(9, 25);
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
            this.CurrLang.Location = new System.Drawing.Point(34, 91);
            this.CurrLang.Name = "CurrLang";
            this.CurrLang.Size = new System.Drawing.Size(400, 40);
            this.CurrLang.TabIndex = 3;
            // 
            // CurrLangInfo
            // 
            this.CurrLangInfo.AutoSize = true;
            this.CurrLangInfo.Location = new System.Drawing.Point(19, 69);
            this.CurrLangInfo.Name = "CurrLangInfo";
            this.CurrLangInfo.Size = new System.Drawing.Size(140, 13);
            this.CurrLangInfo.TabIndex = 2;
            this.CurrLangInfo.Text = "Current Selected Language:";
            // 
            // LangSelBtn
            // 
            this.LangSelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LangSelBtn.FlatAppearance.BorderSize = 2;
            this.LangSelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LangSelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.LangSelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LangSelBtn.Location = new System.Drawing.Point(304, 37);
            this.LangSelBtn.Name = "LangSelBtn";
            this.LangSelBtn.Size = new System.Drawing.Size(143, 35);
            this.LangSelBtn.TabIndex = 1;
            this.LangSelBtn.Text = "Add/Remove Language";
            this.LangSelBtn.UseVisualStyleBackColor = true;
            this.LangSelBtn.Click += new System.EventHandler(this.LangSelBtn_Click);
            // 
            // LangList
            // 
            this.LangList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangList.FormattingEnabled = true;
            this.LangList.Location = new System.Drawing.Point(22, 45);
            this.LangList.Name = "LangList";
            this.LangList.Size = new System.Drawing.Size(241, 21);
            this.LangList.TabIndex = 0;
            // 
            // WorkSel
            // 
            this.WorkSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.WorkSel.Controls.Add(this.WorkloadInfo);
            this.WorkSel.Controls.Add(this.Desc);
            this.WorkSel.Controls.Add(this.DescInfo);
            this.WorkSel.Controls.Add(this.CurrWork);
            this.WorkSel.Controls.Add(this.CurrWorkInfo);
            this.WorkSel.Controls.Add(this.WorkSelBtn);
            this.WorkSel.Controls.Add(this.WorkList);
            this.WorkSel.Enabled = false;
            this.WorkSel.ForeColor = System.Drawing.Color.White;
            this.WorkSel.Location = new System.Drawing.Point(10, 260);
            this.WorkSel.Name = "WorkSel";
            this.WorkSel.Size = new System.Drawing.Size(470, 219);
            this.WorkSel.TabIndex = 4;
            this.WorkSel.TabStop = false;
            this.WorkSel.Text = "Workload";
            // 
            // WorkloadInfo
            // 
            this.WorkloadInfo.AutoSize = true;
            this.WorkloadInfo.Location = new System.Drawing.Point(10, 20);
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
            this.Desc.Location = new System.Drawing.Point(31, 93);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(400, 40);
            this.Desc.TabIndex = 5;
            // 
            // DescInfo
            // 
            this.DescInfo.AutoSize = true;
            this.DescInfo.Location = new System.Drawing.Point(19, 68);
            this.DescInfo.Name = "DescInfo";
            this.DescInfo.Size = new System.Drawing.Size(142, 13);
            this.DescInfo.TabIndex = 4;
            this.DescInfo.Text = "Description of the Workload:";
            // 
            // CurrWork
            // 
            this.CurrWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.CurrWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CurrWork.Location = new System.Drawing.Point(31, 164);
            this.CurrWork.Name = "CurrWork";
            this.CurrWork.Size = new System.Drawing.Size(400, 40);
            this.CurrWork.TabIndex = 3;
            // 
            // CurrWorkInfo
            // 
            this.CurrWorkInfo.AutoSize = true;
            this.CurrWorkInfo.Location = new System.Drawing.Point(19, 141);
            this.CurrWorkInfo.Name = "CurrWorkInfo";
            this.CurrWorkInfo.Size = new System.Drawing.Size(138, 13);
            this.CurrWorkInfo.TabIndex = 2;
            this.CurrWorkInfo.Text = "Current Selected Workload:";
            // 
            // WorkSelBtn
            // 
            this.WorkSelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WorkSelBtn.FlatAppearance.BorderSize = 2;
            this.WorkSelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WorkSelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.WorkSelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkSelBtn.Location = new System.Drawing.Point(304, 36);
            this.WorkSelBtn.Name = "WorkSelBtn";
            this.WorkSelBtn.Size = new System.Drawing.Size(143, 35);
            this.WorkSelBtn.TabIndex = 1;
            this.WorkSelBtn.Text = "Add/Remove Workload";
            this.WorkSelBtn.UseVisualStyleBackColor = true;
            this.WorkSelBtn.Click += new System.EventHandler(this.WorkSelBtn_Click);
            // 
            // WorkList
            // 
            this.WorkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkList.FormattingEnabled = true;
            this.WorkList.Location = new System.Drawing.Point(22, 44);
            this.WorkList.Name = "WorkList";
            this.WorkList.Size = new System.Drawing.Size(241, 21);
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
            this.StartBtn.Location = new System.Drawing.Point(23, 485);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(444, 34);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start Process";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // FolderSel
            // 
            this.FolderSel.Description = "Select the folder where download VS. Foldername without SPACE. Suggestion: C:\\vs_" +
    "2017";
            // 
            // TabbedMain
            // 
            this.TabbedMain.Controls.Add(this.CreateTab);
            this.TabbedMain.Controls.Add(this.InfoTab);
            this.TabbedMain.HotTrack = true;
            this.TabbedMain.ItemSize = new System.Drawing.Size(60, 25);
            this.TabbedMain.Location = new System.Drawing.Point(10, 196);
            this.TabbedMain.Name = "TabbedMain";
            this.TabbedMain.SelectedIndex = 0;
            this.TabbedMain.Size = new System.Drawing.Size(500, 570);
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
            this.CreateTab.Location = new System.Drawing.Point(4, 29);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTab.Size = new System.Drawing.Size(492, 537);
            this.CreateTab.TabIndex = 0;
            this.CreateTab.Text = "Create";
            // 
            // InfoTab
            // 
            this.InfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.InfoTab.Controls.Add(this.CheckUpdateBtn);
            this.InfoTab.Controls.Add(this.InfoPanel);
            this.InfoTab.Location = new System.Drawing.Point(4, 29);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.InfoTab.Size = new System.Drawing.Size(492, 537);
            this.InfoTab.TabIndex = 1;
            this.InfoTab.Text = "Info";
            // 
            // HomeImage
            // 
            this.HomeImage.BackColor = System.Drawing.Color.White;
            this.HomeImage.Image = global::VS2017OfflineCustomizer.Properties.Resources.VSCustomizerHome;
            this.HomeImage.InitialImage = global::VS2017OfflineCustomizer.Properties.Resources.VSCustomizerHome;
            this.HomeImage.Location = new System.Drawing.Point(10, 10);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(500, 180);
            this.HomeImage.TabIndex = 6;
            this.HomeImage.TabStop = false;
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
            this.CloseBtn.Location = new System.Drawing.Point(452, 22);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 23);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.ForeColor = System.Drawing.Color.White;
            this.InfoPanel.Location = new System.Drawing.Point(10, 16);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(470, 233);
            this.InfoPanel.TabIndex = 0;
            this.InfoPanel.TabStop = false;
            this.InfoPanel.Text = "About";
            // 
            // CheckUpdateBtn
            // 
            this.CheckUpdateBtn.Location = new System.Drawing.Point(50, 487);
            this.CheckUpdateBtn.Name = "CheckUpdateBtn";
            this.CheckUpdateBtn.Size = new System.Drawing.Size(142, 23);
            this.CheckUpdateBtn.TabIndex = 1;
            this.CheckUpdateBtn.Text = "Check for Updates";
            this.CheckUpdateBtn.UseVisualStyleBackColor = true;
            this.CheckUpdateBtn.Click += new System.EventHandler(this.CheckUpdateBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(520, 778);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TabbedMain);
            this.Controls.Add(this.HomeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.InfoTab.ResumeLayout(false);
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
        private System.Windows.Forms.Label CurrWork;
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
    }
}

