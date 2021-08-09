using System;
using System.Collections.Generic;
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
            return false;
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
        
        }

        public void find(string bookId)
        {
         
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
