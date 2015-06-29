using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoRender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.richTextBox1.Text += "\r\n" + Environment.UserName + " qoutes</div> \r\n</body>\r\n</html>";
        }

        private void LoadSettings()
        {
            this.BackColor = global::AutoRender.Properties.Settings.Default.UserFormColor;
            this.richTextBox1.Font = global::AutoRender.Properties.Settings.Default.UserFont;
            this.richTextBox1.BackColor = global::AutoRender.Properties.Settings.Default.UserBackColor;
            this.richTextBox1.ForeColor = global::AutoRender.Properties.Settings.Default.UserFontColor;
          

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            Timer_ticks = 0;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Timer_ticks++;
            NotfLbl.Text = "";
            if(Timer_ticks==5)
            {

                timer1.Stop();
                Timer_ticks = 0;
                this.webBrowser1.DocumentText = richTextBox1.Text;
                buttonSave.Enabled = btnCopy.Enabled = this.richTextBox1.Text.Length > 1;
            }
        }

        public int Timer_ticks = 0;

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            NotfLbl.Text = "Loaded";
        }

        private void btnFont_Click(object sender, EventArgs e)
        {

            FontDialog f = new FontDialog();
            if(f.ShowDialog()==DialogResult.OK)
            {
                this.richTextBox1.Font = f.Font;
                SetNotficitaion("Font changed to "+f.Font.Name);
            }
        }

        private void SetNotficitaion(string p)
        {
            NotfLbl.Text = p;
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                this.btnBG.BackColor = c.Color;
                SetNotficitaion("Back Color changed .");

            }
            this.richTextBox1.BackColor = btnBG.BackColor;
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                this.btnForeColor.BackColor = c.Color;
                SetNotficitaion("Font Color changed .");

            }
            this.richTextBox1.ForeColor = btnForeColor.BackColor;
        }

        private void linkLabelLoadFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabelCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.richTextBox1.Text = System.IO.File.ReadAllText(o.FileName);
                    SetNotficitaion("File loaded ");
                }
                catch
                {
                    SetNotficitaion("Can not load file ");

                }
            }
        }

        private void CopyText(object sender, EventArgs e)
        {
             

            if (this.richTextBox1.Text == "")
                return;
            Clipboard.SetText(this.richTextBox1.Text);
            SetNotficitaion("Copied.");
        }

        private void linklblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         FrmSettings f  =  new FrmSettings();
         if (f.ShowDialog() == DialogResult.OK)
             LoadFromSettins();
        }

        private void LoadFromSettins()
        {
            this.BackColor = global::AutoRender.Properties.Settings.Default.UserFormColor;
           this.btnForeColor.BackColor= this.richTextBox1.ForeColor = global::AutoRender.Properties.Settings.Default.UserFontColor;
           this.btnBG.BackColor= this.richTextBox1.BackColor = global::AutoRender.Properties.Settings.Default.UserBackColor;
            this.richTextBox1.Font = global::AutoRender.Properties.Settings.Default.UserFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromSettins();
            AskForLoadingLastText();
            global::AutoRender.Properties.Settings.Default.ClosedCorrectly = false;
             
        }

        private void AskForLoadingLastText()
        {
            if (global::AutoRender.Properties.Settings.Default.LastText.Trim() != "")
            {
                string msg = "";
                if (global::AutoRender.Properties.Settings.Default.AutoLoadLastSaved)
                {
                    this.richTextBox1.Text = global::AutoRender.Properties.Settings.Default.LastText;
                    SetNotficitaion("Loaded last saved");
                }
                else if (global::AutoRender.Properties.Settings.Default.ClosedCorrectly == false)
                {
                    msg = "It seems that program did not close successfully last time " + Environment.NewLine + "Do you want to restore last-time saved text?";
                }
                else
                    msg = "Do you want to restore last-time saved text?";


                if (MessageBox.Show(msg, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.richTextBox1.Text = global::AutoRender.Properties.Settings.Default.LastText;
                    SetNotficitaion("Loaded last saved");
                }


            }
        }

        private void SaveToFile(object sender, EventArgs e)
        {
            try { 
            PerformSavingTextToFile();
            }
            catch (Exception sa) { MessageBox.Show(sa.Message); }

        }

        private void PerformSavingTextToFile()
        {
            string msg = "";

            if (System.IO.File.Exists(this.currentFile) == false)
            {
                SaveFileDialog s = new SaveFileDialog();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    if (!s.FileName.EndsWith(".html") || !s.FileName.EndsWith(".js") || !s.FileName.EndsWith(".css"))
                        s.FileName = s.FileName + ".html";
                    try
                    {
                        System.IO.File.WriteAllText(s.FileName, this.richTextBox1.Text);
                        labelTabPage.Text = s.FileName.LastSepd();
                        this.currentFile = s.FileName;
                        msg = "saved to " + s.FileName;
                    }
                    catch { msg = "can not save file "; }
                }
                else
                    return;

                SetNotficitaion(msg);
            }
            else
            {
                try
                {
                    System.IO.File.WriteAllText(this.currentFile, this.richTextBox1.Text);

                    msg = "saved to " + this.currentFile;
                }
                catch { msg = "can not save file "; }

            }
            SetNotficitaion(msg);
        }

        private void About_(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CoderForm(true).ShowDialog();
        }

        public string currentFile { get; set; }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.currentFile = "";
            this.labelTabPage.Text = "untitled";
            SetNotficitaion("New template");
        }
    }
}
