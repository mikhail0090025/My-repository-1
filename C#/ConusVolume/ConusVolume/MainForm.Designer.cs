/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 19.12.2019
 * Время: 15:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace ConusVolume
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RadiusConus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox HeightConus;
		private System.Windows.Forms.Button ButtonCalc;
		private System.Windows.Forms.Button ProgramAbout;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.RadiusConus = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.HeightConus = new System.Windows.Forms.TextBox();
			this.ButtonCalc = new System.Windows.Forms.Button();
			this.ProgramAbout = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите радиус конуса";
			// 
			// RadiusConus
			// 
			this.RadiusConus.Location = new System.Drawing.Point(13, 46);
			this.RadiusConus.Name = "RadiusConus";
			this.RadiusConus.Size = new System.Drawing.Size(100, 20);
			this.RadiusConus.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Введите высоту конуса";
			// 
			// HeightConus
			// 
			this.HeightConus.Location = new System.Drawing.Point(13, 107);
			this.HeightConus.Name = "HeightConus";
			this.HeightConus.Size = new System.Drawing.Size(100, 20);
			this.HeightConus.TabIndex = 3;
			// 
			// ButtonCalc
			// 
			this.ButtonCalc.Location = new System.Drawing.Point(13, 134);
			this.ButtonCalc.Name = "ButtonCalc";
			this.ButtonCalc.Size = new System.Drawing.Size(75, 23);
			this.ButtonCalc.TabIndex = 4;
			this.ButtonCalc.Text = "Считать";
			this.ButtonCalc.UseVisualStyleBackColor = true;
			this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalcClick);
			// 
			// ProgramAbout
			// 
			this.ProgramAbout.Location = new System.Drawing.Point(13, 164);
			this.ProgramAbout.Name = "ProgramAbout";
			this.ProgramAbout.Size = new System.Drawing.Size(88, 23);
			this.ProgramAbout.TabIndex = 5;
			this.ProgramAbout.Text = "О программе";
			this.ProgramAbout.UseVisualStyleBackColor = true;
			this.ProgramAbout.Click += new System.EventHandler(this.ProgramAboutClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 59);
			this.label3.TabIndex = 6;
			this.label3.Text = "Здесь будет ответ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ProgramAbout);
			this.Controls.Add(this.ButtonCalc);
			this.Controls.Add(this.HeightConus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.RadiusConus);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ConusVolume";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
