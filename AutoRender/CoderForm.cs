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
    public partial class CoderForm : Form
    {
        public CoderForm(bool b=false)
        {
            InitializeComponent();
            this.ShowInTaskbar = b;
        }
    }
}
