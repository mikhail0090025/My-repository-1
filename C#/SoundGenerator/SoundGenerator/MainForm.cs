/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 26.12.2019
 * Время: 8:19
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SoundGenerator
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
		void Button1Click(object sender, EventArgs e)
		{
			String res = null;
			int h = 0;
			int j = 0;
			while (j < 500) {
			while (h < 8) {
					Random rnd = new Random();
                    int value = rnd.Next(1000, 9999);
                    value = rnd.Next(1000, 9999);
                    res = res + value + " ";
                    h++;
			}
				res = res + "\n";
				j++;
				h = 0;
			}
			textBox1.Text = res;
		}
	}
}
