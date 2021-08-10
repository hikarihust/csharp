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
        #endregion

        #region Constructor
        public Store()
        {
            listItems = new List<Book>(MAX_ITEMS);
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
            }
            else
            {
                Console.WriteLine("Store is full!");
            }
        }

        public void edit(string bookId, string bookName, int bookPrice)
        {
        
        }

        public void delete(string bookId)
        {
            if (this.checkExist(bookId))
            {
                Book bookObj = listItems.Single(item => item.Id.Equals(bookId));
                listItems.Remove(bookObj);
                Console.WriteLine("Delete successfull");
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
    }
}
