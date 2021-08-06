using System;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExeBCCOne();
        }

        static void ExeBCCOne()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i*j);
                }
                Console.WriteLine("----------------------------");
            }
        }

        static void ExeMaxNumber()
        {
            int numberOne = 285;
            int numberTwo = 125;
            int numberThree = 185;
            int numberFour = 325;

            int maxNumber = Math.Max(Math.Max(numberOne, numberTwo), Math.Max(numberThree, numberFour));

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Trong 4 số {0} - {1} - {2} - {3}, thì số lớn nhất là {4}"
                                , numberOne, numberTwo, numberThree, numberFour, maxNumber);
        }

        static void ExeFilm()
        {
            // age
            // >= 16 Được xem phim Titanic
            // < 16 Không được xem phim Titanic
            int age = 16;
            String filmName = "Titanic";
            String result = (age < 16) ? "Không được xem phim" : "Được xem phim";

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(result + " " + filmName);
        }
    }
}
