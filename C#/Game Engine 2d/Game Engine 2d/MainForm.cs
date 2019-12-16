/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 15.12.2019
 * Время: 22:56
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Game_Engine_2d
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static int objects;
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
		public static void FileCreate(string name, string contain)
	    {
			StreamWriter p = new StreamWriter(name, true);
			p.WriteLine(contain);
			p.Close();
	    }
		void ButtonSaveClick(object sender, EventArgs e)
		{
			if(TxtBoxNameProj.TextLength == 0) MessageBox.Show("Имя проекта должно состоять минимум из одного символа!", "Ошибка!");
			else {FileCreate("nameproject.ini", TxtBoxNameProj.Text);}
		}
		void ButtonNewObjectClick(object sender, EventArgs e)
		{
			
		}
	}
}
