/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 19.12.2019
 * Время: 15:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConusVolume
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonCalcClick(object sender, EventArgs e)
		{
			double p = 3.14159;
			double radius = Convert.ToDouble(RadiusConus.Text);
			double height = Convert.ToDouble(HeightConus.Text);
			double S = p * radius * radius;
			double result = (height/3) * S;
			label3.Text = "Объем конуса в высоту " + height + " и с радиусом " + radius + " равен " + result;
		}
		void ProgramAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("Данная программа рассчитывает объем конуса по заданной высоте и радиусу.","О программе");
		}
	}
}
