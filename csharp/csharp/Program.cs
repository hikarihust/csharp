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
			string bookId;
			int bookPrice;

			Console.Write("ID: ");
			bookId = Console.ReadLine();

			if (storeObj.checkExist(bookId))
			{
				Console.Write("Name: ");
				bookName = Console.ReadLine();

				Console.Write("Price: ");
				bookPrice = Convert.ToInt32(Console.ReadLine());

				storeObj.edit(bookId, bookName, bookPrice);
                Console.WriteLine("Edit successfull");
			}
			else
			{
                Console.WriteLine("Not exist");
			}
		}

		public static void infoBook()
		{
			string bookId;

			Console.Write("ID: ");
			bookId = Console.ReadLine();

			if (storeObj.checkExist(bookId))
			{
				storeObj.find(bookId);
			}
			else
			{
				Console.WriteLine("Not exist");
			}
		}

		public static void deleteBook()
		{
			string bookId;

			Console.Write("ID: ");
			bookId = Console.ReadLine();

			if (storeObj.checkExist(bookId))
			{
				storeObj.delete(bookId);
                Console.WriteLine("Delete successful");
			}
			else
			{
                Console.WriteLine("Not exist");
			}
		}

		public static void findBook()
		{
			int price;

			Console.Write("Price: ");
			price = Convert.ToInt32(Console.ReadLine());
			storeObj.findByPrice(price);
		}

		public static void listBook()
		{
			storeObj.list();
		}

		public static void showMenu()
		{

            Console.WriteLine("===================== BOOK MANAGER =====================");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Edit book");
            Console.WriteLine("3. Info book (by ID)");
            Console.WriteLine("4. Delete book");
            Console.WriteLine("5. Filter book by Price");
            Console.WriteLine("6. List book");
            Console.WriteLine("7. Exit");
			Console.Write("Your choise [1-7]: ");
		}
	}
}
