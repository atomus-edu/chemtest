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
	public partial class fMain : Form
	{
		fExam fe;
		fTraining ft;
		fSettings fs;

		public fMain()
		{
			InitializeComponent();
			ChemTest.ReadSettings();
			if (!ChemTest.rememberPassword)
			{
				fLogin fl = new fLogin();
				if (fl.ShowDialog() == DialogResult.Cancel)
					Close();
			}

			fe = new fExam(false);
			ft = new fTraining();
			fs = new fSettings();

			pbLogo.Image = new Bitmap(@"sys\img\chemtest logo light blue.png");
			pbBackground.Image = new Bitmap(@"sys\img\background.jpg");

			pbExam.Image = new Bitmap(@"sys\img\btn\exam.png");
			pbTraining.Image = new Bitmap(@"sys\img\btn\training.png");
			pbCreate.Image = new Bitmap(@"sys\img\btn\add-test.png");
			pbSettings.Image = new Bitmap(@"sys\img\btn\settings.png");
			pbHowToUse.Image = new Bitmap(@"sys\img\btn\question.png");
			pbAbout.Image = new Bitmap(@"sys\img\btn\info.png");
			pbExit.Image = new Bitmap(@"sys\img\btn\exit.png");

			pbBack.Image = new Bitmap(@"sys\img\btn\back.png");
			pbNewTest.Image = new Bitmap(@"sys\img\btn\add-test.png");
			pbEditTest.Image = new Bitmap(@"sys\img\btn\edit-test.png");
		}

		private void bExam_Click(object sender, EventArgs e)
		{
			fSelectTest st = new fSelectTest(true);
			DialogResult stdr = st.ShowDialog();
			if (stdr== DialogResult.OK)
			{
				fe = new fExam(false);
				fe.q = st.selectedQuestions;
				fe.ShowDialog();
			}
			else if(stdr == DialogResult.Abort)
			{
				fe = new fExam(true);
				fe.q = st.selectedQuestions;
				fe.ShowDialog();
			}
			Show();
			ChemTest.ReadSettings();
			fe = new fExam(false);
		}
		private void bTraining_Click(object sender, EventArgs e)
		{
			fSelectTest st = new fSelectTest(false);
			DialogResult stdr = st.ShowDialog();
			if (stdr == DialogResult.OK)
			{
				ft.q = st.selectedQuestions;
				ft.ShowDialog();
			}
			else if (stdr == DialogResult.Abort)
			{
				fe = new fExam(true);
				fe.q = st.selectedQuestions;
				fe.ShowDialog();
			}
			Show();
			ChemTest.ReadSettings();
			fe = new fExam(false);
			ft = new fTraining();
		}
		private void bSettings_Click(object sender, EventArgs e)
		{
			fs.ShowDialog();
			Show();
		}
		private void bAboutUs_Click(object sender, EventArgs e)
		{
			fAboutChemTest ac = new fAboutChemTest();
			ac.ShowDialog();
		}
		private void bHowToUse_Click(object sender, EventArgs e)
		{
			fHowToUse htu = new fHowToUse();
			htu.ShowDialog();
		}
		private void bExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ви впевнені, що хочете вийти?", "Вихід", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Close();
		}

		private void btnAddQuestions_Click(object sender, EventArgs e)
		{
			//hide all buttons
			bExam.Visible = false;
			bTraining.Visible = false;
			btnAddQuestions.Visible = false;
			bSettings.Visible = false;
			bHowToUse.Visible = false;
			bAboutUs.Visible = false;
			bExit.Visible = false;

			//hide all icons
			pbExam.Visible = false;
			pbTraining.Visible = false;
			pbCreate.Visible = false;
			pbSettings.Visible = false;
			pbHowToUse.Visible = false;
			pbAbout.Visible = false;
			pbExit.Visible = false;

			//show second menu buttons
			btnBackToMenu.Visible = true;
			btnNewTest.Visible = true;
			btnEditTest.Visible = true;

			//show second menu icons
			pbBack.Visible = true;
			pbNewTest.Visible = true;
			pbEditTest.Visible = true;
		}
		private void btnBackToMenu_Click(object sender, EventArgs e)
		{
			//hide all buttons
			btnBackToMenu.Visible = false;
			btnNewTest.Visible = false;
			btnEditTest.Visible = false;

			//hide all icons
			pbBack.Visible = false;
			pbNewTest.Visible = false;
			pbEditTest.Visible = false;

			//show first menu buttons
			bExam.Visible = true;
			bTraining.Visible = true;
			btnAddQuestions.Visible = true;
			bSettings.Visible = true;
			bHowToUse.Visible = true;
			bAboutUs.Visible = true;
			bExit.Visible = true;

			//show first menu icons
			pbExam.Visible = true;
			pbTraining.Visible = true;
			pbCreate.Visible = true;
			pbSettings.Visible = true;
			pbHowToUse.Visible = true;
			pbAbout.Visible = true;
			pbExit.Visible = true;
			
		}
		private void btnNewTest_Click(object sender, EventArgs e)
		{
			CreateTest ct = new CreateTest();
			ct.ShowDialog();
		}
		private void btnEditTest_Click(object sender, EventArgs e)
		{
			fEditTest et = new fEditTest();
			et.ShowDialog();
		}

		private void bExit_MouseEnter(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = System.Drawing.Color.Red;
			btn.ForeColor = System.Drawing.Color.White;
		}
		private void bExit_MouseLeave(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			btn.ForeColor = System.Drawing.Color.Black;
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