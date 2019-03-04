namespace ChemTest
{
	partial class fStudentExamResultViewer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgwResult = new System.Windows.Forms.DataGridView();
			this.tbxPath = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgwResult)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwResult
			// 
			this.dgwResult.AllowUserToResizeColumns = false;
			this.dgwResult.AllowUserToResizeRows = false;
			this.dgwResult.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dgwResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwResult.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgwResult.Location = new System.Drawing.Point(12, 68);
			this.dgwResult.MultiSelect = false;
			this.dgwResult.Name = "dgwResult";
			this.dgwResult.ReadOnly = true;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgwResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgwResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwResult.Size = new System.Drawing.Size(499, 355);
			this.dgwResult.TabIndex = 42;
			// 
			// tbxPath
			// 
			this.tbxPath.BackColor = System.Drawing.SystemColors.Menu;
			this.tbxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbxPath.Location = new System.Drawing.Point(12, 12);
			this.tbxPath.Multiline = true;
			this.tbxPath.Name = "tbxPath";
			this.tbxPath.Size = new System.Drawing.Size(468, 23);
			this.tbxPath.TabIndex = 43;
			// 
			// btnOpen
			// 
			this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOpen.FlatAppearance.BorderSize = 0;
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen.Location = new System.Drawing.Point(486, 12);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(25, 25);
			this.btnOpen.TabIndex = 44;
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Файл результату|*.res|Всі файли|*.*";
			this.openFileDialog1.Title = "Оберіть файл";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.tbxPath);
			this.panel1.Controls.Add(this.btnOpen);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(523, 52);
			this.panel1.TabIndex = 45;
			// 
			// fStudentExamResultViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(523, 435);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgwResult);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fStudentExamResultViewer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Результат";
			this.Load += new System.EventHandler(this.fStudentExamResultViewer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwResult)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwResult;
		private System.Windows.Forms.TextBox tbxPath;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
	}
}