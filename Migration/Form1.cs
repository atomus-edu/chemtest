using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migration
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void PrepareForNewVersion()
        {
            try
            {
                using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Software\Atomus", true))
                {
                    if (regKey != null)
                    {
                        regKey.DeleteSubKey("ChemTest", true);
                    }
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;

            timer1.Start();
            timer2.Start();
            PrepareForNewVersion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Application.Exit();
        }
    }
}