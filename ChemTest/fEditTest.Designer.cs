namespace ChemTest
{
	partial class fEditTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditTest));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbtnVar3 = new System.Windows.Forms.RadioButton();
            this.lsbxQuestions = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbxTheme = new System.Windows.Forms.TextBox();
            this.btnRmv = new System.Windows.Forms.Button();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.tbxVar3 = new System.Windows.Forms.TextBox();
            this.tbxVar2 = new System.Windows.Forms.TextBox();
            this.rbtnVar1 = new System.Windows.Forms.RadioButton();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxVar1 = new System.Windows.Forms.TextBox();
            this.cbxDifficult = new System.Windows.Forms.ComboBox();
            this.rbtnVar2 = new System.Windows.Forms.RadioButton();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxExam = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(543, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btnAdd, "Додати це питання до списку");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
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
            this.btnReturnToMain.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btnReturnToMain, "Повернутись на головне меню");
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Запитання:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(755, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(33, 33);
            this.btnSave.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnSave, "Зберегти тест");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnVar3
            // 
            this.rbtnVar3.AutoSize = true;
            this.rbtnVar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnVar3.Location = new System.Drawing.Point(12, 357);
            this.rbtnVar3.Name = "rbtnVar3";
            this.rbtnVar3.Size = new System.Drawing.Size(14, 13);
            this.rbtnVar3.TabIndex = 39;
            this.rbtnVar3.TabStop = true;
            this.toolTip1.SetToolTip(this.rbtnVar3, "Оберіть правильний варіант");
            this.rbtnVar3.UseVisualStyleBackColor = true;
            // 
            // lsbxQuestions
            // 
            this.lsbxQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lsbxQuestions.FormattingEnabled = true;
            this.lsbxQuestions.Location = new System.Drawing.Point(533, 85);
            this.lsbxQuestions.Name = "lsbxQuestions";
            this.lsbxQuestions.ScrollAlwaysVisible = true;
            this.lsbxQuestions.Size = new System.Drawing.Size(255, 353);
            this.lsbxQuestions.TabIndex = 53;
            this.lsbxQuestions.SelectedIndexChanged += new System.EventHandler(this.lsbxQuestions_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Новий тест";
            // 
            // tbxTheme
            // 
            this.tbxTheme.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTheme.Location = new System.Drawing.Point(44, 12);
            this.tbxTheme.Name = "tbxTheme";
            this.tbxTheme.Size = new System.Drawing.Size(705, 23);
            this.tbxTheme.TabIndex = 26;
            this.toolTip1.SetToolTip(this.tbxTheme, "Тему тесту");
            // 
            // btnRmv
            // 
            this.btnRmv.BackColor = System.Drawing.SystemColors.Window;
            this.btnRmv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRmv.FlatAppearance.BorderSize = 0;
            this.btnRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmv.Location = new System.Drawing.Point(579, 405);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(30, 30);
            this.btnRmv.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btnRmv, "Видалити обране питання із списку");
            this.btnRmv.UseVisualStyleBackColor = false;
            this.btnRmv.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxQuestion.Location = new System.Drawing.Point(12, 112);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(503, 125);
            this.tbxQuestion.TabIndex = 37;
            this.toolTip1.SetToolTip(this.tbxQuestion, "Напишіть запитання");
            // 
            // tbxVar3
            // 
            this.tbxVar3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxVar3.Location = new System.Drawing.Point(33, 355);
            this.tbxVar3.Name = "tbxVar3";
            this.tbxVar3.Size = new System.Drawing.Size(482, 23);
            this.tbxVar3.TabIndex = 43;
            this.toolTip1.SetToolTip(this.tbxVar3, "Напишіть варіант для запитання");
            // 
            // tbxVar2
            // 
            this.tbxVar2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxVar2.Location = new System.Drawing.Point(33, 319);
            this.tbxVar2.Name = "tbxVar2";
            this.tbxVar2.Size = new System.Drawing.Size(482, 23);
            this.tbxVar2.TabIndex = 44;
            this.toolTip1.SetToolTip(this.tbxVar2, "Напишіть варіант для запитання");
            // 
            // rbtnVar1
            // 
            this.rbtnVar1.AutoSize = true;
            this.rbtnVar1.Checked = true;
            this.rbtnVar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnVar1.Location = new System.Drawing.Point(12, 285);
            this.rbtnVar1.Name = "rbtnVar1";
            this.rbtnVar1.Size = new System.Drawing.Size(14, 13);
            this.rbtnVar1.TabIndex = 40;
            this.rbtnVar1.TabStop = true;
            this.toolTip1.SetToolTip(this.rbtnVar1, "Оберіть правильний варіант");
            this.rbtnVar1.UseVisualStyleBackColor = true;
            // 
            // cbxSubject
            // 
            this.cbxSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Items.AddRange(new object[] {
            "Хімія",
            "Фізика",
            "Біологія",
            "Укр. Мова",
            "Укр. Література",
            "Історя України",
            "Всесвітня Історія",
            "Інший"});
            this.cbxSubject.Location = new System.Drawing.Point(115, 47);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(120, 23);
            this.cbxSubject.TabIndex = 52;
            this.toolTip1.SetToolTip(this.cbxSubject, "Оберіть предмет для тесту");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(54, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Предмет:";
            // 
            // tbxVar1
            // 
            this.tbxVar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxVar1.Location = new System.Drawing.Point(33, 283);
            this.tbxVar1.Name = "tbxVar1";
            this.tbxVar1.Size = new System.Drawing.Size(482, 23);
            this.tbxVar1.TabIndex = 42;
            this.toolTip1.SetToolTip(this.tbxVar1, "Напишіть варіант для запитання");
            // 
            // cbxDifficult
            // 
            this.cbxDifficult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDifficult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDifficult.FormattingEnabled = true;
            this.cbxDifficult.Items.AddRange(new object[] {
            "Легкий",
            "Середній",
            "Важкий",
            "Дуже Складний"});
            this.cbxDifficult.Location = new System.Drawing.Point(612, 47);
            this.cbxDifficult.Name = "cbxDifficult";
            this.cbxDifficult.Size = new System.Drawing.Size(120, 23);
            this.cbxDifficult.TabIndex = 50;
            this.toolTip1.SetToolTip(this.cbxDifficult, "Оберіть складність тесту");
            // 
            // rbtnVar2
            // 
            this.rbtnVar2.AutoSize = true;
            this.rbtnVar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnVar2.Location = new System.Drawing.Point(12, 321);
            this.rbtnVar2.Name = "rbtnVar2";
            this.rbtnVar2.Size = new System.Drawing.Size(14, 13);
            this.rbtnVar2.TabIndex = 41;
            this.rbtnVar2.TabStop = true;
            this.toolTip1.SetToolTip(this.rbtnVar2, "Оберіть правильний варіант");
            this.rbtnVar2.UseVisualStyleBackColor = true;
            // 
            // cbxClass
            // 
            this.cbxClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxClass.Location = new System.Drawing.Point(353, 47);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(120, 23);
            this.cbxClass.TabIndex = 49;
            this.toolTip1.SetToolTip(this.cbxClass, "Оберіть клас для тесту");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(540, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Складність:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Варіанти відповідей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(312, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Клас:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbxTheme);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 54;
            // 
            // cbxExam
            // 
            this.cbxExam.AutoSize = true;
            this.cbxExam.Enabled = false;
            this.cbxExam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxExam.Location = new System.Drawing.Point(12, 421);
            this.cbxExam.Name = "cbxExam";
            this.cbxExam.Size = new System.Drawing.Size(120, 19);
            this.cbxExam.TabIndex = 57;
            this.cbxExam.Text = "Робота на оцінку";
            this.cbxExam.UseVisualStyleBackColor = true;
            // 
            // fEditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxExam);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnVar3);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.tbxVar3);
            this.Controls.Add(this.tbxVar2);
            this.Controls.Add(this.rbtnVar1);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxVar1);
            this.Controls.Add(this.cbxDifficult);
            this.Controls.Add(this.rbtnVar2);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsbxQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fEditTest";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати тест";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnReturnToMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.RadioButton rbtnVar3;
		private System.Windows.Forms.ListBox lsbxQuestions;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox tbxTheme;
		private System.Windows.Forms.Button btnRmv;
		private System.Windows.Forms.TextBox tbxQuestion;
		private System.Windows.Forms.TextBox tbxVar3;
		private System.Windows.Forms.TextBox tbxVar2;
		private System.Windows.Forms.RadioButton rbtnVar1;
		private System.Windows.Forms.ComboBox cbxSubject;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbxVar1;
		private System.Windows.Forms.ComboBox cbxDifficult;
		private System.Windows.Forms.RadioButton rbtnVar2;
		private System.Windows.Forms.ComboBox cbxClass;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox cbxExam;
	}
}