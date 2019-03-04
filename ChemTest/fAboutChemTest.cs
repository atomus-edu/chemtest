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

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://atomusedu.wixsite.com/atomus");
		}

		private void fAboutChemTest_Load(object sender, EventArgs e)
		{

		}
	}
}
