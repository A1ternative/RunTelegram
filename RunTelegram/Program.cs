using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace RunTelegram
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Укажи путь до файлика с путями телег. Путь и файл не должны соджержать пробелы!!!");
			Console.WriteLine("Пример содержимого файлика:");
			Console.WriteLine(@"D:\Telegrams\15901");
			Console.WriteLine(@"D:\Telegrams\15902");
			Console.WriteLine(@"");
			Console.WriteLine(@"Для остановки программы нажми Ctrl+C в этом окне");
			RunAllTelegrams(ReadPathsFromFile());

			static List<string> ReadPathsFromFile()
			{
				string fileWithPaths = Console.ReadLine();
				string[] readTgPath = File.ReadAllLines(@fileWithPaths);
				string tgExe = @"Telegram.exe";
				List <string> PathToTgExe = new List<string>();

				foreach (string path in readTgPath)
				{
					PathToTgExe.Add(Path.Combine(path, tgExe));
				}
				return PathToTgExe;
			}

			static void RunAllTelegrams(List<string> Paths)
			{
				foreach (string path in Paths)
				{
					Process.Start(path);
					Thread.Sleep(5000);
				}
			}
		}
	}
}