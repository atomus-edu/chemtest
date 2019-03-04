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
	public partial class fSelectTest : Form
	{
		List<Questions> qs;
		List<Questions> fqs;// filtred
		public Questions selectedQuestions;
		DirectoryInfo dir; // папка с файлами 
		int cntr = 0;//fuck

		public fSelectTest()
		{
			InitializeComponent();
			qs = new List<Questions>();
			fqs = new List<Questions>();
			dir = new DirectoryInfo(@"sys\questions"); // папка с файлами 
            // initial images
            btnReturnToMain.BackgroundImage = Image.FromFile(@"sys\img\btn\back.png");
            btnOK.BackgroundImage = Image.FromFile(@"sys\img\btn\ok.png");
            btnAdd.BackgroundImage = Image.FromFile(@"sys\img\btn\add.png");
            btnOpen.BackgroundImage = Image.FromFile(@"sys\img\btn\add.png");//change later


            cbxSubject.Text = "Будь-який";//counter for this shit
			cbxClass.Text = "Будь-який";
			cbxDifficult.Text = "Будь-яка";

			InitializeDataGridView();
			AddQuestions();

		}

		private void InitializeDataGridView()
		{
			//dgwQuestions = new DataGridView();

			var column1 = new DataGridViewColumn();
			column1.HeaderText = "Тема"; //текст в шапке
			column1.Width = 434; //ширина колонки
			column1.ReadOnly = true; //значение в этой колонке нельзя править
			column1.Name = "theme"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
			column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
			column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

			var column2 = new DataGridViewColumn();
			column2.HeaderText = "Предмет";
			column2.Name = "subject";
			column2.CellTemplate = new DataGridViewTextBoxCell();

			var column3 = new DataGridViewColumn();
			column3.HeaderText = "Клас";
			column3.Name = "class";
			column3.CellTemplate = new DataGridViewTextBoxCell();

			var column4 = new DataGridViewColumn();
			column4.HeaderText = "Складність";
			column4.Name = "difficult";
			column4.CellTemplate = new DataGridViewTextBoxCell();

			dgwQuestions.Columns.Add(column1);
			dgwQuestions.Columns.Add(column2);
			dgwQuestions.Columns.Add(column3);
			dgwQuestions.Columns.Add(column4);

			dgwQuestions.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
		}
		private void AddQuestions()
		{
			qs = new List<Questions>();

			foreach (FileInfo file in dir.GetFiles("*.ct"))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(Questions));
				using (Stream fs = File.OpenRead($"sys\\questions\\{Path.GetFileName(file.FullName)}"))
				{
					qs.Add((Questions)serializer.Deserialize(fs));
				}
			}

			dgwQuestions.Rows.Clear();
			foreach (Questions i in qs)//add string
			{
				dgwQuestions.Rows.Add(i.Theme, i.Subject, i.Class, i.Difficult);
			}
		}
		private void cbxSubject_SelectedIndexChanged(object sender, EventArgs e)
		{
			//wtf
			// im sorry..
			cntr++;
			if (cntr > 3)
			{
				FilterQuestions(cbxSubject.Text, cbxClass.Text, cbxDifficult.Text);

				dgwQuestions.Rows.Clear();
				foreach (Questions i in fqs)//add string
				{
					dgwQuestions.Rows.Add(i.Theme, i.Subject, i.Class, i.Difficult);
				}
			}
		}
		private void FilterQuestions(string subj, string clas, string diff)
		{
			fqs = new List<Questions>();
			foreach (Questions q in qs)
			{
				if (subj == "Будь-який")// subject
				{
					if (clas == "Будь-який")// class
					{
						if (diff == "Будь-яка")// difficult
						{
							// add all without filter
							fqs.Add(q);
						}
						else
						{
							// filter in difficult
							if (q.Difficult == diff)
								fqs.Add(q);
						}
					}
					else
					{
						if (diff == "Будь-яка")// difficult
						{
							// filter in class
							if (q.Class == clas)
								fqs.Add(q);
						}
						else
						{
							// filter in difficult, class
							if (q.Difficult == diff && q.Class == clas)
								fqs.Add(q);
						}
					}
				}
				else
				{
					if (clas == "Будь-який")// class
					{
						if (diff == "Будь-яка")// difficult
						{
							// filter in subject
							if (q.Subject == subj)
								fqs.Add(q);
						}
						else
						{
							// filter in subject, difficult
							if (q.Subject == subj && q.Difficult == diff)
								fqs.Add(q);
						}
					}
					else
					{
						if (diff == "Будь-яка")// difficult
						{
							// filter in subject, class
							if (q.Subject == subj && q.Class == clas)
								fqs.Add(q);
						}
						else
						{
							// filter in subject, difficult, class
							if (q.Subject == subj && q.Difficult == diff && q.Class == clas)
								fqs.Add(q);
						}
					}
				}
			}
		}

		private void bReturnToMain_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = openFileDialog1;
			dialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
			dialog.Filter = "Тестові файли|*.ct";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string fileToMove = dialog.FileName;
				string moveTo = @"sys\questions\" + dialog.SafeFileName;

				File.Copy(fileToMove, moveTo);
				AddQuestions();
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (dgwQuestions.CurrentCell.RowIndex != -1)
			{
				selectedQuestions = qs[dgwQuestions.CurrentCell.RowIndex];
				DialogResult = DialogResult.OK;
				Close();
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Questions));
			OpenFileDialog dialog = openFileDialog1;
			dialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
			dialog.Filter = "Вчительські файли|*.ect";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream fs = File.OpenRead(dialog.FileName))
				{
					ChemTest.shuffleAnsw = true;
					ChemTest.shuffleQuest = true;
					ChemTest.examDuration = 2;
					selectedQuestions = (Questions)serializer.Deserialize(fs);
					DialogResult = DialogResult.Abort;
					Close();
				}
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
