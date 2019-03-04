namespace ChemTest
{
	partial class fSelectTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSelectTest));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxSubject = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxDifficult = new System.Windows.Forms.ComboBox();
			this.cbxClass = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.dgwQuestions = new System.Windows.Forms.DataGridView();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.bReturnToMain = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.cbxSubject);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.bReturnToMain);
			this.panel1.Controls.Add(this.cbxDifficult);
			this.panel1.Controls.Add(this.cbxClass);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 46);
			this.panel1.TabIndex = 21;
			// 
			// cbxSubject
			// 
			this.cbxSubject.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxSubject.DisplayMember = "1";
			this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSubject.FormattingEnabled = true;
			this.cbxSubject.Items.AddRange(new object[] {
            "Будь-який",
            "Хімія",
            "Фізика",
            "Біологія",
            "Укр. Мова",
            "Укр. Література",
            "Історя України",
            "Всесвітня Історія",
            "Інший"});
			this.cbxSubject.Location = new System.Drawing.Point(252, 12);
			this.cbxSubject.Name = "cbxSubject";
			this.cbxSubject.Size = new System.Drawing.Size(120, 21);
			this.cbxSubject.TabIndex = 47;
			this.toolTip1.SetToolTip(this.cbxSubject, "Оберіть предмет для тесту");
			this.cbxSubject.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Window;
			this.label5.Location = new System.Drawing.Point(191, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 46;
			this.label5.Text = "Предмет:";
			// 
			// cbxDifficult
			// 
			this.cbxDifficult.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDifficult.FormattingEnabled = true;
			this.cbxDifficult.Items.AddRange(new object[] {
            "Будь-яка",
            "Легкий",
            "Середній",
            "Важкий",
            "Дуже Складний"});
			this.cbxDifficult.Location = new System.Drawing.Point(668, 12);
			this.cbxDifficult.Name = "cbxDifficult";
			this.cbxDifficult.Size = new System.Drawing.Size(120, 21);
			this.cbxDifficult.TabIndex = 45;
			this.toolTip1.SetToolTip(this.cbxDifficult, "Оберіть складність тесту");
			this.cbxDifficult.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
			// 
			// cbxClass
			// 
			this.cbxClass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxClass.FormattingEnabled = true;
			this.cbxClass.Items.AddRange(new object[] {
            "Будь-який",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.cbxClass.Location = new System.Drawing.Point(452, 12);
			this.cbxClass.Name = "cbxClass";
			this.cbxClass.Size = new System.Drawing.Size(120, 21);
			this.cbxClass.TabIndex = 44;
			this.toolTip1.SetToolTip(this.cbxClass, "Оберіть клас для тесту");
			this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(411, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 42;
			this.label2.Text = "Клас:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(596, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 43;
			this.label4.Text = "Складність:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(44, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 25);
			this.label1.TabIndex = 21;
			this.label1.Text = "Оберіть тест";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(48, 413);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(30, 30);
			this.button5.TabIndex = 38;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Visible = false;
			// 
			// dgwQuestions
			// 
			this.dgwQuestions.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dgwQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgwQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgwQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwQuestions.Location = new System.Drawing.Point(12, 52);
			this.dgwQuestions.MultiSelect = false;
			this.dgwQuestions.Name = "dgwQuestions";
			this.dgwQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwQuestions.Size = new System.Drawing.Size(776, 355);
			this.dgwQuestions.TabIndex = 41;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Тестові файли|*.ct|Всі файли|*.*";
			this.openFileDialog1.Title = "Оберіть файл";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.BackgroundImage = global::ChemTest.Properties.Resources.icons8_add;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(51, 412);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(33, 33);
			this.button3.TabIndex = 42;
			this.toolTip1.SetToolTip(this.button3, "Відкрити файл від учителя");
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::ChemTest.Properties.Resources.icons8_check_mark_symbol;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(755, 413);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(33, 33);
			this.button2.TabIndex = 40;
			this.toolTip1.SetToolTip(this.button2, "Продовжити");
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.BackgroundImage = global::ChemTest.Properties.Resources.icons8_add;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 412);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 33);
			this.button1.TabIndex = 37;
			this.toolTip1.SetToolTip(this.button1, "Додати інший тест в список");
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bReturnToMain
			// 
			this.bReturnToMain.BackColor = System.Drawing.SystemColors.Window;
			this.bReturnToMain.BackgroundImage = global::ChemTest.Properties.Resources.icons8_back_button;
			this.bReturnToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.bReturnToMain.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bReturnToMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bReturnToMain.FlatAppearance.BorderSize = 0;
			this.bReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bReturnToMain.Location = new System.Drawing.Point(5, 5);
			this.bReturnToMain.Name = "bReturnToMain";
			this.bReturnToMain.Size = new System.Drawing.Size(33, 33);
			this.bReturnToMain.TabIndex = 20;
			this.toolTip1.SetToolTip(this.bReturnToMain, "Повернутись на головне меню");
			this.bReturnToMain.UseVisualStyleBackColor = false;
			this.bReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
			// 
			// fSelectTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dgwQuestions);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "fSelectTest";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = " Список тестів";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button bReturnToMain;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgwQuestions;
		private System.Windows.Forms.ComboBox cbxSubject;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxDifficult;
		private System.Windows.Forms.ComboBox cbxClass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}