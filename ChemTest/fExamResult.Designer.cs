namespace ChemTest
{
	partial class fExamResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fExamResult));
            this.button1 = new System.Windows.Forms.Button();
            this.pbStars = new System.Windows.Forms.PictureBox();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(293, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbStars
            // 
            this.pbStars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStars.Image = ((System.Drawing.Image)(resources.GetObject("pbStars.Image")));
            this.pbStars.Location = new System.Drawing.Point(0, 42);
            this.pbStars.Name = "pbStars";
            this.pbStars.Size = new System.Drawing.Size(380, 81);
            this.pbStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStars.TabIndex = 1;
            this.pbStars.TabStop = false;
            // 
            // tbxText
            // 
            this.tbxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxText.Location = new System.Drawing.Point(12, 129);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(356, 54);
            this.tbxText.TabIndex = 3;
            this.tbxText.Text = "Щоб пройти екзамен потрiбно правильно вiдповiсти на 80% питань і впоратись вчасно" +
    "";
            this.tbxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTitle
            // 
            this.tbxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTitle.Location = new System.Drawing.Point(12, 3);
            this.tbxTitle.Multiline = true;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(356, 35);
            this.tbxTitle.TabIndex = 4;
            this.tbxTitle.Text = "Екзамен пройдено!";
            this.tbxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кiлькiсть правильних вiдповiдей: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кiлькiсть неправильних вiдповiдей: ";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRight.Location = new System.Drawing.Point(308, 245);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(59, 17);
            this.lblRight.TabIndex = 7;
            this.lblRight.Text = "8 (100%)";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWrong.Location = new System.Drawing.Point(308, 269);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(45, 17);
            this.lblWrong.TabIndex = 8;
            this.lblWrong.Text = "0 (0%)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(308, 220);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 17);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "1:35";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ваш час:";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMark.Location = new System.Drawing.Point(308, 197);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(22, 17);
            this.lblMark.TabIndex = 12;
            this.lblMark.Text = "12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ваша оцінка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(344, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "хв.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Зберегти файл";
            // 
            // fExamResult
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(380, 368);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbStars);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fExamResult";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pbStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pbStars;
		private System.Windows.Forms.TextBox tbxText;
		private System.Windows.Forms.TextBox tbxTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRight;
		private System.Windows.Forms.Label lblWrong;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblMark;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}