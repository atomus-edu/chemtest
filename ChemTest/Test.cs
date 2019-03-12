using System;
using System.Collections.Generic;

namespace ChemTest
{
    public abstract class Test
	{
		public List<Task> tasks;// list of tasks

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