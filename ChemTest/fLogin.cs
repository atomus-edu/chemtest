using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChemTest
{
    public partial class fLogin : Form
	{
		public fLogin()
		{
			InitializeComponent();
			ChemTest.ReadSettings();

            btnTeacher.Image = Image.FromFile(@"sys\img\btn\teacher.png");
            btnStudent.Image = Image.FromFile(@"sys\img\btn\student.png");
            btnOK.BackgroundImage = Image.FromFile(@"sys\img\btn\next.png");
		}

		private void btnStudent_Click(object sender, EventArgs e)
		{
			ChemTest.isTeacher = false;
			btnStudent.Visible = false;
			btnTeacher.Visible = false;

            lblName.Visible = true;
			tbxName.Visible = true;

			btnOK.Visible = true;
		}

		private void btnTeacher_Click(object sender, EventArgs e)
		{
			ChemTest.isTeacher = true;
			btnStudent.Visible = false;
			btnTeacher.Visible = false;

            lblName.Visible = true;
			tbxName.Visible = true;
			lblPassword.Visible = true;
			tbxPassword.Visible = true;

			btnOK.Visible = true;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			ChemTest.name = tbxName.Text;
			ChemTest.rememberPassword = cbRemember.Checked;
			if (tbxPassword.Visible)
			{
				if (tbxPassword.Text == ChemTest.teacherPassword)
				{
					ChemTest.WriteSettings();
					DialogResult = DialogResult.OK;
				}
				else
					MessageBox.Show("Ви ввели неправильний пароль.", "Неправильний пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				DialogResult = DialogResult.OK;
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