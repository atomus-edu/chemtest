using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ChemTest
{
    public partial class fSettings : Form
	{
		OpenFileDialog odialog;
		public fSettings()
		{
			InitializeComponent();
            // initial images
            btnUpdateQuestionsList.BackgroundImage = Image.FromFile(@"sys\img\btn\refresh.png");
            btnCheckStudent.BackgroundImage = Image.FromFile(@"sys\img\btn\check-test.png");
            pbUser.Image = Image.FromFile(@"sys\img\btn\customer.png");

            SetDefault();
            tbxPath.Text = ChemTest.questionsFolderPath;

            UpdateFileList();
			odialog = openFileDialog1;
			odialog.Filter = "Файл результату|*.res|Всі файли|*.*";
		}

		private void SetDefault()
		{
			cbExamDuration.Text = ChemTest.examDuration.ToString();
			cbRandomAnsw.Checked = ChemTest.shuffleAnsw;
			cbRandomQuest.Checked = ChemTest.shuffleQuest;

            tbxPassword.Visible = ChemTest.isTeacher;
            label4.Visible = ChemTest.isTeacher;
            cbRemember.Visible = ChemTest.isTeacher;
            btnCheckStudent.Visible = ChemTest.isTeacher;

            if (ChemTest.isTeacher)
			{
				lblUserType.Text = "Вчитель";
                pbUser.Image = Image.FromFile(@"sys\img\btn\teacher.png");
			}
			else
			{
				lblUserType.Text = "Учень";
                pbUser.Image = Image.FromFile(@"sys\img\btn\student.png");
			}

			tbxName.Text = ChemTest.name;
			tbxPassword.Text = ChemTest.teacherPassword;
			cbRemember.Checked = ChemTest.rememberPassword;
		}
		private void UpdateFileList()
		{
			lsbxQuestions.Items.Clear();
			var dir = new DirectoryInfo(tbxPath.Text); // папка с файлами 

			foreach (FileInfo file in dir.GetFiles("*.ct"))
			{
				lsbxQuestions.Items.Add(Path.GetFileName(file.FullName));
			}
		}

		private void bOk_Click(object sender, EventArgs e)
		{
			ChemTest.examDuration = Convert.ToInt32(cbExamDuration.Text);
			ChemTest.shuffleQuest = cbRandomQuest.Checked;
			ChemTest.shuffleAnsw = cbRandomAnsw.Checked;

			ChemTest.isTeacher = (lblUserType.Text == "Вчитель");

			ChemTest.name = tbxName.Text;
			ChemTest.teacherPassword = tbxPassword.Text;
			ChemTest.rememberPassword = cbRemember.Checked;

			ChemTest.WriteSettings();
			Hide();
		}

		private void bCancel_Click(object sender, EventArgs e)
		{
			SetDefault();
			Hide();
		}

		private void btnResetToDefaults_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ви впевнені, що хочете забути всі налаштування? Всі ваші дані, паролі та налаштування буде скинуто до початкового стану!", "Увага!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				string regKeyName = @"Software\Atomus\ChemTest";
				RegistryKey rk = null;

				try
				{
					rk = Registry.CurrentUser.CreateSubKey(regKeyName);
					if (rk == null) return;
					rk.SetValue("ExamDuration", 10);
					rk.SetValue("ShuffleQuestions", false);
					rk.SetValue("ShuffleAnswers", false);
					rk.SetValue("IsTeacher", false);
					rk.SetValue("Name", "Користувач");
					rk.SetValue("Password", "1234");
					rk.SetValue("RememberPassword", false);
					rk.SetValue("IsFirstStartup", false);
					rk.SetValue("QuestionsFolder", Application.StartupPath + @"\sys\questions");
					rk.SetValue("ImagesFolder", Application.StartupPath + @"\sys\img");
				}
				finally
				{
					if (rk != null) rk.Close();
				}
				ChemTest.ReadSettings();
				SetDefault();
                Application.Exit();
			}
		}

		private void btnCheckStudent_Click(object sender, EventArgs e)
		{
            StudentExamResult ser = new StudentExamResult();

            XmlSerializer serializer = new XmlSerializer(typeof(StudentExamResult));

            if (odialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream fs = File.OpenRead(odialog.FileName))
                {
                    ser = (StudentExamResult)serializer.Deserialize(fs);
                }
                fStudentExamResultViewer fserv = new fStudentExamResultViewer(ser, Path.GetFullPath(openFileDialog1.FileName));

                fserv.ShowDialog();
            }
		}

        private void btnUpdateQuestionsList_Click(object sender, EventArgs e)
        {
            UpdateFileList();
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