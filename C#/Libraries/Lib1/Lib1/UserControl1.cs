/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 23.12.2019
 * Время: 8:48
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Web;
namespace Lib1
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			string str = null;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bool a = false;
			if (a) {
				char symbol = Convert.ToChar("f");
				int i = 1;
				while (i < 100) {
					i++;
					str = str + i + symbol;
					symbol = Convert.ToChar("h");
				}
				new WebBrowser();
				new Color();
				new Button();
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}