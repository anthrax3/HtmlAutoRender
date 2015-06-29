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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
            global::AutoRender.Properties.Settings.Default.UserFontColor=  this.buttonFontColor.BackColor = c.Color;
            }
        }

        private void buttonAreaBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                global::AutoRender.Properties.Settings.Default.UserBackColor= this.buttonAreaBackColor.BackColor = c.Color;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog s = new FontDialog();
            if(s.ShowDialog()==DialogResult.OK)
            {
                this.button1.Text = s.Font.Name;
                global::AutoRender.Properties.Settings.Default.UserFont = this.Font = s.Font;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            global::AutoRender.Properties.Settings.Default.Save();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            MessageBox.Show("saved");
            this.Close();
        }

        private void checkBox_loadSaved_CheckedChanged(object sender, EventArgs e)
        {
            global::AutoRender.Properties.Settings.Default.AutoLoadLastSaved = this.checkBox_loadSaved.Checked;

        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            
            LoadDefauls();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void LoadDefauls()
        {
            this.Font=global::AutoRender.Properties.Settings.Default.UserFont;
            this.checkBox_loadSaved.Checked =global::AutoRender.Properties.Settings.Default.AutoLoadLastSaved;
            this.buttonAreaBackColor.BackColor =global::AutoRender.Properties.Settings.Default.UserBackColor;
            this.buttonFontColor.BackColor =global::AutoRender.Properties.Settings.Default.UserFontColor;

        }
    }
}
