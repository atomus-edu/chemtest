namespace ChemTest
{
	partial class fTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraining));
            this.btnOk = new System.Windows.Forms.Button();
            this.rbVariant1 = new System.Windows.Forms.RadioButton();
            this.rbVariant2 = new System.Windows.Forms.RadioButton();
            this.rbVariant3 = new System.Windows.Forms.RadioButton();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTimeCounter = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.pbTimer = new System.Windows.Forms.PictureBox();
            this.pbWrong = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.btnTimeStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPreTraining = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(758, 410);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(33, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // rbVariant1
            // 
            this.rbVariant1.AutoSize = true;
            this.rbVariant1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVariant1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVariant1.Location = new System.Drawing.Point(15, 225);
            this.rbVariant1.Name = "rbVariant1";
            this.rbVariant1.Size = new System.Drawing.Size(91, 25);
            this.rbVariant1.TabIndex = 3;
            this.rbVariant1.TabStop = true;
            this.rbVariant1.Text = "Variant 1";
            this.toolTip1.SetToolTip(this.rbVariant1, "Натисніть, щоб обрати цей варіант");
            this.rbVariant1.UseVisualStyleBackColor = true;
            this.rbVariant1.Visible = false;
            // 
            // rbVariant2
            // 
            this.rbVariant2.AutoSize = true;
            this.rbVariant2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVariant2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVariant2.Location = new System.Drawing.Point(15, 255);
            this.rbVariant2.Name = "rbVariant2";
            this.rbVariant2.Size = new System.Drawing.Size(91, 25);
            this.rbVariant2.TabIndex = 4;
            this.rbVariant2.TabStop = true;
            this.rbVariant2.Text = "Variant 2";
            this.toolTip1.SetToolTip(this.rbVariant2, "Натисніть, щоб обрати цей варіант");
            this.rbVariant2.UseVisualStyleBackColor = true;
            this.rbVariant2.Visible = false;
            // 
            // rbVariant3
            // 
            this.rbVariant3.AutoSize = true;
            this.rbVariant3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVariant3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVariant3.Location = new System.Drawing.Point(15, 285);
            this.rbVariant3.Name = "rbVariant3";
            this.rbVariant3.Size = new System.Drawing.Size(91, 25);
            this.rbVariant3.TabIndex = 5;
            this.rbVariant3.TabStop = true;
            this.rbVariant3.Text = "Variant 3";
            this.toolTip1.SetToolTip(this.rbVariant3, "Натисніть, щоб обрати цей варіант");
            this.rbVariant3.UseVisualStyleBackColor = true;
            this.rbVariant3.Visible = false;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrent.Location = new System.Drawing.Point(12, 420);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(23, 13);
            this.lblCurrent.TabIndex = 6;
            this.lblCurrent.Text = "0/0";
            this.toolTip1.SetToolTip(this.lblCurrent, "Номер питання");
            this.lblCurrent.Visible = false;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.BackColor = System.Drawing.SystemColors.Window;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWrong.Location = new System.Drawing.Point(584, 14);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(13, 13);
            this.lblWrong.TabIndex = 10;
            this.lblWrong.Text = "0";
            this.toolTip1.SetToolTip(this.lblWrong, "Кількість неправильних відповідей");
            this.lblWrong.Visible = false;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.SystemColors.Window;
            this.lblRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRight.Location = new System.Drawing.Point(477, 14);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(13, 13);
            this.lblRight.TabIndex = 11;
            this.lblRight.Text = "0";
            this.toolTip1.SetToolTip(this.lblRight, "Кількість правильних відповідей");
            this.lblRight.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 394);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.progressBar1, "Прогрес тесту");
            // 
            // lblTimeCounter
            // 
            this.lblTimeCounter.AutoSize = true;
            this.lblTimeCounter.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimeCounter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeCounter.Location = new System.Drawing.Point(377, 14);
            this.lblTimeCounter.Name = "lblTimeCounter";
            this.lblTimeCounter.Size = new System.Drawing.Size(22, 13);
            this.lblTimeCounter.TabIndex = 13;
            this.lblTimeCounter.Text = "0.0";
            this.toolTip1.SetToolTip(this.lblTimeCounter, "Таймер");
            this.lblTimeCounter.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.BackColor = System.Drawing.SystemColors.Window;
            this.btnReturnToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturnToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnToMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturnToMain.FlatAppearance.BorderSize = 0;
            this.btnReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMain.Location = new System.Drawing.Point(5, 5);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(33, 33);
            this.btnReturnToMain.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnReturnToMain, "Повернутись на головне меню");
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
            // 
            // pbTimer
            // 
            this.pbTimer.BackColor = System.Drawing.SystemColors.Window;
            this.pbTimer.Location = new System.Drawing.Point(351, 9);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(23, 23);
            this.pbTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTimer.TabIndex = 18;
            this.pbTimer.TabStop = false;
            this.toolTip1.SetToolTip(this.pbTimer, "Таймер");
            this.pbTimer.Visible = false;
            // 
            // pbWrong
            // 
            this.pbWrong.BackColor = System.Drawing.SystemColors.Window;
            this.pbWrong.Location = new System.Drawing.Point(558, 9);
            this.pbWrong.Name = "pbWrong";
            this.pbWrong.Size = new System.Drawing.Size(23, 23);
            this.pbWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWrong.TabIndex = 17;
            this.pbWrong.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWrong, "Кількість неправильних відповідей");
            this.pbWrong.Visible = false;
            // 
            // pbRight
            // 
            this.pbRight.BackColor = System.Drawing.SystemColors.Window;
            this.pbRight.Location = new System.Drawing.Point(451, 9);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(23, 23);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 16;
            this.pbRight.TabStop = false;
            this.toolTip1.SetToolTip(this.pbRight, "Кількість правильних відповідей");
            this.pbRight.Visible = false;
            // 
            // btnTimeStop
            // 
            this.btnTimeStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimeStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimeStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeStop.FlatAppearance.BorderSize = 0;
            this.btnTimeStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeStop.Location = new System.Drawing.Point(322, 9);
            this.btnTimeStop.Name = "btnTimeStop";
            this.btnTimeStop.Size = new System.Drawing.Size(23, 23);
            this.btnTimeStop.TabIndex = 14;
            this.btnTimeStop.Tag = "1";
            this.toolTip1.SetToolTip(this.btnTimeStop, "Зупинити/продовжити таймер");
            this.btnTimeStop.UseVisualStyleBackColor = false;
            this.btnTimeStop.Visible = false;
            this.btnTimeStop.Click += new System.EventHandler(this.btnTimeStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 19;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(15, 83);
            this.lblQuestion.Multiline = true;
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(776, 124);
            this.lblQuestion.TabIndex = 20;
            this.lblQuestion.Text = "Question ?";
            this.lblQuestion.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInfo.Location = new System.Drawing.Point(62, 420);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(665, 13);
            this.lblInfo.TabIndex = 21;
            this.lblInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPreTraining
            // 
            this.lblPreTraining.BackColor = System.Drawing.SystemColors.Control;
            this.lblPreTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPreTraining.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPreTraining.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPreTraining.Location = new System.Drawing.Point(15, 186);
            this.lblPreTraining.Name = "lblPreTraining";
            this.lblPreTraining.Size = new System.Drawing.Size(773, 26);
            this.lblPreTraining.TabIndex = 22;
            this.lblPreTraining.Text = "Theme";
            this.lblPreTraining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 1);
            this.panel2.TabIndex = 49;
            // 
            // fTraining
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnReturnToMain;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPreTraining);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.pbWrong);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.btnTimeStop);
            this.Controls.Add(this.lblTimeCounter);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.rbVariant3);
            this.Controls.Add(this.rbVariant2);
            this.Controls.Add(this.rbVariant1);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fTraining";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тренування";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTraining_FormClosing);
            this.Load += new System.EventHandler(this.fTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnReturnToMain;
		private System.Windows.Forms.RadioButton rbVariant1;
		private System.Windows.Forms.RadioButton rbVariant2;
		private System.Windows.Forms.RadioButton rbVariant3;
		private System.Windows.Forms.Label lblCurrent;
		private System.Windows.Forms.Label lblWrong;
		private System.Windows.Forms.Label lblRight;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lblTimeCounter;
		private System.Windows.Forms.Button btnTimeStop;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.PictureBox pbRight;
		private System.Windows.Forms.PictureBox pbWrong;
		private System.Windows.Forms.PictureBox pbTimer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox lblQuestion;
		private System.Windows.Forms.TextBox lblInfo;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox lblPreTraining;
        private System.Windows.Forms.Panel panel2;
    }
}