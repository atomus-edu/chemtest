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
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.cbxDifficult = new System.Windows.Forms.ComboBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwQuestions = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.cbxSubject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnReturnToMain);
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
            this.btnReturnToMain.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnReturnToMain, "Повернутись на головне меню");
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
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
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(51, 412);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(33, 33);
            this.btnOpen.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btnOpen, "Відкрити файл від учителя");
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(755, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(33, 33);
            this.btnOK.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btnOK, "Продовжити");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(12, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 33);
            this.btnAdd.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnAdd, "Додати інший тест в список");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
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
            // fSelectTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dgwQuestions);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
		private System.Windows.Forms.Button btnReturnToMain;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgwQuestions;
		private System.Windows.Forms.ComboBox cbxSubject;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxDifficult;
		private System.Windows.Forms.ComboBox cbxClass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}