namespace ChemTest
{
	partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRandomAnsw = new System.Windows.Forms.CheckBox();
            this.cbRandomQuest = new System.Windows.Forms.CheckBox();
            this.lblExamDuration = new System.Windows.Forms.Label();
            this.cbExamDuration = new System.Windows.Forms.ComboBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCheckStudent = new System.Windows.Forms.Button();
            this.btnUpdateQuestionsList = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbxQuestions = new System.Windows.Forms.ListBox();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetToDefaults = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOk.Location = new System.Drawing.Point(292, 5);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "OK";
            this.toolTip1.SetToolTip(this.bOk, "Зберегти налаштування");
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(211, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Скасувати";
            this.toolTip1.SetToolTip(this.bCancel, "Скасувати всі налаштування");
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRandomAnsw);
            this.groupBox1.Controls.Add(this.cbRandomQuest);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перемішувати";
            this.toolTip1.SetToolTip(this.groupBox1, "Перемішувати питання та відповіді для більш  складнішого проходження тесту");
            // 
            // cbRandomAnsw
            // 
            this.cbRandomAnsw.AutoSize = true;
            this.cbRandomAnsw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRandomAnsw.Location = new System.Drawing.Point(7, 43);
            this.cbRandomAnsw.Name = "cbRandomAnsw";
            this.cbRandomAnsw.Size = new System.Drawing.Size(69, 17);
            this.cbRandomAnsw.TabIndex = 1;
            this.cbRandomAnsw.Text = "Відповіді";
            this.toolTip1.SetToolTip(this.cbRandomAnsw, "Відтворювати варіанти відповідей у видковому порядку");
            this.cbRandomAnsw.UseVisualStyleBackColor = true;
            // 
            // cbRandomQuest
            // 
            this.cbRandomQuest.AutoSize = true;
            this.cbRandomQuest.BackColor = System.Drawing.SystemColors.Window;
            this.cbRandomQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRandomQuest.Location = new System.Drawing.Point(7, 20);
            this.cbRandomQuest.Name = "cbRandomQuest";
            this.cbRandomQuest.Size = new System.Drawing.Size(69, 17);
            this.cbRandomQuest.TabIndex = 0;
            this.cbRandomQuest.Text = "Питання";
            this.toolTip1.SetToolTip(this.cbRandomQuest, "Відтворювати питання у видкавовому порядку");
            this.cbRandomQuest.UseVisualStyleBackColor = false;
            // 
            // lblExamDuration
            // 
            this.lblExamDuration.AutoSize = true;
            this.lblExamDuration.Location = new System.Drawing.Point(7, 83);
            this.lblExamDuration.Name = "lblExamDuration";
            this.lblExamDuration.Size = new System.Drawing.Size(118, 13);
            this.lblExamDuration.TabIndex = 4;
            this.lblExamDuration.Text = "Тривалість екзамену:";
            this.toolTip1.SetToolTip(this.lblExamDuration, "Максимальний час для проходження екзамену");
            // 
            // cbExamDuration
            // 
            this.cbExamDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbExamDuration.FormattingEnabled = true;
            this.cbExamDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "15",
            "20",
            "45"});
            this.cbExamDuration.Location = new System.Drawing.Point(128, 80);
            this.cbExamDuration.Name = "cbExamDuration";
            this.cbExamDuration.Size = new System.Drawing.Size(40, 21);
            this.cbExamDuration.TabIndex = 5;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(174, 83);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(21, 13);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "хв.";
            // 
            // btnCheckStudent
            // 
            this.btnCheckStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckStudent.FlatAppearance.BorderSize = 0;
            this.btnCheckStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStudent.Location = new System.Drawing.Point(315, 43);
            this.btnCheckStudent.Name = "btnCheckStudent";
            this.btnCheckStudent.Size = new System.Drawing.Size(46, 46);
            this.btnCheckStudent.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnCheckStudent, "Перевірити роботу учня");
            this.btnCheckStudent.UseVisualStyleBackColor = true;
            this.btnCheckStudent.Click += new System.EventHandler(this.btnCheckStudent_Click);
            // 
            // btnUpdateQuestionsList
            // 
            this.btnUpdateQuestionsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateQuestionsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuestionsList.FlatAppearance.BorderSize = 0;
            this.btnUpdateQuestionsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuestionsList.Location = new System.Drawing.Point(345, 8);
            this.btnUpdateQuestionsList.Name = "btnUpdateQuestionsList";
            this.btnUpdateQuestionsList.Size = new System.Drawing.Size(20, 20);
            this.btnUpdateQuestionsList.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnUpdateQuestionsList, "Оновити список");
            this.btnUpdateQuestionsList.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 354);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblExamDuration);
            this.tabPage1.Controls.Add(this.lblMin);
            this.tabPage1.Controls.Add(this.cbExamDuration);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Тестування";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateQuestionsList);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lsbxQuestions);
            this.tabPage2.Controls.Add(this.tbxPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Питання";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шлях:";
            // 
            // lsbxQuestions
            // 
            this.lsbxQuestions.BackColor = System.Drawing.SystemColors.Window;
            this.lsbxQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbxQuestions.FormattingEnabled = true;
            this.lsbxQuestions.Location = new System.Drawing.Point(9, 34);
            this.lsbxQuestions.Name = "lsbxQuestions";
            this.lsbxQuestions.ScrollAlwaysVisible = true;
            this.lsbxQuestions.Size = new System.Drawing.Size(356, 288);
            this.lsbxQuestions.TabIndex = 7;
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(48, 9);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(291, 20);
            this.tbxPath.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCheckStudent);
            this.tabPage4.Controls.Add(this.cbRemember);
            this.tabPage4.Controls.Add(this.tbxPassword);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.tbxName);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.lblUserType);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btnResetToDefaults);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(375, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Користувач";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Location = new System.Drawing.Point(117, 95);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(128, 17);
            this.cbRemember.TabIndex = 19;
            this.cbRemember.Text = "Запам\'ятати пароль";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(78, 69);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(224, 20);
            this.tbxPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(78, 43);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(224, 20);
            this.tbxName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Повне ім\'я:";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserType.Location = new System.Drawing.Point(140, 13);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(75, 21);
            this.lblUserType.TabIndex = 2;
            this.lblUserType.Text = "Вчитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип облікового запису:";
            // 
            // btnResetToDefaults
            // 
            this.btnResetToDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetToDefaults.Location = new System.Drawing.Point(103, 274);
            this.btnResetToDefaults.Name = "btnResetToDefaults";
            this.btnResetToDefaults.Size = new System.Drawing.Size(165, 23);
            this.btnResetToDefaults.TabIndex = 0;
            this.btnResetToDefaults.Text = "Скинути всі налаштування";
            this.btnResetToDefaults.UseVisualStyleBackColor = true;
            this.btnResetToDefaults.Click += new System.EventHandler(this.btnResetToDefaults_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Тестові файли|*.ct|Всі файли|*.*";
            this.openFileDialog1.Title = "Оберіть файл";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bOk);
            this.panel1.Location = new System.Drawing.Point(2, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 45);
            this.panel1.TabIndex = 12;
            // 
            // fSettings
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(381, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbRandomQuest;
		private System.Windows.Forms.CheckBox cbRandomAnsw;
		private System.Windows.Forms.Label lblExamDuration;
		private System.Windows.Forms.ComboBox cbExamDuration;
		private System.Windows.Forms.Label lblMin;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnUpdateQuestionsList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lsbxQuestions;
		private System.Windows.Forms.TextBox tbxPath;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnResetToDefaults;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblUserType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbRemember;
		private System.Windows.Forms.Button btnCheckStudent;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
	}
}