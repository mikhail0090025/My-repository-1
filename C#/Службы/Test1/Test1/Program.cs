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
using System.ServiceProcess;
using System.Text;

namespace Test1
{
	static class Program
	{
		/// <summary>
		/// This method starts the service.
		/// </summary>
		static void Main()
		{
			// To run more than one service you have to add them here
			ServiceBase.Run(new ServiceBase[] { new Test1() });
		}
	}
}
