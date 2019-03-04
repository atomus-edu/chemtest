using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ChemTest
{
	public partial class fEditTest : Form
	{
		Questions q;
		List<Task> ts;
		SaveFileDialog sdialog;
		OpenFileDialog odialog = new OpenFileDialog();
		public fEditTest()
		{
			InitializeComponent();
            q = new Questions();
            ts = new List<Task>();
            cbxExam.Enabled = ChemTest.isTeacher;

            // initial images
            btnReturnToMain.BackgroundImage = Image.FromFile(@"sys\img\btn\back.png");
            btnSave.BackgroundImage = Image.FromFile(@"sys\img\btn\save.png");
            btnAdd.BackgroundImage = Image.FromFile(@"sys\img\btn\add.png");
            btnRmv.BackgroundImage = Image.FromFile(@"sys\img\btn\remove.png");
            
			sdialog = saveFileDialog1;
			odialog = new OpenFileDialog();
			odialog.Filter = "Тестові файли|*.ct|Вчительські файли|*.ect";
			OpenQuestionsFromFile();
			sdialog.FileName = odialog.FileName;
		}

		void OpenQuestionsFromFile()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Questions));
			
			if (odialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream fs = File.OpenRead(odialog.FileName))
				{
					q = (Questions)serializer.Deserialize(fs);
					ts = q.tasks;
					lsbxQuestions.DataSource = null;
					lsbxQuestions.DataSource = ts;
				}
			}
            else
            {
                // maybe close?
            }

			tbxTheme.Text = q.Theme;
			cbxSubject.Text = q.Subject;
			cbxClass.Text = q.Class;
			cbxDifficult.Text = q.Difficult;
			cbxExam.Checked = q.isTeachersExam;
		}
		void SaveQuestionsToFile()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Questions));

			using (Stream fs = File.Create(sdialog.FileName))
			{
				serializer.Serialize(fs, q);
			}
			MessageBox.Show("Редагована версія тесту успішно збережена!", "Результат збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button2_Click(object sender, EventArgs e) // save
		{
			q.Title(tbxTheme.Text, cbxSubject.Text, cbxClass.Text, cbxDifficult.Text, ChemTest.name, cbxExam.Checked);

			SaveQuestionsToFile();
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string answ;
			if (rbtnVar1.Checked)
				answ = tbxVar1.Text;
			else if (rbtnVar2.Checked)
				answ = tbxVar2.Text;
			else if (rbtnVar3.Checked)
				answ = tbxVar3.Text;
			else
				answ = "ERROR";

			Task t = new Task(tbxQuestion.Text, tbxVar1.Text, tbxVar2.Text, tbxVar3.Text, answ);
			ts.Add(t);
			lsbxQuestions.DataSource = null;
			lsbxQuestions.DataSource = ts;

			tbxQuestion.Text = "";
			tbxVar1.Text = "";
			tbxVar2.Text = "";
			tbxVar3.Text = "";
		}

		private void bReturnToMain_Click(object sender, EventArgs e)//back
		{
			Close();
		}

		private void button5_Click(object sender, EventArgs e)//delete
		{
			if (lsbxQuestions.SelectedIndex != -1)
			{
				if (MessageBox.Show("Видалити це питання з тесту?", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					ts.RemoveAt(lsbxQuestions.SelectedIndex);
					lsbxQuestions.DataSource = null;
					lsbxQuestions.DataSource = ts;
				}
			}
		}

		private void lsbxQuestions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lsbxQuestions.SelectedIndex != -1)
			{
				tbxQuestion.Text = ts[lsbxQuestions.SelectedIndex].Question;
				tbxVar1.Text = ts[lsbxQuestions.SelectedIndex].Variant1;
				tbxVar2.Text = ts[lsbxQuestions.SelectedIndex].Variant2;
				tbxVar3.Text = ts[lsbxQuestions.SelectedIndex].Variant3;

				if (ts[lsbxQuestions.SelectedIndex].Answer == tbxVar1.Text)
					rbtnVar1.Checked = true;
				else if (ts[lsbxQuestions.SelectedIndex].Answer == tbxVar2.Text)
					rbtnVar2.Checked = true;
				else if (ts[lsbxQuestions.SelectedIndex].Answer == tbxVar3.Text)
					rbtnVar3.Checked = true;

			}
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
