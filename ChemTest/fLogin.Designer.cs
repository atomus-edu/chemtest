namespace ChemTest
{
	partial class fLogin
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
			this.lblTop = new System.Windows.Forms.Label();
			this.btnStudent = new System.Windows.Forms.Button();
			this.btnTeacher = new System.Windows.Forms.Button();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.cbRemember = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTop.Location = new System.Drawing.Point(133, 18);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(67, 21);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "Хто ви?";
			// 
			// btnStudent
			// 
			this.btnStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStudent.FlatAppearance.BorderSize = 0;
			this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnStudent.Location = new System.Drawing.Point(105, 60);
			this.btnStudent.Name = "btnStudent";
			this.btnStudent.Size = new System.Drawing.Size(118, 23);
			this.btnStudent.TabIndex = 12;
			this.btnStudent.Text = "Учень";
			this.btnStudent.UseVisualStyleBackColor = false;
			this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
			// 
			// btnTeacher
			// 
			this.btnTeacher.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTeacher.FlatAppearance.BorderSize = 0;
			this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTeacher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnTeacher.Location = new System.Drawing.Point(105, 89);
			this.btnTeacher.Name = "btnTeacher";
			this.btnTeacher.Size = new System.Drawing.Size(118, 23);
			this.btnTeacher.TabIndex = 11;
			this.btnTeacher.Text = "Вчитель";
			this.btnTeacher.UseVisualStyleBackColor = false;
			this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
			// 
			// tbxName
			// 
			this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbxName.Location = new System.Drawing.Point(91, 60);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(221, 20);
			this.tbxName.TabIndex = 13;
			this.tbxName.Visible = false;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(25, 62);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(60, 13);
			this.lblName.TabIndex = 14;
			this.lblName.Text = "Повне ім\'я";
			this.lblName.Visible = false;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(25, 91);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(45, 13);
			this.lblPassword.TabIndex = 16;
			this.lblPassword.Text = "Пароль";
			this.lblPassword.Visible = false;
			// 
			// tbxPassword
			// 
			this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbxPassword.Location = new System.Drawing.Point(91, 89);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(221, 20);
			this.tbxPassword.TabIndex = 15;
			this.tbxPassword.Visible = false;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOK.FlatAppearance.BorderSize = 0;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnOK.Location = new System.Drawing.Point(105, 141);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(118, 23);
			this.btnOK.TabIndex = 17;
			this.btnOK.Text = "Далі";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Visible = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cbRemember
			// 
			this.cbRemember.AutoSize = true;
			this.cbRemember.Location = new System.Drawing.Point(5, 147);
			this.cbRemember.Name = "cbRemember";
			this.cbRemember.Size = new System.Drawing.Size(89, 17);
			this.cbRemember.TabIndex = 18;
			this.cbRemember.Text = "Запам\'ятати";
			this.cbRemember.UseVisualStyleBackColor = true;
			// 
			// fLogin
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(324, 176);
			this.Controls.Add(this.cbRemember);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.tbxPassword);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.btnStudent);
			this.Controls.Add(this.btnTeacher);
			this.Controls.Add(this.lblTop);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fLogin";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вхід";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Button btnStudent;
		private System.Windows.Forms.Button btnTeacher;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox cbRemember;
	}
}