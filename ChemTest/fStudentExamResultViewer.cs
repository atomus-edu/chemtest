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
	public partial class fStudentExamResultViewer : Form
	{
		StudentExamResult ser;
		public fStudentExamResultViewer(StudentExamResult examResult, string path)
		{
			InitializeComponent();
            btnOpen.BackgroundImage = Image.FromFile(@"sys\img\btn\open.png");
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();

            tbxPath.Text = path;
            ser = examResult;
			InitializeDataGridView();
			AddRowsDataGridView();
		}
		public fStudentExamResultViewer()
		{
			InitializeComponent();
            btnOpen.BackgroundImage = Image.FromFile(@"sys\img\btn\add.png");
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();

			InitializeDataGridView();
		}

		private void InitializeDataGridView()
		{
			var column1 = new DataGridViewColumn();
			column1.HeaderText = "Параметр"; //текст в шапке
			column1.Width = 300;
			column1.ReadOnly = true; //значение в этой колонке нельзя править
			column1.Name = "parametr"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
			column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
			column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

			var column2 = new DataGridViewColumn();
			column2.HeaderText = "Значення";
			column2.Width = 156;
			column2.ReadOnly = true;
			column2.Name = "value";
			column2.Frozen = true;
			column2.CellTemplate = new DataGridViewTextBoxCell();

			dgwResult.Columns.Add(column1);
			dgwResult.Columns.Add(column2);

			dgwResult.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
		}

		private void AddRowsDataGridView()
		{
			dgwResult.Rows.Clear();
			dgwResult.Rows.Add("Дата проходження тесту", ser.date);
			dgwResult.Rows.Add("Ім'я учня", ser.name);
			dgwResult.Rows.Add("Час, за який учень пройшов тест", ser.min + " : " + ser.sec);
			dgwResult.Rows.Add("Кількість правильних відповідей", ser.right);
			dgwResult.Rows.Add("Кількість неправильних відповідей", ser.wrong);
			dgwResult.Rows.Add("Відсоток правильних відповідей", ser.rightPurc);
			dgwResult.Rows.Add("Відсоток неправильних відповідей", ser.wrongPurc);
			dgwResult.Rows.Add("Остаточна оцінка", ser.mark);
		}
		private void OpenFile()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(StudentExamResult));

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (Stream fs = File.OpenRead(openFileDialog1.FileName))
				{
					ser = (StudentExamResult)serializer.Deserialize(fs);
				}
				tbxPath.Text = Path.GetFullPath(openFileDialog1.FileName);
			}
		}

		private void fStudentExamResultViewer_Load(object sender, EventArgs e)
		{

		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFile();
			AddRowsDataGridView();
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
