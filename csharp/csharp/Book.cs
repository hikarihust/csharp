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

        public Book(string name, int price)
        {
            this.id = this.MakeId(3);
            this.name = name;
            this.price = price;
        }
        #endregion

        private string MakeId(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public override string ToString()
        {
            return "ID: " + this.id + "\t\t Name: " + this.name
                            + "\t\t Price: " + this.price;
        }
    }
}
