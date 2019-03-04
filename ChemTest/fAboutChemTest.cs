using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemTest
{
	public partial class fAboutChemTest : Form
	{
		public fAboutChemTest()
		{
			InitializeComponent();
			pbChemTest.Image = new Bitmap(@"sys\img\chemtest logo icon.png");
			pbAtomus.Image = new Bitmap(@"sys\img\atomus logo black.png");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://atomusedu.wixsite.com/chemtest");
		}
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/povstenko/chemtest");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://atomusedu.wixsite.com/atomus");
		}

		private void fAboutChemTest_Load(object sender, EventArgs e)
		{

		}
    }
}
/*
* Copyright (c) by V. Povstenko. All rights reserved.
* Consult your license regarding permissions and restrictions.
* Contacts: 
*	e-mail: vitaly.povstenko@gmail.com,
*	phone: +38(098)066-14-03(UA).
*/
