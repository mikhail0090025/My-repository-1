/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 17.12.2019
 * Время: 18:21
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace ProgramSphereVolume
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button ButtonCalc;
		private System.Windows.Forms.TextBox TxtBoxRadius;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LabelResult;
		private System.Windows.Forms.Button AboutProgram;
		private System.Windows.Forms.Panel panel1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ButtonCalc = new System.Windows.Forms.Button();
			this.TxtBoxRadius = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LabelResult = new System.Windows.Forms.Label();
			this.AboutProgram = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonCalc
			// 
			this.ButtonCalc.Location = new System.Drawing.Point(3, 29);
			this.ButtonCalc.Name = "ButtonCalc";
			this.ButtonCalc.Size = new System.Drawing.Size(75, 23);
			this.ButtonCalc.TabIndex = 0;
			this.ButtonCalc.Text = "Считать";
			this.ButtonCalc.UseVisualStyleBackColor = true;
			this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalcClick);
			// 
			// TxtBoxRadius
			// 
			this.TxtBoxRadius.Location = new System.Drawing.Point(13, 40);
			this.TxtBoxRadius.Name = "TxtBoxRadius";
			this.TxtBoxRadius.Size = new System.Drawing.Size(100, 20);
			this.TxtBoxRadius.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Радиус сферы";
			// 
			// LabelResult
			// 
			this.LabelResult.Location = new System.Drawing.Point(0, 0);
			this.LabelResult.Name = "LabelResult";
			this.LabelResult.Size = new System.Drawing.Size(168, 28);
			this.LabelResult.TabIndex = 3;
			this.LabelResult.Text = "Результат будет здесь";
			// 
			// AboutProgram
			// 
			this.AboutProgram.Location = new System.Drawing.Point(82, 29);
			this.AboutProgram.Name = "AboutProgram";
			this.AboutProgram.Size = new System.Drawing.Size(86, 23);
			this.AboutProgram.TabIndex = 4;
			this.AboutProgram.Text = "О программе";
			this.AboutProgram.UseVisualStyleBackColor = true;
			this.AboutProgram.Click += new System.EventHandler(this.AboutProgramClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.LabelResult);
			this.panel1.Controls.Add(this.AboutProgram);
			this.panel1.Controls.Add(this.ButtonCalc);
			this.panel1.Location = new System.Drawing.Point(12, 67);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 55);
			this.panel1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 210);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtBoxRadius);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Рассчитать объем сферы";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
