/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 15.12.2019
 * Время: 22:56
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Game_Engine_2d
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.TextBox TxtBoxNameProj;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button ButtonNewObject;
		
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
			this.ButtonSave = new System.Windows.Forms.Button();
			this.TxtBoxNameProj = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ButtonNewObject = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonSave
			// 
			this.ButtonSave.Location = new System.Drawing.Point(13, 13);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(75, 23);
			this.ButtonSave.TabIndex = 0;
			this.ButtonSave.Text = "Сохранить";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// TxtBoxNameProj
			// 
			this.TxtBoxNameProj.Location = new System.Drawing.Point(13, 43);
			this.TxtBoxNameProj.Name = "TxtBoxNameProj";
			this.TxtBoxNameProj.Size = new System.Drawing.Size(100, 20);
			this.TxtBoxNameProj.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new System.Drawing.Point(129, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1046, 601);
			this.panel1.TabIndex = 2;
			// 
			// ButtonNewObject
			// 
			this.ButtonNewObject.Location = new System.Drawing.Point(129, 621);
			this.ButtonNewObject.Name = "ButtonNewObject";
			this.ButtonNewObject.Size = new System.Drawing.Size(75, 40);
			this.ButtonNewObject.TabIndex = 3;
			this.ButtonNewObject.Text = "Новый объект";
			this.ButtonNewObject.UseVisualStyleBackColor = true;
			this.ButtonNewObject.Click += new System.EventHandler(this.ButtonNewObjectClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1425, 806);
			this.Controls.Add(this.ButtonNewObject);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TxtBoxNameProj);
			this.Controls.Add(this.ButtonSave);
			this.Name = "MainForm";
			this.Text = "Game Engine 2d";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
