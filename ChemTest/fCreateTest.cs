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


	public partial class CreateTest : Form
	{
		Questions q;
		List<Task> ts;

		public CreateTest()
		{
			InitializeComponent();
			q = new Questions();
			ts = new List<Task>();
			cbxExam.Enabled = ChemTest.isTeacher;
		}

		void SaveQuestionsToFile()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Questions));
			SaveFileDialog dialog = saveFileDialog1;
			dialog.InitialDirectory = ChemTest.questionsFolderPath;
			dialog.Filter = "Тестові файли|*.ct|Всі файли|*.*";
			if (cbxExam.Checked)
				dialog.Filter = "Файл від вчителя|*.ect|Всі файли|*.*";


			if (tbxTheme.Text == "")
				dialog.FileName = "Новий тест";
			else
				dialog.FileName = tbxTheme.Text;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream fs = File.Create(dialog.FileName))
				{
					serializer.Serialize(fs, q);
				}
			}
			string fileName = dialog.FileName;
			string MY_EXT = ".ct";
			if (cbxExam.Checked)
				MY_EXT = ".ect";

			if (!MY_EXT.Equals(Path.GetExtension(fileName), StringComparison.OrdinalIgnoreCase))
				fileName += MY_EXT;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string answ;
			if (rbtnVar1.Checked)
				answ = tbxVar1.Text;
			else if(rbtnVar2.Checked)
				answ = tbxVar2.Text;
			else if(rbtnVar3.Checked)
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

		private void button2_Click(object sender, EventArgs e)
		{
			q.Title(tbxTheme.Text, cbxSubject.Text, cbxClass.Text, cbxDifficult.Text, ChemTest.name, cbxExam.Checked);
			q.tasks.AddRange(ts);

			SaveQuestionsToFile();
			Close();
		}

		private void bReturnToMain_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button5_Click(object sender, EventArgs e)
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

		private void CreateTest_Load(object sender, EventArgs e)
		{

		}
	}
}