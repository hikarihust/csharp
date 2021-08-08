using System;
using System.Collections.Generic;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Book bookObj = new Book("C#", 1000);

            bookObj.Price = 2000;
            Console.WriteLine(bookObj.Name);
            Console.WriteLine(bookObj.Price);
        }
    }
}
