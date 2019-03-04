using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemTest
{

	public abstract class Test
	{
		public List<Task> tasks;// list of tasks
								//public List<Task> tasksForExam;// list of tasks only for exam
								//public List<Task> tasksForTraining;// list of tasks only for training

		public int Current { get; set; }// current question

		protected int rightAnsw;// counter of right answers
		public int RightAnsw
		{
			get { return rightAnsw; }
		}

		protected int wrongAnsw;// counter of wrong answers
		public int WrongAnsw
		{
			get { return wrongAnsw; }
		}

		public Test()
		{
			tasks = new List<Task>();
			//tasksForExam = new List<Task>();
			//tasksForTraining = new List<Task>();
			ReadTask("empthy");

			Shuffle();

			Current = 0;
			rightAnsw = 0;
			wrongAnsw = 0;
		}

		// returns shuffled list
		public void Shuffle()
		{
			tasks = ShuffleQuestions(tasks);
			tasks = ShuffleVariants(tasks);
		}
		public List<Task> ShuffleQuestions(List<Task> list)
		{
			if (ChemTest.shuffleQuest)
			{
				Random r = new Random();

				for (int i = 0; i < list.Count; i++)// shuffle list
				{
					Task tmp = list[i];
					list.RemoveAt(i);
					list.Insert(r.Next(list.Count), tmp);
				}
			}
			else
				return tasks;
			

			return list;
		}
		// returns list with shuffled variants
		public List<Task> ShuffleVariants(List<Task> list)
		{
			if (ChemTest.shuffleAnsw)
			{
				Random r = new Random();
				List<string> variants;// list of variants


				foreach (Task item in list)// work with 1 question oin each iteration
				{
					variants = new List<string>(3);

					// copy variants
					variants.Add(item.Variant1);
					variants.Add(item.Variant2);
					variants.Add(item.Variant3);

					for (int i = 0; i < variants.Count; i++)// shuffle variants in list
					{
						string tmp = variants[i];
						variants.RemoveAt(i);
						variants.Insert(r.Next(variants.Count), tmp);
					}

					//return variants
					item.Variant1 = variants[0];
					item.Variant2 = variants[1];
					item.Variant3 = variants[2];
				}
				return list;
			}
			else
				return tasks;
		}
		
		public void ReadTask(string filePath)
		{
			//tasks.Add(new Task("Визначення атома",
			//	"найменша частинка, що входить до складу молекули i зберігає iї властивостi",
			//	"електронейтральна частинка речовини, що складається з протонiв",
			//	"найменша електронейтральна частинка, що складається з ядра та електронiв",
			//	"найменша електронейтральна частинка, що складається з ядра та електронiв"));
			//tasks.Add(new Task("Позначте визначення молекули",
			//	"найменша частинка речовини, що зберігає її властивостi",
			//	"найменша частинка речовини, що здатна до самостiйного iснування",
			//	"найменша частинка елемента, що зберiгає його властивостi",
			//	"найменша частинка речовини, що зберігає її властивостi"));
			//tasks.Add(new Task("Позначте визначення відностной атомної маси",
			//	"найменша маса речовини, яка обумовлює її властивості",
			//	"маса одного моля речовини",
			//	"число, що дорівнює відношеню маси атома елемента до 1/12 атома Карбону",
			//	"число, що дорівнює відношеню маси атома елемента до 1/12 атома Карбону"));
			//tasks.Add(new Task("Позначте визначення атомної одиницi маси",
			//	"1/2 маси атома нуклiда Карбону-12",
			//	"маса атома нуклiда Карбону-12",
			//	"1/12 маси атома нуклiда Карбону-12",
			//	"1/12 маси атома нуклiда Карбону-12"));
			//tasks.Add(new Task("Позначте відносну атомну масу ортофосфатної кислоти",
			//	"95",
			//	"105",
			//	"98",
			//	"98"));
			//tasks.Add(new Task("Позначте порядковий номер елемента Х, що утворює речовину ХО з відносною\nмолекулярною масою 30",
			//	"6",
			//	"7",
			//	"14",
			//	"7"));
			//tasks.Add(new Task("Позначте прізвище вченого, ім'ям якого названо число частинок, що міститься\nв 1 моль будь-якої речовини",
			//	"Менделєев",
			//	"Авогадро",
			//	"Резерфорд",
			//	"Авогадро"));
			//tasks.Add(new Task("В 1 моль будь-якої речовини міститься саме стільки частинок, скільки атомів\nу зразку одного з нуклідів масою 0,012 кг",
			//	"нітроген - 15",
			//	"оксиген - 16",
			//	"карбон - 12",
			//	"карбон - 12"));
			//tasks.Add(new Task("Укажіть одиницю вимірювання величини, на яку потрібно розділити масу речовини\nдля обчислення кількості речовини",
			//	"г",
			//	"м^3",
			//	"г/моль",
			//	"м^3"));
			//tasks.Add(new Task("Укажіть вірне зазначення молярної маси речовини",
			//	"найменша маса речовини, що визначає її властивості",
			//	"маса одного моля речовини",
			//	"маса однієї молекули речовини",
			//	"маса одного моля речовини"));
			//tasks.Add(new Task("Позначте визначення кількості речовини:",
			//	"величина, що визначається числом структурних частинок в певній порції речовини",
			//	"величина, що позначається масою однієї молекули речовини",
			//	"величини, що визначається загальною кількістю атомів в молекулі речовини",
			//	"величина, що визначається числом структурних частинок в певній порції речовини"));
		}
	}

	public class Exam : Test
	{
		public void EnterVariant(string variant)
		{
			if (variant == tasks[Current - 1].Answer)
				rightAnsw++;
			else
				wrongAnsw++;
		}
		public void GetResult(int min, int sec, bool file)
		{
			float rightAnswPurc, wrongAnswPurc;
			rightAnswPurc = (float)100 / tasks.Count * rightAnsw;
			wrongAnswPurc = (float)100 / tasks.Count * wrongAnsw;

			int mark = 0;
			if (rightAnswPurc == 100) mark = 12;
			else if (rightAnswPurc >= 90.0) mark = 11;
			else if (rightAnswPurc >= 85.0) mark = 10;
			else if (rightAnswPurc >= 75.0) mark = 9;
			else if (rightAnswPurc >= 70.0) mark = 8;
			else if (rightAnswPurc >= 65.0) mark = 7;
			else if (rightAnswPurc >= 55.0) mark = 6;
			else if (rightAnswPurc >= 50.0) mark = 5;
			else if (rightAnswPurc >= 45.0) mark = 4;
			else if (rightAnswPurc >= 35.0) mark = 3;
			else if (rightAnswPurc >= 30.0) mark = 2;
			else if (rightAnswPurc < 30.0) mark = 1;

			fExamResult er = new fExamResult(min, sec, mark, rightAnswPurc, wrongAnswPurc, rightAnsw, wrongAnsw, file);
			er.ShowDialog();
		}
	}
	public class Training : Test
	{
		public bool EnterVariant(string variant)
		{
			if (variant == tasks[Current-1].Answer)
			{
				rightAnsw++;
				return true;
			}
			else
			{
				wrongAnsw++;
				return false;
			}
		}
		public string GetResult()
		{
			float rightAnswPurc, wrongAnswPurc;
			rightAnswPurc = (float)100.0 / tasks.Count * rightAnsw;
			wrongAnswPurc = (float)100.0 / tasks.Count * wrongAnsw;
			return $"Кiлькiсть правильних вiдповiдей:      {rightAnsw} ({rightAnswPurc.ToString("#.#")}%)\nКiлькiсть неправильних вiдповiдей:  {wrongAnsw} ({wrongAnswPurc.ToString("#.#")}%)";
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