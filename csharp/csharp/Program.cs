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
							flag = false;
							break;
						default:
							flag = true;
							break;
					}
				}
				catch (Exception)
				{
                    WriteLine.Notify("Có lỗi hệ thống!");
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

				Validate validateObj = new Validate();
				bool flagName = validateObj.checkName(bookName);
				bool flagPrice = validateObj.checkPrice(bookPrice);

				if (flagName && flagPrice)
				{
					Book bookObj = new Book(bookName, bookPrice);
					storeObj.add(bookObj);
					WriteLine.Notify("Add successfull");
				}
				else
				{
					validateObj.showError();
				}
			}
			else
			{
				WriteLine.Notify("Store is full!");
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
				WriteLine.Notify("Edit successfull");
			}
			else
			{
				WriteLine.Notify("Not exist");
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
				WriteLine.Notify("Not exist");
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
				WriteLine.Notify("Delete successful");
			}
			else
			{
				WriteLine.Notify("Not exist");
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
			Console.ResetColor();
			WriteLine.Title("===================== BOOK MANAGER =====================");
			WriteLine.SubTitle("1. Add book");
			WriteLine.SubTitle("2. Edit book");
            WriteLine.SubTitle("3. Info book (by ID)");
            WriteLine.SubTitle("4. Delete book");
            WriteLine.SubTitle("5. Filter book by Price");
            WriteLine.SubTitle("6. List book");
            WriteLine.SubTitle("7. Exit");
			Console.Write("Your choise [1-7]: ");
		}
	}
}
