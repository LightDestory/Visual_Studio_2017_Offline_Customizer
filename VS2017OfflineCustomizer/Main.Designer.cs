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
            this.EdList = new System.Windows.Forms.ComboBox();
            this.LangSel = new System.Windows.Forms.GroupBox();
            this.CurrLang = new System.Windows.Forms.Label();
            this.CurrLangInfo = new System.Windows.Forms.Label();
            this.LangSelBtn = new System.Windows.Forms.Button();
            this.LangList = new System.Windows.Forms.ComboBox();
            this.WorkSel = new System.Windows.Forms.GroupBox();
            this.Desc = new System.Windows.Forms.Label();
            this.DescInfo = new System.Windows.Forms.Label();
            this.CurrWork = new System.Windows.Forms.Label();
            this.CurrWorkInfo = new System.Windows.Forms.Label();
            this.WorkSelBtn = new System.Windows.Forms.Button();
            this.WorkList = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FolderSel = new System.Windows.Forms.FolderBrowserDialog();
            this.EdSel.SuspendLayout();
            this.LangSel.SuspendLayout();
            this.WorkSel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EdSelBtn
            // 
            this.EdSelBtn.Location = new System.Drawing.Point(286, 27);
            this.EdSelBtn.Name = "EdSelBtn";
            this.EdSelBtn.Size = new System.Drawing.Size(143, 23);
            this.EdSelBtn.TabIndex = 0;
            this.EdSelBtn.Text = "Select Edition";
            this.EdSelBtn.UseVisualStyleBackColor = true;
            this.EdSelBtn.Click += new System.EventHandler(this.EdSelBtn_Click);
            // 
            // EdSel
            // 
            this.EdSel.BackColor = System.Drawing.SystemColors.Control;
            this.EdSel.Controls.Add(this.EdList);
            this.EdSel.Controls.Add(this.EdSelBtn);
            this.EdSel.Location = new System.Drawing.Point(12, 12);
            this.EdSel.Name = "EdSel";
            this.EdSel.Size = new System.Drawing.Size(435, 66);
            this.EdSel.TabIndex = 1;
            this.EdSel.TabStop = false;
            this.EdSel.Text = "Select a VS Edition:";
            // 
            // EdList
            // 
            this.EdList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EdList.FormattingEnabled = true;
            this.EdList.Location = new System.Drawing.Point(20, 29);
            this.EdList.Name = "EdList";
            this.EdList.Size = new System.Drawing.Size(201, 21);
            this.EdList.TabIndex = 0;
            // 
            // LangSel
            // 
            this.LangSel.Controls.Add(this.CurrLang);
            this.LangSel.Controls.Add(this.CurrLangInfo);
            this.LangSel.Controls.Add(this.LangSelBtn);
            this.LangSel.Controls.Add(this.LangList);
            this.LangSel.Enabled = false;
            this.LangSel.Location = new System.Drawing.Point(12, 84);
            this.LangSel.Name = "LangSel";
            this.LangSel.Size = new System.Drawing.Size(435, 114);
            this.LangSel.TabIndex = 2;
            this.LangSel.TabStop = false;
            this.LangSel.Text = "Add Language";
            // 
            // CurrLang
            // 
            this.CurrLang.AutoSize = true;
            this.CurrLang.Location = new System.Drawing.Point(9, 81);
            this.CurrLang.Name = "CurrLang";
            this.CurrLang.Size = new System.Drawing.Size(0, 13);
            this.CurrLang.TabIndex = 3;
            // 
            // CurrLangInfo
            // 
            this.CurrLangInfo.AutoSize = true;
            this.CurrLangInfo.Location = new System.Drawing.Point(6, 64);
            this.CurrLangInfo.Name = "CurrLangInfo";
            this.CurrLangInfo.Size = new System.Drawing.Size(140, 13);
            this.CurrLangInfo.TabIndex = 2;
            this.CurrLangInfo.Text = "Current Selected Language:";
            // 
            // LangSelBtn
            // 
            this.LangSelBtn.Location = new System.Drawing.Point(277, 28);
            this.LangSelBtn.Name = "LangSelBtn";
            this.LangSelBtn.Size = new System.Drawing.Size(152, 23);
            this.LangSelBtn.TabIndex = 1;
            this.LangSelBtn.Text = "Add/Remove Language";
            this.LangSelBtn.UseVisualStyleBackColor = true;
            this.LangSelBtn.Click += new System.EventHandler(this.LangSelBtn_Click);
            // 
            // LangList
            // 
            this.LangList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangList.FormattingEnabled = true;
            this.LangList.Location = new System.Drawing.Point(20, 31);
            this.LangList.Name = "LangList";
            this.LangList.Size = new System.Drawing.Size(241, 21);
            this.LangList.TabIndex = 0;
            // 
            // WorkSel
            // 
            this.WorkSel.Controls.Add(this.Desc);
            this.WorkSel.Controls.Add(this.DescInfo);
            this.WorkSel.Controls.Add(this.CurrWork);
            this.WorkSel.Controls.Add(this.CurrWorkInfo);
            this.WorkSel.Controls.Add(this.WorkSelBtn);
            this.WorkSel.Controls.Add(this.WorkList);
            this.WorkSel.Enabled = false;
            this.WorkSel.Location = new System.Drawing.Point(12, 204);
            this.WorkSel.Name = "WorkSel";
            this.WorkSel.Size = new System.Drawing.Size(435, 201);
            this.WorkSel.TabIndex = 4;
            this.WorkSel.TabStop = false;
            this.WorkSel.Text = "Add Workload";
            // 
            // Desc
            // 
            this.Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(7, 76);
            this.Desc.MaximumSize = new System.Drawing.Size(400, 0);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(0, 13);
            this.Desc.TabIndex = 5;
            // 
            // DescInfo
            // 
            this.DescInfo.AutoSize = true;
            this.DescInfo.Location = new System.Drawing.Point(7, 59);
            this.DescInfo.Name = "DescInfo";
            this.DescInfo.Size = new System.Drawing.Size(35, 13);
            this.DescInfo.TabIndex = 4;
            this.DescInfo.Text = "Desc:";
            // 
            // CurrWork
            // 
            this.CurrWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrWork.AutoSize = true;
            this.CurrWork.Location = new System.Drawing.Point(9, 140);
            this.CurrWork.MaximumSize = new System.Drawing.Size(400, 0);
            this.CurrWork.Name = "CurrWork";
            this.CurrWork.Size = new System.Drawing.Size(0, 13);
            this.CurrWork.TabIndex = 3;
            // 
            // CurrWorkInfo
            // 
            this.CurrWorkInfo.AutoSize = true;
            this.CurrWorkInfo.Location = new System.Drawing.Point(6, 123);
            this.CurrWorkInfo.Name = "CurrWorkInfo";
            this.CurrWorkInfo.Size = new System.Drawing.Size(138, 13);
            this.CurrWorkInfo.TabIndex = 2;
            this.CurrWorkInfo.Text = "Current Selected Workload:";
            // 
            // WorkSelBtn
            // 
            this.WorkSelBtn.Location = new System.Drawing.Point(301, 28);
            this.WorkSelBtn.Name = "WorkSelBtn";
            this.WorkSelBtn.Size = new System.Drawing.Size(128, 23);
            this.WorkSelBtn.TabIndex = 1;
            this.WorkSelBtn.Text = "Add/Remove Workload";
            this.WorkSelBtn.UseVisualStyleBackColor = true;
            this.WorkSelBtn.Click += new System.EventHandler(this.WorkSelBtn_Click);
            // 
            // WorkList
            // 
            this.WorkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkList.FormattingEnabled = true;
            this.WorkList.Location = new System.Drawing.Point(20, 31);
            this.WorkList.Name = "WorkList";
            this.WorkList.Size = new System.Drawing.Size(275, 21);
            this.WorkList.TabIndex = 0;
            this.WorkList.SelectedIndexChanged += new System.EventHandler(this.WorkList_SelectedIndexChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(21, 421);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(426, 23);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start Process";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // FolderSel
            // 
            this.FolderSel.Description = "Select the folder where download VS. Foldername without SPACE. Suggestion: C:\\vs_" +
    "2017";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(459, 456);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.WorkSel);
            this.Controls.Add(this.LangSel);
            this.Controls.Add(this.EdSel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Studio 2017 Offline Layout Customizer FIRST RELEASE";
            this.EdSel.ResumeLayout(false);
            this.LangSel.ResumeLayout(false);
            this.LangSel.PerformLayout();
            this.WorkSel.ResumeLayout(false);
            this.WorkSel.PerformLayout();
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
    }
}

