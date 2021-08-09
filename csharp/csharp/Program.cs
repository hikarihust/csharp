using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class Program
    {
		private static Store storeObj = new Store();

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
						case 4: deleteBook(); break;
						case 5: findBook(); break;
						case 6: listBook(); break;
						case 7: 
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
			if (storeObj.checkFull() == false)
            {
				string bookName;
				int bookPrice;

				Console.Write("Name: ");
				bookName = Console.ReadLine();

				Console.Write("Price: ");
				bookPrice = Convert.ToInt32(Console.ReadLine());

				Book bookObj = new Book(bookName, bookPrice);
				storeObj.add(bookObj);
			}
			else
			{
                Console.WriteLine("Store is full!");
			}
		}

		public static void editBook()
		{
			string bookName;
			int bookPrice;

			Console.Write("Name: ");
			bookName = Console.ReadLine();

			Console.Write("Price: ");
			bookPrice = Convert.ToInt32(Console.ReadLine());
		}

		public static void infoBook()
		{
            Console.WriteLine("infoBook");
		}

		public static void deleteBook()
		{
            Console.WriteLine("deleteBook");
		}

		public static void findBook()
		{
            Console.WriteLine("findBook");
		}

		public static void listBook()
		{
            Console.WriteLine("listBook");
		}

		public static void showMenu()
		{

            Console.WriteLine("===================== BOOK MANAGER =====================");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Edit book");
            Console.WriteLine("3. Info book");
            Console.WriteLine("4. Delete book");
            Console.WriteLine("5. Find book");
            Console.WriteLine("6. List book");
            Console.WriteLine("7. Exit");
			Console.Write("Your choise [1-7]: ");
		}
	}
}
