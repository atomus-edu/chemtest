namespace ChemTest
{
	public class Task
	{
		public string Question { get; set; }
		public string Variant1 { get; set; }
		public string Variant2 { get; set; }
		public string Variant3 { get; set; }
		public string Answer { get; set; }

		public Task(string question, string variant1, string variant2, string variant3, string answer)
		{
			Question = question;
			Variant1 = variant1;
			Variant2 = variant2;
			Variant3 = variant3;
			if (answer == Variant1 || answer == Variant2 || answer == Variant3)
				Answer = answer;
		}

		public override string ToString()
		{
			return Question;
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