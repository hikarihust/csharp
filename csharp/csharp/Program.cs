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
            Book bookObj = new Book("HNGH", "C#", 1000);

            Console.WriteLine(bookObj);
        }
    }
}
