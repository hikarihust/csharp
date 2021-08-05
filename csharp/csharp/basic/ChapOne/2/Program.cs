using System;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // age
            // >= 16 Được xem phim Titanic
            // < 16 Không được xem phim Titanic
            int age = 16;

            Console.OutputEncoding = Encoding.UTF8;
            if (age >= 16)
            {
                Console.WriteLine("Được xem phim Titanic");
            } else
            {
                Console.WriteLine("Không được xem phim Titanic");
            }
        }
    }
}
