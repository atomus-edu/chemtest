namespace ChemTest
{
	partial class fExam
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fExam));
			this.bOk = new System.Windows.Forms.Button();
			this.lblPreExam = new System.Windows.Forms.Label();
			this.lblCurrent = new System.Windows.Forms.Label();
			this.rbVariant3 = new System.Windows.Forms.RadioButton();
			this.rbVariant2 = new System.Windows.Forms.RadioButton();
			this.rbVariant1 = new System.Windows.Forms.RadioButton();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.pbTimer = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bReturnToMain = new System.Windows.Forms.Button();
			this.lblTimeCounter = new System.Windows.Forms.Label();
			this.lblQuestion = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbTimer)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bOk
			// 
			this.bOk.BackgroundImage = global::ChemTest.Properties.Resources.icons8_next_button;
			this.bOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.bOk.FlatAppearance.BorderSize = 0;
			this.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bOk.Location = new System.Drawing.Point(758, 410);
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size(33, 33);
			this.bOk.TabIndex = 0;
			this.bOk.UseVisualStyleBackColor = true;
			this.bOk.Click += new System.EventHandler(this.bOk_Click);
			// 
			// lblPreExam
			// 
			this.lblPreExam.AutoSize = true;
			this.lblPreExam.Location = new System.Drawing.Point(263, 194);
			this.lblPreExam.Name = "lblPreExam";
			this.lblPreExam.Size = new System.Drawing.Size(250, 13);
			this.lblPreExam.TabIndex = 17;
			this.lblPreExam.Text = "Натисніть ОК, щоб розпочати контрольний тест";
			// 
			// lblCurrent
			// 
			this.lblCurrent.AutoSize = true;
			this.lblCurrent.Location = new System.Drawing.Point(12, 420);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.Size = new System.Drawing.Size(24, 13);
			this.lblCurrent.TabIndex = 14;
			this.lblCurrent.Text = "0/0";
			this.toolTip1.SetToolTip(this.lblCurrent, "Номер питання");
			this.lblCurrent.Visible = false;
			// 
			// rbVariant3
			// 
			this.rbVariant3.AutoSize = true;
			this.rbVariant3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbVariant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbVariant3.Location = new System.Drawing.Point(15, 285);
			this.rbVariant3.Name = "rbVariant3";
			this.rbVariant3.Size = new System.Drawing.Size(91, 24);
			this.rbVariant3.TabIndex = 13;
			this.rbVariant3.TabStop = true;
			this.rbVariant3.Text = "Variant 3";
			this.toolTip1.SetToolTip(this.rbVariant3, "Натисніть, щоб обрати цей варіант");
			this.rbVariant3.UseVisualStyleBackColor = true;
			this.rbVariant3.Visible = false;
			// 
			// rbVariant2
			// 
			this.rbVariant2.AutoSize = true;
			this.rbVariant2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbVariant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbVariant2.Location = new System.Drawing.Point(15, 255);
			this.rbVariant2.Name = "rbVariant2";
			this.rbVariant2.Size = new System.Drawing.Size(91, 24);
			this.rbVariant2.TabIndex = 12;
			this.rbVariant2.TabStop = true;
			this.rbVariant2.Text = "Variant 2";
			this.toolTip1.SetToolTip(this.rbVariant2, "Натисніть, щоб обрати цей варіант");
			this.rbVariant2.UseVisualStyleBackColor = true;
			this.rbVariant2.Visible = false;
			// 
			// rbVariant1
			// 
			this.rbVariant1.AutoSize = true;
			this.rbVariant1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbVariant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbVariant1.Location = new System.Drawing.Point(15, 225);
			this.rbVariant1.Name = "rbVariant1";
			this.rbVariant1.Size = new System.Drawing.Size(91, 24);
			this.rbVariant1.TabIndex = 11;
			this.rbVariant1.TabStop = true;
			this.rbVariant1.Text = "Variant 1";
			this.toolTip1.SetToolTip(this.rbVariant1, "Натисніть, щоб обрати цей варіант");
			this.rbVariant1.UseVisualStyleBackColor = true;
			this.rbVariant1.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 394);
			this.progressBar1.MarqueeAnimationSpeed = 50;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(776, 10);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 19;
			this.toolTip1.SetToolTip(this.progressBar1, "Прогрес тесту");
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// pbTimer
			// 
			this.pbTimer.BackColor = System.Drawing.SystemColors.Window;
			this.pbTimer.Image = global::ChemTest.Properties.Resources.stopwatch;
			this.pbTimer.InitialImage = null;
			this.pbTimer.Location = new System.Drawing.Point(351, 9);
			this.pbTimer.Name = "pbTimer";
			this.pbTimer.Size = new System.Drawing.Size(23, 23);
			this.pbTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTimer.TabIndex = 21;
			this.pbTimer.TabStop = false;
			this.toolTip1.SetToolTip(this.pbTimer, "Таймер");
			this.pbTimer.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.bReturnToMain);
			this.panel1.Controls.Add(this.lblTimeCounter);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 46);
			this.panel1.TabIndex = 22;
			// 
			// bReturnToMain
			// 
			this.bReturnToMain.BackColor = System.Drawing.SystemColors.Window;
			this.bReturnToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bReturnToMain.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bReturnToMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bReturnToMain.FlatAppearance.BorderSize = 0;
			this.bReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bReturnToMain.Location = new System.Drawing.Point(5, 5);
			this.bReturnToMain.Name = "bReturnToMain";
			this.bReturnToMain.Size = new System.Drawing.Size(33, 33);
			this.bReturnToMain.TabIndex = 23;
			this.bReturnToMain.UseVisualStyleBackColor = false;
			// 
			// lblTimeCounter
			// 
			this.lblTimeCounter.AutoSize = true;
			this.lblTimeCounter.Location = new System.Drawing.Point(377, 14);
			this.lblTimeCounter.Name = "lblTimeCounter";
			this.lblTimeCounter.Size = new System.Drawing.Size(22, 13);
			this.lblTimeCounter.TabIndex = 20;
			this.lblTimeCounter.Text = "0.0";
			this.toolTip1.SetToolTip(this.lblTimeCounter, "Таймер");
			this.lblTimeCounter.Visible = false;
			// 
			// lblQuestion
			// 
			this.lblQuestion.BackColor = System.Drawing.SystemColors.Control;
			this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblQuestion.Location = new System.Drawing.Point(15, 83);
			this.lblQuestion.Multiline = true;
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(776, 124);
			this.lblQuestion.TabIndex = 23;
			this.lblQuestion.Text = "Question ?";
			this.lblQuestion.Visible = false;
			// 
			// fExam
			// 
			this.AcceptButton = this.bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbTimer);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lblPreExam);
			this.Controls.Add(this.lblCurrent);
			this.Controls.Add(this.rbVariant3);
			this.Controls.Add(this.rbVariant2);
			this.Controls.Add(this.rbVariant1);
			this.Controls.Add(this.bOk);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblQuestion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "fExam";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Екзамен";
			this.Load += new System.EventHandler(this.fExam_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbTimer)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Label lblPreExam;
		private System.Windows.Forms.Label lblCurrent;
		private System.Windows.Forms.RadioButton rbVariant3;
		private System.Windows.Forms.RadioButton rbVariant2;
		private System.Windows.Forms.RadioButton rbVariant1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.PictureBox pbTimer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTimeCounter;
		private System.Windows.Forms.Button bReturnToMain;
		private System.Windows.Forms.TextBox lblQuestion;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}