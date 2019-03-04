namespace ChemTest
{
	partial class fMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.bExam = new System.Windows.Forms.Button();
			this.bTraining = new System.Windows.Forms.Button();
			this.bHowToUse = new System.Windows.Forms.Button();
			this.bAboutUs = new System.Windows.Forms.Button();
			this.bExit = new System.Windows.Forms.Button();
			this.lblVersion = new System.Windows.Forms.Label();
			this.bSettings = new System.Windows.Forms.Button();
			this.btnAddQuestions = new System.Windows.Forms.Button();
			this.pbTraining = new System.Windows.Forms.PictureBox();
			this.pbExam = new System.Windows.Forms.PictureBox();
			this.pbCreate = new System.Windows.Forms.PictureBox();
			this.pbSettings = new System.Windows.Forms.PictureBox();
			this.pbHowToUse = new System.Windows.Forms.PictureBox();
			this.pbAbout = new System.Windows.Forms.PictureBox();
			this.pbExit = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnBackToMenu = new System.Windows.Forms.Button();
			this.btnNewTest = new System.Windows.Forms.Button();
			this.btnEditTest = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.pbBackground = new System.Windows.Forms.PictureBox();
			this.pbBack = new System.Windows.Forms.PictureBox();
			this.pbNewTest = new System.Windows.Forms.PictureBox();
			this.pbEditTest = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbTraining)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExam)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCreate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHowToUse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNewTest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEditTest)).BeginInit();
			this.SuspendLayout();
			// 
			// bExam
			// 
			this.bExam.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bExam.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bExam.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.bExam, "bExam");
			this.bExam.Name = "bExam";
			this.toolTip1.SetToolTip(this.bExam, resources.GetString("bExam.ToolTip"));
			this.bExam.UseVisualStyleBackColor = false;
			this.bExam.Click += new System.EventHandler(this.bExam_Click);
			// 
			// bTraining
			// 
			this.bTraining.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bTraining.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bTraining.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.bTraining, "bTraining");
			this.bTraining.Name = "bTraining";
			this.toolTip1.SetToolTip(this.bTraining, resources.GetString("bTraining.ToolTip"));
			this.bTraining.UseVisualStyleBackColor = false;
			this.bTraining.Click += new System.EventHandler(this.bTraining_Click);
			// 
			// bHowToUse
			// 
			this.bHowToUse.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bHowToUse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bHowToUse.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.bHowToUse, "bHowToUse");
			this.bHowToUse.Name = "bHowToUse";
			this.toolTip1.SetToolTip(this.bHowToUse, resources.GetString("bHowToUse.ToolTip"));
			this.bHowToUse.UseVisualStyleBackColor = false;
			this.bHowToUse.Click += new System.EventHandler(this.bHowToUse_Click);
			// 
			// bAboutUs
			// 
			this.bAboutUs.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bAboutUs.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.bAboutUs, "bAboutUs");
			this.bAboutUs.Name = "bAboutUs";
			this.toolTip1.SetToolTip(this.bAboutUs, resources.GetString("bAboutUs.ToolTip"));
			this.bAboutUs.UseVisualStyleBackColor = false;
			this.bAboutUs.Click += new System.EventHandler(this.bAboutUs_Click);
			// 
			// bExit
			// 
			this.bExit.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bExit.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.bExit, "bExit");
			this.bExit.Name = "bExit";
			this.toolTip1.SetToolTip(this.bExit, resources.GetString("bExit.ToolTip"));
			this.bExit.UseVisualStyleBackColor = false;
			this.bExit.Click += new System.EventHandler(this.bExit_Click);
			this.bExit.MouseEnter += new System.EventHandler(this.bExit_MouseEnter);
			this.bExit.MouseLeave += new System.EventHandler(this.bExit_MouseLeave);
			// 
			// lblVersion
			// 
			resources.ApplyResources(this.lblVersion, "lblVersion");
			this.lblVersion.ForeColor = System.Drawing.Color.SkyBlue;
			this.lblVersion.Name = "lblVersion";
			this.toolTip1.SetToolTip(this.lblVersion, resources.GetString("lblVersion.ToolTip"));
			// 
			// bSettings
			// 
			this.bSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.bSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bSettings.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.bSettings, "bSettings");
			this.bSettings.Name = "bSettings";
			this.toolTip1.SetToolTip(this.bSettings, resources.GetString("bSettings.ToolTip"));
			this.bSettings.UseVisualStyleBackColor = false;
			this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
			// 
			// btnAddQuestions
			// 
			this.btnAddQuestions.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAddQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddQuestions.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnAddQuestions, "btnAddQuestions");
			this.btnAddQuestions.Name = "btnAddQuestions";
			this.toolTip1.SetToolTip(this.btnAddQuestions, resources.GetString("btnAddQuestions.ToolTip"));
			this.btnAddQuestions.UseVisualStyleBackColor = false;
			this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
			// 
			// pbTraining
			// 
			resources.ApplyResources(this.pbTraining, "pbTraining");
			this.pbTraining.Name = "pbTraining";
			this.pbTraining.TabStop = false;
			// 
			// pbExam
			// 
			resources.ApplyResources(this.pbExam, "pbExam");
			this.pbExam.Name = "pbExam";
			this.pbExam.TabStop = false;
			// 
			// pbCreate
			// 
			resources.ApplyResources(this.pbCreate, "pbCreate");
			this.pbCreate.Name = "pbCreate";
			this.pbCreate.TabStop = false;
			// 
			// pbSettings
			// 
			resources.ApplyResources(this.pbSettings, "pbSettings");
			this.pbSettings.Name = "pbSettings";
			this.pbSettings.TabStop = false;
			// 
			// pbHowToUse
			// 
			resources.ApplyResources(this.pbHowToUse, "pbHowToUse");
			this.pbHowToUse.Name = "pbHowToUse";
			this.pbHowToUse.TabStop = false;
			// 
			// pbAbout
			// 
			resources.ApplyResources(this.pbAbout, "pbAbout");
			this.pbAbout.Name = "pbAbout";
			this.pbAbout.TabStop = false;
			// 
			// pbExit
			// 
			resources.ApplyResources(this.pbExit, "pbExit");
			this.pbExit.Name = "pbExit";
			this.pbExit.TabStop = false;
			// 
			// btnBackToMenu
			// 
			this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBackToMenu.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnBackToMenu, "btnBackToMenu");
			this.btnBackToMenu.Name = "btnBackToMenu";
			this.toolTip1.SetToolTip(this.btnBackToMenu, resources.GetString("btnBackToMenu.ToolTip"));
			this.btnBackToMenu.UseVisualStyleBackColor = false;
			this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
			this.btnBackToMenu.MouseEnter += new System.EventHandler(this.bExit_MouseEnter);
			this.btnBackToMenu.MouseLeave += new System.EventHandler(this.bExit_MouseLeave);
			// 
			// btnNewTest
			// 
			this.btnNewTest.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnNewTest.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewTest.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnNewTest, "btnNewTest");
			this.btnNewTest.Name = "btnNewTest";
			this.toolTip1.SetToolTip(this.btnNewTest, resources.GetString("btnNewTest.ToolTip"));
			this.btnNewTest.UseVisualStyleBackColor = false;
			this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
			// 
			// btnEditTest
			// 
			this.btnEditTest.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEditTest.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditTest.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.btnEditTest, "btnEditTest");
			this.btnEditTest.Name = "btnEditTest";
			this.toolTip1.SetToolTip(this.btnEditTest, resources.GetString("btnEditTest.ToolTip"));
			this.btnEditTest.UseVisualStyleBackColor = false;
			this.btnEditTest.Click += new System.EventHandler(this.btnEditTest_Click);
			// 
			// pbLogo
			// 
			resources.ApplyResources(this.pbLogo, "pbLogo");
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.TabStop = false;
			// 
			// pbBackground
			// 
			resources.ApplyResources(this.pbBackground, "pbBackground");
			this.pbBackground.Name = "pbBackground";
			this.pbBackground.TabStop = false;
			// 
			// pbBack
			// 
			resources.ApplyResources(this.pbBack, "pbBack");
			this.pbBack.Name = "pbBack";
			this.pbBack.TabStop = false;
			// 
			// pbNewTest
			// 
			resources.ApplyResources(this.pbNewTest, "pbNewTest");
			this.pbNewTest.Name = "pbNewTest";
			this.pbNewTest.TabStop = false;
			// 
			// pbEditTest
			// 
			resources.ApplyResources(this.pbEditTest, "pbEditTest");
			this.pbEditTest.Name = "pbEditTest";
			this.pbEditTest.TabStop = false;
			// 
			// fMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.pbEditTest);
			this.Controls.Add(this.pbNewTest);
			this.Controls.Add(this.pbBack);
			this.Controls.Add(this.btnEditTest);
			this.Controls.Add(this.btnNewTest);
			this.Controls.Add(this.btnBackToMenu);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.pbExit);
			this.Controls.Add(this.pbAbout);
			this.Controls.Add(this.pbHowToUse);
			this.Controls.Add(this.pbSettings);
			this.Controls.Add(this.pbCreate);
			this.Controls.Add(this.pbTraining);
			this.Controls.Add(this.pbExam);
			this.Controls.Add(this.btnAddQuestions);
			this.Controls.Add(this.bSettings);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.bExit);
			this.Controls.Add(this.bAboutUs);
			this.Controls.Add(this.bHowToUse);
			this.Controls.Add(this.bTraining);
			this.Controls.Add(this.bExam);
			this.Controls.Add(this.pbBackground);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "fMain";
			((System.ComponentModel.ISupportInitialize)(this.pbTraining)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExam)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCreate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHowToUse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbNewTest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbEditTest)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bExam;
		private System.Windows.Forms.Button bTraining;
		private System.Windows.Forms.Button bHowToUse;
		private System.Windows.Forms.Button bAboutUs;
		private System.Windows.Forms.Button bExit;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Button bSettings;
		private System.Windows.Forms.Button btnAddQuestions;
		private System.Windows.Forms.PictureBox pbExam;
		private System.Windows.Forms.PictureBox pbTraining;
		private System.Windows.Forms.PictureBox pbCreate;
		private System.Windows.Forms.PictureBox pbSettings;
		private System.Windows.Forms.PictureBox pbHowToUse;
		private System.Windows.Forms.PictureBox pbAbout;
		private System.Windows.Forms.PictureBox pbExit;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.PictureBox pbBackground;
		private System.Windows.Forms.Button btnBackToMenu;
		private System.Windows.Forms.Button btnNewTest;
		private System.Windows.Forms.Button btnEditTest;
		private System.Windows.Forms.PictureBox pbBack;
		private System.Windows.Forms.PictureBox pbNewTest;
		private System.Windows.Forms.PictureBox pbEditTest;
	}
}

