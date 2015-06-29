namespace AutoRender
{
    partial class FrmSettings
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAreaBackColor = new System.Windows.Forms.Button();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_loadSaved = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.checkBox_loadSaved);
            this.panelMain.Controls.Add(this.buttonFontColor);
            this.panelMain.Controls.Add(this.buttonAreaBackColor);
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(7, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(515, 284);
            this.panelMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Area Font Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text Area Back Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text Area Font";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAreaBackColor
            // 
            this.buttonAreaBackColor.Location = new System.Drawing.Point(198, 55);
            this.buttonAreaBackColor.Name = "buttonAreaBackColor";
            this.buttonAreaBackColor.Size = new System.Drawing.Size(75, 23);
            this.buttonAreaBackColor.TabIndex = 1;
            this.buttonAreaBackColor.UseVisualStyleBackColor = true;
            this.buttonAreaBackColor.Click += new System.EventHandler(this.buttonAreaBackColor_Click);
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.Location = new System.Drawing.Point(198, 26);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(75, 23);
            this.buttonFontColor.TabIndex = 1;
            this.buttonFontColor.UseVisualStyleBackColor = true;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Auto Load Last Saved Text";
            // 
            // checkBox_loadSaved
            // 
            this.checkBox_loadSaved.AutoSize = true;
            this.checkBox_loadSaved.Location = new System.Drawing.Point(198, 130);
            this.checkBox_loadSaved.Name = "checkBox_loadSaved";
            this.checkBox_loadSaved.Size = new System.Drawing.Size(15, 14);
            this.checkBox_loadSaved.TabIndex = 2;
            this.checkBox_loadSaved.UseVisualStyleBackColor = true;
            this.checkBox_loadSaved.CheckedChanged += new System.EventHandler(this.checkBox_loadSaved_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(148, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(206, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "ok";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 291);
            this.Controls.Add(this.panelMain);
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox checkBox_loadSaved;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.Button buttonAreaBackColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
    }
}