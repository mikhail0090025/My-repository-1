/*
 * Сделано в SharpDevelop.
 * Пользователь: User
 * Дата: 12.12.2019
 * Время: 20:40
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace BugReportCreater
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.ButtonCreate = new System.Windows.Forms.Button();
			this.ProjectInBag = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ErrorDescription = new System.Windows.Forms.TextBox();
			this.CorrectDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.StepsToBag = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Stepen = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.PriorityFix = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.StatusBag = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Zakonomernost = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ButtonCreate
			// 
			this.ButtonCreate.Location = new System.Drawing.Point(13, 723);
			this.ButtonCreate.Name = "ButtonCreate";
			this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
			this.ButtonCreate.TabIndex = 0;
			this.ButtonCreate.Text = "Создать";
			this.ButtonCreate.UseVisualStyleBackColor = true;
			this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreateClick);
			// 
			// ProjectInBag
			// 
			this.ProjectInBag.Location = new System.Drawing.Point(12, 60);
			this.ProjectInBag.Name = "ProjectInBag";
			this.ProjectInBag.Size = new System.Drawing.Size(176, 20);
			this.ProjectInBag.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(2, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Проект, где обнаружен баг";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Шаги, приведущие к багу";
			// 
			// ErrorDescription
			// 
			this.ErrorDescription.Location = new System.Drawing.Point(289, 517);
			this.ErrorDescription.Multiline = true;
			this.ErrorDescription.Name = "ErrorDescription";
			this.ErrorDescription.Size = new System.Drawing.Size(254, 175);
			this.ErrorDescription.TabIndex = 4;
			// 
			// CorrectDescription
			// 
			this.CorrectDescription.Location = new System.Drawing.Point(13, 517);
			this.CorrectDescription.Multiline = true;
			this.CorrectDescription.Name = "CorrectDescription";
			this.CorrectDescription.Size = new System.Drawing.Size(259, 175);
			this.CorrectDescription.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 493);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Описание правильного поведения программы";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(289, 493);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Описание ошибки";
			// 
			// StepsToBag
			// 
			this.StepsToBag.Location = new System.Drawing.Point(12, 114);
			this.StepsToBag.Multiline = true;
			this.StepsToBag.Name = "StepsToBag";
			this.StepsToBag.Size = new System.Drawing.Size(531, 135);
			this.StepsToBag.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Степень бага";
			// 
			// Stepen
			// 
			this.Stepen.FormattingEnabled = true;
			this.Stepen.Items.AddRange(new object[] {
			"Мелкая",
			"Средняя",
			"Важная",
			"Очень серьезная",
			"Фатальная"});
			this.Stepen.Location = new System.Drawing.Point(91, 258);
			this.Stepen.Name = "Stepen";
			this.Stepen.Size = new System.Drawing.Size(121, 21);
			this.Stepen.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 283);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Приоритет исправления:";
			// 
			// PriorityFix
			// 
			this.PriorityFix.FormattingEnabled = true;
			this.PriorityFix.Items.AddRange(new object[] {
			"Низкий",
			"Средний",
			"Высокий"});
			this.PriorityFix.Location = new System.Drawing.Point(151, 285);
			this.PriorityFix.Name = "PriorityFix";
			this.PriorityFix.Size = new System.Drawing.Size(121, 21);
			this.PriorityFix.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 310);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Статус";
			// 
			// StatusBag
			// 
			this.StatusBag.FormattingEnabled = true;
			this.StatusBag.Items.AddRange(new object[] {
			"Новый",
			"Переоткрытый",
			"В процессе исправления",
			"Закрытый"});
			this.StatusBag.Location = new System.Drawing.Point(57, 312);
			this.StatusBag.Name = "StatusBag";
			this.StatusBag.Size = new System.Drawing.Size(110, 21);
			this.StatusBag.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 337);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Закономерность";
			// 
			// Zakonomernost
			// 
			this.Zakonomernost.FormattingEnabled = true;
			this.Zakonomernost.Items.AddRange(new object[] {
			"Всегда",
			"Через раз",
			"Через два",
			"Через три",
			"Случайно (Закономерность отсутствует)",
			"Неизвестно"});
			this.Zakonomernost.Location = new System.Drawing.Point(103, 337);
			this.Zakonomernost.Name = "Zakonomernost";
			this.Zakonomernost.Size = new System.Drawing.Size(121, 21);
			this.Zakonomernost.TabIndex = 18;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 758);
			this.Controls.Add(this.Zakonomernost);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.StatusBag);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.PriorityFix);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Stepen);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.StepsToBag);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CorrectDescription);
			this.Controls.Add(this.ErrorDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ProjectInBag);
			this.Controls.Add(this.ButtonCreate);
			this.Name = "MainForm";
			this.Text = "BugReportCreater";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox Zakonomernost;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox PriorityFix;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox StatusBag;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Stepen;
		private System.Windows.Forms.TextBox ProjectInBag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ErrorDescription;
		private System.Windows.Forms.TextBox CorrectDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox StepsToBag;
		private System.Windows.Forms.Button ButtonCreate;
	}
}
