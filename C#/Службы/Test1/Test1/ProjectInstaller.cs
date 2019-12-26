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
using System.Configuration.Install;
using System.ServiceProcess;

namespace Test1
{
	[RunInstaller(true)]
	public class ProjectInstaller : Installer
	{
		private ServiceProcessInstaller serviceProcessInstaller;
		private ServiceInstaller serviceInstaller;
		
		public ProjectInstaller()
		{
			serviceProcessInstaller = new ServiceProcessInstaller();
			serviceInstaller = new ServiceInstaller();
			// Here you can set properties on serviceProcessInstaller or register event handlers
			serviceProcessInstaller.Account = ServiceAccount.LocalService;
			
			serviceInstaller.ServiceName = Test1.MyServiceName;
			this.Installers.AddRange(new Installer[] { serviceProcessInstaller, serviceInstaller });
		}
	}
}
