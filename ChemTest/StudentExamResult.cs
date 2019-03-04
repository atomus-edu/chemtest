using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemTest
{
	public class StudentExamResult
	{
		public string name;
		public DateTime date;
		public int min;
		public int sec;
		public int mark;
		public int right;
		public int wrong;
		public float rightPurc;
		public float wrongPurc;

		public StudentExamResult()
		{

		}

		public StudentExamResult(string studentName, int minutes, int seconds, int studentMark, int rightAnsw, int wrongAnsw, float rightAnswPurc, float wrongAnswPurc)
		{
			name = studentName;
			date = DateTime.Now;

			min = minutes;
			sec = seconds;
			mark = studentMark;

			right = rightAnsw;
			wrong = wrongAnsw;
			rightPurc = rightAnswPurc;
			wrongPurc = wrongAnswPurc;
		}
	}
}
