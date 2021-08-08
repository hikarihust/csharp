﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
			Console.OutputEncoding = Encoding.UTF8;
			int functionID = 0;
			bool flag = true;

			do
			{
				showMenu();
				try
				{
					functionID = Convert.ToInt32(Console.ReadLine());

					switch (functionID)
					{
						case 1: addBook(); break;
						case 2: editBook(); break;
						case 3: infoBook(); break;
						case 4: 
						default:
							flag = false;
							break;
					}
				}
				catch (Exception)
				{
                    Console.WriteLine("Có lỗi hệ thống!");
				}

			} while (flag == true);
		}

		public static void addBook()
		{
            Console.WriteLine("addBook");
		}

		public static void editBook()
		{
            Console.WriteLine("editBook");
		}

		public static void infoBook()
		{
            Console.WriteLine("infoBook");
		}

		public static void showMenu()
		{

            Console.WriteLine("===================== BOOK MANAGER =====================");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Edit book");
            Console.WriteLine("3. Info book (by ID)");
            Console.WriteLine("4. Exit");
			Console.Write("Your choise [1-4]: ");
		}
	}
}
