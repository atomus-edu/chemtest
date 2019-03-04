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
	public partial class fExamResult : Form
	{
		int min, sec, mark, right, wrong;
		float rightAnswPurc, wrongAnswPurc;
		public fExamResult(int Min, int Sec, int Mark, float RightAnswPurc, float WrongAnswPurc, int rightAnsw, int wrongAnsw, bool print)
		{
			InitializeComponent();

			min = Min;
			sec = Sec;
			mark = Mark;
			rightAnswPurc = RightAnswPurc;
			wrongAnswPurc = WrongAnswPurc;
			right = rightAnsw;
			wrong = wrongAnsw;

			ShowResult();
			if (print) SaveFile();

		}
		private void ShowResult()
		{
			if (rightAnswPurc == 0) pbStars.Image = Image.FromFile(@"sys\img\0stars.jpg");
			if (rightAnswPurc >= 20) pbStars.Image = Image.FromFile(@"sys\img\1stars.jpg");
			if (rightAnswPurc >= 40) pbStars.Image = Image.FromFile(@"sys\img\2stars.jpg");
			if (rightAnswPurc >= 60) pbStars.Image = Image.FromFile(@"sys\img\3stars.jpg");
			if (rightAnswPurc >= 80) pbStars.Image = Image.FromFile(@"sys\img\4stars.jpg");

			if (min < ChemTest.examDuration || (min == ChemTest.examDuration && sec == 0))// success
			{
				if (rightAnswPurc == 100.0)// full success
				{
					tbxTitle.Text = "Вiтаю!";
					tbxText.Text = "Ви правильно вiдповiли на всі питання";
					pbStars.Image = Image.FromFile(@"sys\img\5stars.jpg");
				}
				else if (rightAnswPurc >= 80.0)// success
				{
					tbxTitle.Text = "Екзамен пройдено!";
					tbxText.Text = "";
				}
				else// fail
				{
					tbxTitle.Text = "Екзамен не пройдено!";
					tbxText.Text = "Щоб пройти екзамен потрiбно правильно вiдповiсти на 80% питань і впоратись вчасно";
				}
			}
			else if (min == ChemTest.examDuration && sec != 0 || min > ChemTest.examDuration)// fail
			{
				tbxTitle.Text = "Екзамен не пройдено!";
				tbxText.Text = "Щоб пройти екзамен потрiбно правильно вiдповiсти на 80% питань і впоратись вчасно";
			}

			lblMark.Text = mark.ToString();
			lblTime.Text = $"{min}:{sec}";
			lblRight.Text = $"{right} ({rightAnswPurc.ToString("#.#")}%)";
			lblWrong.Text = $"{wrong} ({wrongAnswPurc.ToString("#.#")}%)";
		}
		private void SaveFile()
		{
			StudentExamResult ser = new StudentExamResult(ChemTest.name, min, sec, mark, right, wrong, rightAnswPurc, wrongAnswPurc);

			XmlSerializer serializer = new XmlSerializer(typeof(StudentExamResult));
			SaveFileDialog dialog = saveFileDialog1;
			dialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
			dialog.Filter = "Файл результату|*.res|Всі файли|*.*";

			dialog.FileName = $"Результат {ChemTest.name} ({DateTime.Now.ToShortDateString()})";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream fs = File.Create(dialog.FileName))
				{
					serializer.Serialize(fs, ser);
				}
			}
			string fileName = dialog.FileName;
			string MY_EXT = ".res";

			if (!MY_EXT.Equals(Path.GetExtension(fileName), StringComparison.OrdinalIgnoreCase))
				fileName += MY_EXT;
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
