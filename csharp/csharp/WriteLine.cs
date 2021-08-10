using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class WriteLine
    {
		public static void Title(string content)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(content);
			Console.ResetColor();
		}

		public static void SubTitle(string content)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(content);
			Console.ResetColor();
		}

		public static void Notify(string content)
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine(content);
			Console.ResetColor();
		}

		public static void Error(string content)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(content);
			Console.ResetColor();
		}
	}
}
