/*
 * Сделано в SharpDevelop.
 * Пользователь: User
 * Дата: 12.12.2019
 * Время: 20:40
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace BugReportCreater
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
		void ButtonCreateClick(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			string res;
			res = "<!DOCTYPE html><html><head><title>Bug Report</title></head><body>" + "<p>Проект, где обнаружен баг: " + ProjectInBag.Text + "</p><p>Шаги, ведущие к багу: " + StepsToBag.Text + "</p><p>Степень бага: " + Stepen.Text + "</p><p>Приоритет исправления: " + PriorityFix.Text + "</p><p>Статус: " + StatusBag.Text + "</p><p>Закономерность бага: " + Zakonomernost.Text + "</p><p>Описание правильного поведения: " + CorrectDescription.Text + "</p><p>Описание ошибки: " + ErrorDescription.Text + "</p></body></html>";
			FileCreate("BugReport.html", res);
		}
			    public void FileCreate(string name, string contain)
	    {
			StreamWriter print = new StreamWriter(name, true);
			print.WriteLine(contain);
			print.Close();
	    }
	}
}
