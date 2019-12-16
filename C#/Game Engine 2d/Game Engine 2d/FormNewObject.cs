/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 15.12.2019
 * Время: 23:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Engine_2d
{
	/// <summary>
	/// Description of FormNewObject.
	/// </summary>
	public partial class FormNewObject : Form
	{
		public static int WidthNewObj = 100;
		public static int HeightNewObj = 100;
		public static string NameObj = "NewObject" + MainForm.objects;
		public FormNewObject()
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
			if(TxtBoxHeight.Text == null || TxtBoxWidth.Text == null) MessageBox.Show("Ошибка!", "Введите в поле значение");
			else {
			HeightNewObj = Convert.ToInt32(TxtBoxHeight.Text);
			WidthNewObj = Convert.ToInt32(TxtBoxWidth.Text);
			NameObj = NameObject.Text;
			MainForm.FileCreate(NameObj + "name", NameObj);
			MainForm.FileCreate(NameObj + "Width" , Convert.ToString(WidthNewObj));
			MainForm.FileCreate(NameObj + "Height" , Convert.ToString(HeightNewObj));
			//FormNewObject.
			}
		}
	}
}
