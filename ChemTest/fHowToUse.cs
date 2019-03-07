using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChemTest
{
    public partial class fHowToUse : Form
	{
		public fHowToUse()
		{
			InitializeComponent();
            // initial images
            btnBack.BackgroundImage = Image.FromFile(@"sys\img\btn\back.png");
        }

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
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