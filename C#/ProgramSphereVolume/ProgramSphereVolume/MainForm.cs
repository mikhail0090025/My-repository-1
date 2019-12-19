/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 17.12.2019
 * Время: 18:21
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramSphereVolume
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
			double radius;
			radius = Convert.ToDouble(TxtBoxRadius.Text);
			double result;
			double p = 3.14159;
			result = p * radius * radius * radius * 1.33333333333333;
			LabelResult.Text = "Объем сферы с радиусом " + radius + " равен " + result;
		}
		void AboutProgramClick(object sender, EventArgs e)
		{
			MessageBox.Show("Данная программа рассчитывает объем сферы по заданному радиусу (половине диаметра). Введите радиус и нажмите кнопку считать", "О программе");
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
	}
}
