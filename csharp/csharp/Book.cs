using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class Book
    {
        #region Thuộc tính
        private string id;
        private string name;
        private int price;
        #endregion

        #region Constructor
        public Book(string id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        #endregion

        public override string ToString()
        {
            return "ID: " + this.id + "\t\t Name: " + this.name
                            + "\t\t Price: " + this.price;
        }
    }
}
