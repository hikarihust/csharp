using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp
{
    class Store
    {
        #region Thuộc tính
        private const int MAX_ITEMS = 5;
        private List<Book> listItems = null;
        private DataFile dataFileObj;
        #endregion

        #region Constructor
        public Store()
        {
            dataFileObj = new DataFile("bookstore.txt", "$$$$$$");
            listItems = new List<Book>(MAX_ITEMS);

            List<Book> listBooksFromFile = dataFileObj.Read();

            if (listBooksFromFile.Count > 0)
            {
                listItems.AddRange(listBooksFromFile);
            }
        }
        #endregion

        public bool checkExist(string bookId)
        {
            return listItems.Any(item => item.Id.Equals(bookId));
        }

        public bool checkFull()
        {
            if (listItems.Count == MAX_ITEMS) return true;
            return false;
        }

        public bool checkEmty()
        {
            if (listItems.Count == 0) return true;
            return false;
        }

        public void add(Book bookObj)
        {
            if (!this.checkFull())
            {
                listItems.Add(bookObj);
                dataFileObj.Write(listItems);
            }
            else
            {
                Console.WriteLine("Store is full!");
            }
        }

        public void edit(string bookId, string bookName, int bookPrice)
        {
            if (this.checkExist(bookId))
            {
                var item = listItems.FirstOrDefault(item => item.Id == bookId);
                if (item != null)
                {
                    item.Name = bookName;
                    item.Price = bookPrice;
                    dataFileObj.Write(listItems);
                }
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        public void delete(string bookId)
        {
            if (this.checkExist(bookId))
            {
                Book bookObj = listItems.Single(item => item.Id.Equals(bookId));
                listItems.Remove(bookObj);
                dataFileObj.Write(listItems);
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        public void find(string bookId)
        {
            if (this.checkExist(bookId))
            {
                Book bookObj = listItems.Single(item => item.Id.Equals(bookId));
                Console.WriteLine(bookObj);
            }
            else
            {
                Console.WriteLine("Not exist");
            }
        }

        public void findByPrice(int price)
        {
            List<Book> filtered = listItems.FindAll(item => item.Price > price);
            Console.WriteLine("------------------------------------------------------");

            if (filtered.Count == 0)
            {
                Console.WriteLine("Empty!");
            }
            else
            {
                filtered.ForEach(item => Console.WriteLine(item));
            }

            Console.WriteLine("------------------------------------------------------");
        }

        public void list()
        {
            Console.WriteLine("------------------------------------------------------");

            if (this.checkEmty() == true)
            {
                Console.WriteLine("Store is empty!");
            }
            else
            {
                listItems.ForEach(item => Console.WriteLine(item));
            }

            Console.WriteLine("------------------------------------------------------");
        }

        public void sortNameAZ()
        {
            listItems.Sort((Book a, Book b) => a.Name.CompareTo(b.Name)); // ascending sort
        }

        public void sortNameZA()
        {
            listItems.Sort((Book a, Book b) => b.Name.CompareTo(a.Name)); // ascending sort
        }

        public void sortPriceZA()
        {
            //  listItems.Sort((Book a, Book b) => b.Price.CompareTo(a.Price));
            listItems = listItems.OrderByDescending(a => a.Price).ToList();
        }
        public void sortPriceAZ()
        {
            listItems = listItems.OrderBy(a => a.Price).ToList();
            // listItems.Sort((Book a, Book b) => a.Price.CompareTo(b.Price));
        }
    }
}
