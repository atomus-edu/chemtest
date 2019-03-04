using System.Collections.Generic;

namespace ChemTest
{
	public class Questions
	{
		public string Theme { get; set; }
		public string Subject { get; set; }
		public string Class { get; set; }
		public string Difficult { get; set; }
		public string Author { get; set; }
		public bool isTeachersExam { get; set; }



		public List<Task> tasks;// list of tasks

		public Questions()
		{
			tasks = new List<Task>();
		}
		public void Title(string theme, string subject, string clas, string difficult, string author, bool isExam)
		{
			Theme = theme;
			Subject = subject;
			Class = clas;
			Difficult = difficult;
			Author = author;
			isTeachersExam = isExam;
		}

		public override string ToString()
		{
			return $"{Theme} / {Subject} {Class} кл / {Difficult}";
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
