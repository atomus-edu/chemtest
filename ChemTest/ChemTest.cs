using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ChemTest
{
	static class ChemTest
	{
		static public int examDuration = 10;// time for exam test
		static public bool shuffleQuest = false;// questions on random 
		static public bool shuffleAnsw = false;// answers on random
		static public bool isTeacher = false;
		static public string name = "Користувач";
		static public string teacherPassword = "1234";
		static public bool rememberPassword = false;
		static public bool isFirstStartup = true;
		static public string questionsFolderPath = Application.StartupPath + @"\sys\questions";
		static public string imagesFolderPath = Application.StartupPath + @"\sys\img";

		static string regKeyName = @"Software\Atomus\ChemTest"; 

		static public void ReadSettings()
		{
			RegistryKey rk = null;

			try
			{
				rk = Registry.CurrentUser.OpenSubKey(regKeyName);

				if (rk != null)
				{
					examDuration = (int)rk.GetValue("ExamDuration");
					shuffleQuest = Convert.ToBoolean(rk.GetValue("ShuffleQuestions"));
					shuffleAnsw = Convert.ToBoolean(rk.GetValue("ShuffleAnswers"));
					isTeacher = Convert.ToBoolean(rk.GetValue("IsTeacher"));
					name = Convert.ToString(rk.GetValue("Name"));
					teacherPassword = Convert.ToString(rk.GetValue("Password"));
					rememberPassword = Convert.ToBoolean(rk.GetValue("RememberPassword"));
					isFirstStartup = Convert.ToBoolean(rk.GetValue("IsFirstStartup"));
					questionsFolderPath = Convert.ToString(rk.GetValue("QuestionsFolder"));
					imagesFolderPath = Convert.ToString(rk.GetValue("ImagesFolder"));
				}
			}
			finally
			{
				if (rk != null) rk.Close();
			}
		}
		static public void WriteSettings()
		{
			RegistryKey rk = null;

			try
			{
				rk = Registry.CurrentUser.CreateSubKey(regKeyName);
				if (rk == null) return;
				rk.SetValue("ExamDuration", examDuration);
				rk.SetValue("ShuffleQuestions", shuffleQuest);
				rk.SetValue("ShuffleAnswers", shuffleAnsw);
				rk.SetValue("IsTeacher", isTeacher);
				rk.SetValue("Name", name);
				rk.SetValue("Password", teacherPassword);
				rk.SetValue("RememberPassword", rememberPassword);
				rk.SetValue("IsFirstStartup", isFirstStartup);
				rk.SetValue("QuestionsFolder", questionsFolderPath);
				rk.SetValue("ImagesFolder", imagesFolderPath);
			}
			finally
			{
				if (rk != null) rk.Close();
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