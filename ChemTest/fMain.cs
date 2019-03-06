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

			pbLogo.Image = Image.FromFile(@"sys\img\chemtest logo light blue.png");
			pbBackground.Image = Image.FromFile(@"sys\img\background.jpg");

            bExam.Image = Image.FromFile(@"sys\img\btn\exam.png");
            bTraining.Image = Image.FromFile(@"sys\img\btn\training.png");
            btnAddQuestions.Image = Image.FromFile(@"sys\img\btn\add-test.png");
            bSettings.Image = Image.FromFile(@"sys\img\btn\settings.png");
            bHowToUse.Image = Image.FromFile(@"sys\img\btn\question.png");
            bAboutUs.Image = Image.FromFile(@"sys\img\btn\info.png");
            bExit.Image = Image.FromFile(@"sys\img\btn\exit.png");

            btnBackToMenu.Image = Image.FromFile(@"sys\img\btn\back.png");
            btnNewTest.Image = Image.FromFile(@"sys\img\btn\add-test.png");
            btnEditTest.Image = Image.FromFile(@"sys\img\btn\edit-test.png");
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

			//show second menu buttons
			btnBackToMenu.Visible = true;
			btnNewTest.Visible = true;
			btnEditTest.Visible = true;
		}
		private void btnBackToMenu_Click(object sender, EventArgs e)
		{
			//hide all buttons
			btnBackToMenu.Visible = false;
			btnNewTest.Visible = false;
			btnEditTest.Visible = false;

			//show first menu buttons
			bExam.Visible = true;
			bTraining.Visible = true;
			btnAddQuestions.Visible = true;
			bSettings.Visible = true;
			bHowToUse.Visible = true;
			bAboutUs.Visible = true;
			bExit.Visible = true;
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