﻿using System;

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

		public StudentExamResult() {}

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
/*
* Copyright (c) by V. Povstenko. All rights reserved.
* Consult your license regarding permissions and restrictions.
* Contacts: 
*	e-mail: vitaly.povstenko@gmail.com,
*	phone: +38(098)066-14-03(UA).
*/