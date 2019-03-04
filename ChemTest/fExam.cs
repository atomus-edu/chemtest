using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemTest
{
	public partial class fExam : Form
	{
		public Exam ex;
		int timerMinCounter = 0;
		int timerSecCounter = 0;
		public Questions q;


		bool withFile;
		public fExam(bool withFile)
		{
			InitializeComponent();
			ex = new Exam();
			q = new Questions();

			this.withFile = withFile;
		}
		private void fExam_Load(object sender, EventArgs e)
		{
			progressBar1.Value = 0;
			ex = new Exam();
			ex.tasks = q.tasks;
			ex.Shuffle();
		}

		private void bOk_Click(object sender, EventArgs ea)
		{
			
			lblPreExam.Visible = false;
			bReturnToMain.Visible = false;

			progressBar1.Maximum = ex.tasks.Count;
			progressBar1.Minimum = 0;
			timer.Start();
			pbTimer.Visible = true;

			// if no one radio button is checked and question is visible
			if (!rbVariant1.Checked && !rbVariant2.Checked && !rbVariant3.Checked && lblQuestion.Visible)
			{
				timer.Stop();
				// then show warning message
				MessageBox.Show("Оберіть один за поданих варіантів.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				timer.Start();
			}
			else// if variant was selected
			{
				// show all items (counter, question and variants)
				lblQuestion.Visible = true;
				rbVariant1.Visible = true;
				rbVariant2.Visible = true;
				rbVariant3.Visible = true;

				lblCurrent.Visible = true;
				lblTimeCounter.Visible = true;

				// do this while tasks doesn't ends
				if (ex.Current < ex.tasks.Count)
				{
					// run function "EnterVariant" with selected variant on argument
					if (rbVariant1.Checked)
						ex.EnterVariant(rbVariant1.Text);
					else if (rbVariant2.Checked)
						ex.EnterVariant(rbVariant2.Text);
					else if (rbVariant3.Checked)
						ex.EnterVariant(rbVariant3.Text);

					if (ex.Current != 0) progressBar1.PerformStep();

					// unchecking variants
					rbVariant1.Checked = false;
					rbVariant2.Checked = false;
					rbVariant3.Checked = false;

					// set/update value of counter
					lblCurrent.Text = Convert.ToString(ex.Current + 1) + "/" + Convert.ToString(ex.tasks.Count);

					// put strings from "tasks" to screen
					lblQuestion.Text = ex.tasks[ex.Current].Question;
					rbVariant1.Text = ex.tasks[ex.Current].Variant1;
					rbVariant2.Text = ex.tasks[ex.Current].Variant2;
					rbVariant3.Text = ex.tasks[ex.Current].Variant3;

					ex.Current++;
				}
				else if (ex.Current == ex.tasks.Count)// if last question
				{
					// run function "EnterVariant" with selected variant on argument
					if (rbVariant1.Checked)
						ex.EnterVariant(rbVariant1.Text);
					else if (rbVariant2.Checked)
						ex.EnterVariant(rbVariant2.Text);
					else if (rbVariant3.Checked)
						ex.EnterVariant(rbVariant3.Text);

					progressBar1.PerformStep();
					timer.Stop();
					// show total result message
					ex.GetResult(timerMinCounter, timerSecCounter, withFile);
					//MessageBox.Show($"Ваш час: {timerMinCounter}.{timerSecCounter} хв.\n" + ex.GetResult(timerMinCounter, timerSecCounter), "Результат", MessageBoxButtons.OK, MessageBoxIcon.None);

					// unchecking variants
					rbVariant1.Checked = false;
					rbVariant2.Checked = false;
					rbVariant3.Checked = false;

					// hide all items (counter, question and variants)
					lblQuestion.Visible = false;
					rbVariant1.Visible = false;
					rbVariant2.Visible = false;
					rbVariant3.Visible = false;

					lblCurrent.Visible = false;
					lblTimeCounter.Visible = false;

					lblPreExam.Visible = true;
					bReturnToMain.Visible = true;
					pbTimer.Visible = false;

					lblTimeCounter.Text = "0.0";

					// finaly, close window "Training"
					Close();
				}
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (timerSecCounter < 60)
			{
				timerSecCounter++;
			}
			else
			{
				timerMinCounter++;
				timerSecCounter = 0;
			}
			lblTimeCounter.Text = $"{timerMinCounter}.{timerSecCounter}";
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