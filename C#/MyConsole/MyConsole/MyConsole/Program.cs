/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 23.12.2019
 * Время: 9:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.IO;
namespace MyConsole
{
	class Program
	{
		
		public static void FileCreate(string name, string contain)
	    {
			StreamWriter p = new StreamWriter(name, true);
			p.WriteLine(contain);
			p.Close();
	    }
		public static void Main(string[] args)
		{					string static name = null;
			Console.WriteLine("Все права защищены!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Введите команду или введите /help для просмотра доступных команд\n");
			string commands = "/help - просмотр всех команд \n/quit - закрыть консоль\n/color - Цвет подсветки текста\n/datamax - Дата и время(MAX)\n/datamin - Дата и время(MIN)\n/filecreate - создать файл";
							
			while (true) {
				string command = null;
				command = Console.ReadLine();
				if (command == "/help") {
					Console.WriteLine(commands);
				}
				if (command == "/quit") {
					break;
				}
				if (command == "/datamax") {
					Console.WriteLine(DateTime.MaxValue);
				}
				if (command == "/datamin") {
					Console.WriteLine(DateTime.MinValue);
				}
				if (command == "/datamin") {
					Console.WriteLine(DateTime.MinValue);
				}
				if (command == "/filecreate") {
					string contain = null;
					string name = null;
					Console.WriteLine("Введите имя файла (включая расширения)");
					name = Console.ReadLine();
					Console.WriteLine("Введите содержимое файла и нажмите Enter. Файл создастся там же, где и установлена консоль");
					contain = Console.ReadLine();
					FileCreate(name, contain);
				}
				if (command == "/color") {
					string com = null;
					Console.WriteLine("Выберите цвет или напишите /back чтобы выйти назад (если передумали менять цвет подсветки) \n теперь введите один из цветов: green, red, blue");
					com = Console.ReadLine();
					if (com == "/back") {
						
					}
					if (com == "green") {
						Console.BackgroundColor = ConsoleColor.Green;
					}
					if (com == "red") {
						Console.BackgroundColor = ConsoleColor.Red;
					}
					if (com == "blue") {
						Console.BackgroundColor = ConsoleColor.Blue;
					}
					
				}
				else{
					//Console.WriteLine("Такой команды нет! Введите /help для просмотра доступных комманд\n");
				}
			}
			//Console.ReadKey(true);
		}
	}
}