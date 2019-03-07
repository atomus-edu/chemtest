using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChemTest
{
    public partial class fTraining : Form
	{
		public Training t;
		int timerMinCounter = 0;
		int timerSecCounter = 0;
		public Questions q;

		public fTraining()
		{
			InitializeComponent();
			t = new Training();
			q = new Questions();

            // initial images
            btnTimeStop.BackgroundImage = Image.FromFile(@"sys\img\btn\pause.png");
            btnReturnToMain.BackgroundImage = Image.FromFile(@"sys\img\btn\back.png");
            btnOk.BackgroundImage = Image.FromFile(@"sys\img\btn\next.png");
            pbTimer.Image = Image.FromFile(@"sys\img\btn\stopwatch.png");
            pbRight.Image = Image.FromFile(@"sys\img\btn\ok.png");
            pbWrong.Image = Image.FromFile(@"sys\img\btn\delete.png");
        }
        private void fTraining_Load(object sender, EventArgs e)
        {
            t = new Training();
            t.tasks = q.tasks;
            t.Shuffle();
            lblPreTraining.Text = $"{q.Theme}";
        }

        // set default elements to default position after exit
        private void DefaultPosition()
		{
			// unchecking variants
			rbVariant1.Checked = false;
			rbVariant2.Checked = false;
			rbVariant3.Checked = false;

			// hide all items (counters, question and variants)
			lblQuestion.Visible = false;
			rbVariant1.Visible = false;
			rbVariant2.Visible = false;
			rbVariant3.Visible = false;

			lblCurrent.Visible = false;
			btnTimeStop.Visible = false;
			lblTimeCounter.Visible = false;
			lblRight.Visible = false;
			lblWrong.Visible = false;
			lblInfo.Visible = false;

			pbTimer.Visible = false;
			pbRight.Visible = false;
			pbWrong.Visible = false;

			lblPreTraining.Visible = true;
		}

		private void bOk_Click(object sender, EventArgs e)
		{
			lblPreTraining.Visible = false;
			progressBar1.Maximum = t.tasks.Count;
			progressBar1.Minimum = 0;
			timer.Start();

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
				btnTimeStop.Visible = true;
				lblTimeCounter.Visible = true;
				lblRight.Visible = true;
				lblWrong.Visible = true;
				lblInfo.Visible = true;

				pbTimer.Visible = true;
				pbRight.Visible = true;
				pbWrong.Visible = true;

				// do this while tasks doesn't ends
				if (t.Current < t.tasks.Count)
				{
					// run function "EnterVariant" with selected variant on argument
					if (rbVariant1.Checked)
					{
						// if select variants is right
						if (t.EnterVariant(rbVariant1.Text))
						{
							lblInfo.ForeColor = Color.Green;
							lblInfo.Text = "Правильно!";
						}
						else
						{
							lblInfo.ForeColor = Color.Red;
							lblInfo.Text = "Не правильно! Правильна відповідь: " + t.tasks[t.Current - 1].Answer;
						}
					}
					else if (rbVariant2.Checked)
					{
						// if select variants is right
						if (t.EnterVariant(rbVariant2.Text))
						{
							lblInfo.ForeColor = Color.Green;
							lblInfo.Text = "Правильно!";
						}
						else
						{
							lblInfo.ForeColor = Color.Red;
							lblInfo.Text = "Не правильно! Правильна відповідь: " + t.tasks[t.Current - 1].Answer;
						}
					}
					else if (rbVariant3.Checked)
					{
						// if select variants is right
						if (t.EnterVariant(rbVariant3.Text))
						{
							lblInfo.ForeColor = Color.Green;
							lblInfo.Text = "Правильно!";
						}
						else
						{
							lblInfo.ForeColor = Color.Red;
							lblInfo.Text = "Не правильно! Правильна відповідь: " + t.tasks[t.Current - 1].Answer;
						}
					}

					if (t.Current != 0) progressBar1.PerformStep();
					else
					{
						timerMinCounter = 0;
						timerSecCounter = 0;
					}

					// unchecking variants
					rbVariant1.Checked = false;
					rbVariant2.Checked = false;
					rbVariant3.Checked = false;

					// set/update value of counter
					lblCurrent.Text = Convert.ToString(t.Current + 1) + "/" + Convert.ToString(t.tasks.Count);

					// put strings from "tasks" to screen
					lblQuestion.Text = t.tasks[t.Current].Question;
					rbVariant1.Text = t.tasks[t.Current].Variant1;
					rbVariant2.Text = t.tasks[t.Current].Variant2;
					rbVariant3.Text = t.tasks[t.Current].Variant3;

					t.Current++;
					lblRight.Text = $"{t.RightAnsw}";
					lblWrong.Text = $"{t.WrongAnsw}";
				}
				else if(t.Current == t.tasks.Count)// if last question
				{
					// run function "EnterVariant" with selected variant on argument
					if (rbVariant1.Checked)
					{
						// if select variants is right
						if (t.EnterVariant(rbVariant1.Text))
						{
							lblInfo.ForeColor = Color.Green;
							lblInfo.Text = "Правильно!";
						}
						else
						{
							lblInfo.ForeColor = Color.Red;
							lblInfo.Text = "Не правильно! Правильна відповідь: " + t.tasks[t.Current - 1].Answer;
						}
					}
					else if (rbVariant2.Checked)
					{
						// if select variants is right
						if (t.EnterVariant(rbVariant2.Text))
						{
							lblInfo.ForeColor = Color.Green;
							lblInfo.Text = "Правильно!";
						}
						else
						{
							lblInfo.ForeColor = Color.Red;
							lblInfo.Text = "Не правильно! Правильна відповідь: " + t.tasks[t.Current - 1].Answer;
						}
					}
					else if (rbVariant3.Checked)
					{
						// if select variants is right
						if (t.EnterVariant(rbVariant3.Text))
						{
							lblInfo.ForeColor = Color.Green;
							lblInfo.Text = "Правильно!";
						}
						else
						{
							lblInfo.ForeColor = Color.Red;
							lblInfo.Text = "Не правильно! Правильна відповідь: " + t.tasks[t.Current - 1].Answer;
						}
					}

					lblRight.Text = $"Правильно: {t.RightAnsw}";
					lblWrong.Text = $"Неправильно: {t.WrongAnsw}";
					progressBar1.PerformStep();

					timer.Stop();
					// show total result message
					MessageBox.Show($"Ваш час: {timerMinCounter}.{timerSecCounter} хв.\n" + t.GetResult(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.None);
					DefaultPosition();
					// finaly, close window "Training"
					Close();
				}
			}
		}

		private void bReturnToMain_Click(object sender, EventArgs e)
		{
			DefaultPosition();
			timer.Stop();
			Close();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if(timerSecCounter < 60)
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

		private void btnTimeStop_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(btnTimeStop.Tag) == 1)//plays
			{
				btnTimeStop.BackgroundImage = Image.FromFile(@"sys\img\btn\play.png");
				lblTimeCounter.Enabled = false;

				btnTimeStop.Tag = 0;
				timer.Stop();
			}
			else if(Convert.ToInt32(btnTimeStop.Tag) == 0)//on pause
			{
				btnTimeStop.BackgroundImage = Image.FromFile(@"sys\img\btn\pause.png");
                lblTimeCounter.Enabled = true;

				btnTimeStop.Tag = 1;
				timer.Start();
			}
		}

		private void fTraining_FormClosing(object sender, FormClosingEventArgs e)
		{
			DefaultPosition();
			timer.Stop();
			lblTimeCounter.Text = "-.-";
			progressBar1.Value = 0;
			lblInfo.Text = "";
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