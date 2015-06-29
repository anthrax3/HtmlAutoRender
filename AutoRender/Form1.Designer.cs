namespace AutoRender
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelBadge = new System.Windows.Forms.Panel();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTabPage = new System.Windows.Forms.Label();
            this.panelBrwser = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.NotfLbl = new System.Windows.Forms.Label();
            this.gpx_bottom = new System.Windows.Forms.GroupBox();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.linklblSettings = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelBadge.SuspendLayout();
            this.panelBrwser.SuspendLayout();
            this.gpx_bottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.btnLoadFromFile);
            this.groupBox1.Controls.Add(this.btnForeColor);
            this.groupBox1.Controls.Add(this.btnBG);
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.Cyan;
            this.btnCopy.Location = new System.Drawing.Point(870, 227);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 22);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.CopyText);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSave.Location = new System.Drawing.Point(708, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.SaveToFile);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFromFile.ForeColor = System.Drawing.Color.Cyan;
            this.btnLoadFromFile.Location = new System.Drawing.Point(789, 226);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFromFile.TabIndex = 5;
            this.btnLoadFromFile.Text = "Load file";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.ForeColor = System.Drawing.Color.Cyan;
            this.btnForeColor.Location = new System.Drawing.Point(596, 226);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(56, 23);
            this.btnForeColor.TabIndex = 3;
            this.btnForeColor.Text = "FC";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnBG
            // 
            this.btnBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBG.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBG.ForeColor = System.Drawing.Color.Cyan;
            this.btnBG.Location = new System.Drawing.Point(658, 226);
            this.btnBG.Name = "btnBG";
            this.btnBG.Size = new System.Drawing.Size(44, 23);
            this.btnBG.TabIndex = 2;
            this.btnBG.Text = "BG";
            this.btnBG.UseVisualStyleBackColor = false;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.ForeColor = System.Drawing.Color.Cyan;
            this.btnFont.Location = new System.Drawing.Point(545, 227);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(45, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(945, 201);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.groupBox2.Controls.Add(this.panelBadge);
            this.groupBox2.Controls.Add(this.panelBrwser);
            this.groupBox2.Location = new System.Drawing.Point(7, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browser";
            // 
            // panelBadge
            // 
            this.panelBadge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBadge.BackgroundImage = global::AutoRender.Properties.Resources.ie;
            this.panelBadge.Controls.Add(this.buttonNew);
            this.panelBadge.Controls.Add(this.buttonForward);
            this.panelBadge.Controls.Add(this.buttonBack);
            this.panelBadge.Controls.Add(this.labelTabPage);
            this.panelBadge.Location = new System.Drawing.Point(9, 16);
            this.panelBadge.Name = "panelBadge";
            this.panelBadge.Size = new System.Drawing.Size(936, 52);
            this.panelBadge.TabIndex = 2;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Location = new System.Drawing.Point(882, 26);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(24, 23);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "Auto Render ";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackgroundImage = global::AutoRender.Properties.Resources.forwarding;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.buttonForward.Location = new System.Drawing.Point(36, 12);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(32, 34);
            this.buttonForward.TabIndex = 2;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::AutoRender.Properties.Resources.back;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.buttonBack.Location = new System.Drawing.Point(3, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(38, 37);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTabPage
            // 
            this.labelTabPage.AutoSize = true;
            this.labelTabPage.BackColor = System.Drawing.Color.Transparent;
            this.labelTabPage.Location = new System.Drawing.Point(100, 28);
            this.labelTabPage.Name = "labelTabPage";
            this.labelTabPage.Size = new System.Drawing.Size(41, 13);
            this.labelTabPage.TabIndex = 0;
            this.labelTabPage.Text = "untitled";
            // 
            // panelBrwser
            // 
            this.panelBrwser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrwser.Controls.Add(this.webBrowser1);
            this.panelBrwser.Location = new System.Drawing.Point(6, 69);
            this.panelBrwser.Name = "panelBrwser";
            this.panelBrwser.Size = new System.Drawing.Size(939, 144);
            this.panelBrwser.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(939, 144);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // NotfLbl
            // 
            this.NotfLbl.AutoSize = true;
            this.NotfLbl.ForeColor = System.Drawing.Color.White;
            this.NotfLbl.Location = new System.Drawing.Point(6, 14);
            this.NotfLbl.Name = "NotfLbl";
            this.NotfLbl.Size = new System.Drawing.Size(13, 13);
            this.NotfLbl.TabIndex = 2;
            this.NotfLbl.Text = "..";
            // 
            // gpx_bottom
            // 
            this.gpx_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpx_bottom.BackColor = System.Drawing.SystemColors.InfoText;
            this.gpx_bottom.Controls.Add(this.linkLabelAbout);
            this.gpx_bottom.Controls.Add(this.linklblSettings);
            this.gpx_bottom.Controls.Add(this.NotfLbl);
            this.gpx_bottom.Location = new System.Drawing.Point(7, 490);
            this.gpx_bottom.Name = "gpx_bottom";
            this.gpx_bottom.Size = new System.Drawing.Size(945, 34);
            this.gpx_bottom.TabIndex = 2;
            this.gpx_bottom.TabStop = false;
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelAbout.Location = new System.Drawing.Point(833, 14);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(34, 13);
            this.linkLabelAbout.TabIndex = 3;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "about";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.About_);
            // 
            // linklblSettings
            // 
            this.linklblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linklblSettings.AutoSize = true;
            this.linklblSettings.LinkColor = System.Drawing.Color.Cyan;
            this.linklblSettings.Location = new System.Drawing.Point(884, 14);
            this.linklblSettings.Name = "linklblSettings";
            this.linklblSettings.Size = new System.Drawing.Size(45, 13);
            this.linklblSettings.TabIndex = 3;
            this.linklblSettings.TabStop = true;
            this.linklblSettings.Text = "Settings";
            this.linklblSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSettings_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.gpx_bottom);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 529);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(974, 537);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Render";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelBadge.ResumeLayout(false);
            this.panelBadge.PerformLayout();
            this.panelBrwser.ResumeLayout(false);
            this.gpx_bottom.ResumeLayout(false);
            this.gpx_bottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NotfLbl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox gpx_bottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnBG;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.LinkLabel linklblSettings;
        private System.Windows.Forms.Panel panelBrwser;
        private System.Windows.Forms.Panel panelBadge;
        private System.Windows.Forms.Label labelTabPage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonNew;
    }
}

