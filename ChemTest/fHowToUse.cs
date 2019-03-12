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
            btnBack.BackgroundImage = Image.FromFile(ChemTest.imagesFolderPath + @"\btn\back.png");

            pictureBox1.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\main.png");
            pictureBox2.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\training.png");
            pictureBox3.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\exam.png");
            pictureBox4.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\create-test.png");
            pictureBox5.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\edit-test.png");
            pictureBox6.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\select-test.png");
            pictureBox7.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\settings-testing.png");
            pictureBox8.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\settings-questions.png");
            pictureBox9.Image = Image.FromFile(ChemTest.imagesFolderPath + @"\howtouse\settings-user.png");
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