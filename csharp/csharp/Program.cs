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
						case 6: listBook("name", 0); break;     // name asc
						case 7: listBook("name", 1); break;     // name desc
						case 8: listBook("price", 1); break;    // price giảm dần
						case 9: listBook("price", 0); break;    // price tăng dần
						case 10:
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
			string price;

			Console.Write("Price: ");
			price = Console.ReadLine();
			storeObj.findByPrice(price);
		}

		public static void listBook(string field, int type)
		{
			if (field.Equals("name") && type == 0) storeObj.sortNameAZ();
			if (field.Equals("name") && type == 1) storeObj.sortNameZA();
			if (field.Equals("price") && type == 0) storeObj.sortPriceAZ();
			if (field.Equals("price") && type == 1) storeObj.sortPriceZA();
			storeObj.list();
		}

		public static void showMenu()
		{
			Console.ResetColor();
			WriteLine.Title("===================== BOOK MANAGER =====================");
			WriteLine.SubTitle("1. Add book");
			WriteLine.SubTitle("2. Edit book");
            WriteLine.SubTitle("3. Info book (by ID)");
            WriteLine.SubTitle("4. Delete book (by ID)");
            WriteLine.SubTitle("5. Filter book by Price");
            WriteLine.SubTitle("6. List book (Name A - Z)");
			WriteLine.SubTitle("7. List book (Name Z - A)");
			WriteLine.SubTitle("8. List book (Price giảm dần)");
			WriteLine.SubTitle("9. List book (Price tăng dần)");
			WriteLine.SubTitle("10. Exit");
			Console.Write("Your choise [1-10]: ");
		}
	}
}
