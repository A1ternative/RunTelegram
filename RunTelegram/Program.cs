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
			Console.WriteLine("Укажи путь до папки с телегами");

			GetCatalog();

			static void GetCatalog()
			{
				string pathToGeneralCatalog = Console.ReadLine();
				string[] getTelegramExe;

				if (Directory.Exists(pathToGeneralCatalog))
				{
					string[] Catalogs = Directory.GetDirectories(pathToGeneralCatalog);
					foreach (string catalog in Catalogs)
					{
						getTelegramExe = Directory.GetFiles(@catalog, "*exe");
						foreach (string file in getTelegramExe)
						{
							Console.WriteLine(getTelegramExe);
						}
						
					}
				}
			}

			
		}
	}
}