namespace TextManager
{
    partial class ProjectTextManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.btnFileSource = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnZH = new System.Windows.Forms.Button();
            this.btnJP = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.TB01 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB01.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Location = new System.Drawing.Point(16, 451);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(692, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(6, 11);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(686, 303);
            this.txtContent.TabIndex = 1;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Location = new System.Drawing.Point(16, 422);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(692, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // cb
            // 
            this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb.Location = new System.Drawing.Point(714, 422);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(181, 21);
            this.cb.TabIndex = 3;
            // 
            // btnFileSource
            // 
            this.btnFileSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSource.Location = new System.Drawing.Point(12, 12);
            this.btnFileSource.Name = "btnFileSource";
            this.btnFileSource.Size = new System.Drawing.Size(887, 23);
            this.btnFileSource.TabIndex = 4;
            this.btnFileSource.Text = "Select File Source";
            this.btnFileSource.UseVisualStyleBackColor = true;
            this.btnFileSource.Click += new System.EventHandler(this.btnFileSource_Click);
            // 
            // btnEN
            // 
            this.btnEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEN.Location = new System.Drawing.Point(698, 11);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(175, 39);
            this.btnEN.TabIndex = 5;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnZH
            // 
            this.btnZH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZH.Location = new System.Drawing.Point(698, 56);
            this.btnZH.Name = "btnZH";
            this.btnZH.Size = new System.Drawing.Size(175, 39);
            this.btnZH.TabIndex = 6;
            this.btnZH.Text = "ZH";
            this.btnZH.UseVisualStyleBackColor = true;
            this.btnZH.Click += new System.EventHandler(this.btnZH_Click);
            // 
            // btnJP
            // 
            this.btnJP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJP.Location = new System.Drawing.Point(698, 101);
            this.btnJP.Name = "btnJP";
            this.btnJP.Size = new System.Drawing.Size(175, 39);
            this.btnJP.TabIndex = 7;
            this.btnJP.Text = "JP";
            this.btnJP.UseVisualStyleBackColor = true;
            this.btnJP.Click += new System.EventHandler(this.btnJP_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutput.Location = new System.Drawing.Point(12, 41);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(769, 23);
            this.btnOutput.TabIndex = 8;
            this.btnOutput.Text = "Output Location";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(698, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Generate Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(787, 41);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 23);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // TB01
            // 
            this.TB01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB01.Controls.Add(this.tabPage1);
            this.TB01.Controls.Add(this.tabPage2);
            this.TB01.Location = new System.Drawing.Point(12, 70);
            this.TB01.Name = "TB01";
            this.TB01.SelectedIndex = 0;
            this.TB01.Size = new System.Drawing.Size(887, 346);
            this.TB01.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckBox);
            this.tabPage1.Controls.Add(this.txtContent);
            this.tabPage1.Controls.Add(this.btnEN);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnZH);
            this.tabPage1.Controls.Add(this.btnJP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saves";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ckBox
            // 
            this.ckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBox.AutoSize = true;
            this.ckBox.Location = new System.Drawing.Point(698, 252);
            this.ckBox.Name = "ckBox";
            this.ckBox.Size = new System.Drawing.Size(87, 17);
            this.ckBox.TabIndex = 10;
            this.ckBox.Text = "Default open";
            this.ckBox.UseVisualStyleBackColor = true;
            this.ckBox.CheckedChanged += new System.EventHandler(this.ckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProjectTextManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 486);
            this.Controls.Add(this.TB01);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnFileSource);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "ProjectTextManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProjectTextManager_Load);
            this.TB01.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button btnFileSource;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnZH;
        private System.Windows.Forms.Button btnJP;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabControl TB01;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ckBox;
    }
}

