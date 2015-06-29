using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoRender
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
                global::AutoRender.Properties.Settings.Default.ClosedCorrectly = true;

            }
            catch (Exception s) { System.Windows.Forms.MessageBox.Show(s.Message, "error", MessageBoxButtons.OK); }

        }
        public static  string LastSepd(this string ss)
        {
            if(ss.Contains("\\"))
            {
                string [] sepd = ss.Split(new char [] {'\\'});
                return sepd[sepd.Length-1];
            }
            return ss;
        }
    }
}
