/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 15.12.2019
 * Время: 23:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Game_Engine_2d
{
	partial class FormNewObject
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox TxtBoxWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtBoxHeight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox NameObject;
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
			this.TxtBoxWidth = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtBoxHeight = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.NameObject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtBoxWidth
			// 
			this.TxtBoxWidth.Location = new System.Drawing.Point(59, 12);
			this.TxtBoxWidth.Name = "TxtBoxWidth";
			this.TxtBoxWidth.Size = new System.Drawing.Size(100, 20);
			this.TxtBoxWidth.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(2, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ширина";
			// 
			// TxtBoxHeight
			// 
			this.TxtBoxHeight.Location = new System.Drawing.Point(59, 38);
			this.TxtBoxHeight.Name = "TxtBoxHeight";
			this.TxtBoxHeight.Size = new System.Drawing.Size(100, 20);
			this.TxtBoxHeight.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(2, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Высота";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 198);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(259, 52);
			this.button1.TabIndex = 2;
			this.button1.Text = "Создать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// NameObject
			// 
			this.NameObject.Location = new System.Drawing.Point(59, 64);
			this.NameObject.Name = "NameObject";
			this.NameObject.Size = new System.Drawing.Size(100, 20);
			this.NameObject.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(2, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Имя";
			// 
			// FormNewObject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NameObject);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtBoxHeight);
			this.Controls.Add(this.TxtBoxWidth);
			this.Name = "FormNewObject";
			this.Text = "FormNewObject";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
