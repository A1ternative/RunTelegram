using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace RunTelegram
{
	class Program
	{
		static void Main(string[] args)
		{
			string tgPath = @"C:\Users\Admin\TgPaths.txt";
			string[] readTgPath = File.ReadAllLines(tgPath);
			string tgExe = @"Telegram.exe";
			string combinePath;

			foreach (string s in readTgPath)
			{
				combinePath = Path.Combine(s, tgExe);
				Process.Start(combinePath);
			}
			//
		}
	}
}