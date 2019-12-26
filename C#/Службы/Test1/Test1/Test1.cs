/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 23.12.2019
 * Время: 8:46
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace Test1
{
	public class Test1 : ServiceBase
	{
		public const string MyServiceName = "Test1";
		
		public Test1()
		{
			InitializeComponent();
		}
		
		private void InitializeComponent()
		{
			this.ServiceName = MyServiceName;
		}
		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			// TODO: Add cleanup code here (if required)
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// Start this service.
		/// </summary>
		protected override void OnStart(string[] args)
		{
			// TODO: Add start code here (if required) to start your service.
		}
		
		/// <summary>
		/// Stop this service.
		/// </summary>
		protected override void OnStop()
		{
			// TODO: Add tear-down code here (if required) to stop your service.
		}
	}
}
