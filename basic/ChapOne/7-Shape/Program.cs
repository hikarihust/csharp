using System;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeOne();
        }

        static void ShapeOne()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //*
            //**
            //***
            //****

            int height = 10;
            for (int i = 1; i <= height; i++)
            {
                String character = (i % 2 == 1) ? "*" : "+";
                PrintCharacterOnLine(character, i);
                Console.WriteLine();
            }
        }
        private static void PrintCharacterOnLine(string character, int totalCharacter)
        {
            for (int j = 1; j <= totalCharacter; j++)
            {
                Console.Write(character);
            }
        }

        static void Caculator()
        {
            int numberFirst;
            int numberSecond;
            int result = 0;
            String caculate;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số thứ nhất: ");
            numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ hai: ");
            numberSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào phép toán: ");
            caculate = Console.ReadLine();

            switch (caculate)
            {
                case "+":
                    result = numberFirst + numberSecond;
                    break;
                case "-":
                    result = numberFirst - numberSecond;
                    break;
                case "x":
                case "X":
                case "*":
                    result = numberFirst * numberSecond;
                    break;
                case ":":
                case "/":
                    result = numberFirst/numberSecond;
                    break;
                default:
                    caculate = "+";
                    result = numberFirst + numberSecond;
                    break;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, caculate, numberSecond, result);
        }

        static void Avg()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int numberTotal = 0;
            int numberStart = 1;
            int numberSum = 0;

            Console.WriteLine("Nhập vào tổng số con số muốn tính giá trị trung bình: ");
            numberTotal = Convert.ToInt32(Console.ReadLine());

            while (numberStart <= numberTotal)
            {
                Console.WriteLine("Nhập vào số thứ {0}: ", numberStart);
                numberSum += Convert.ToInt32(Console.ReadLine());
                numberStart++;
            }
            Console.WriteLine("Giá trị trung bình là {0} : ", (double)numberSum/numberTotal);
        }

        static void ExeBCCThree()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int numberStart = 0;

            Console.WriteLine("Enter your age:");
            try
            {
                numberStart = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                numberStart = 2;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numberStart, i, numberStart * i);
            }
        }

        static void ExeBCCTwo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write("{0} x {1} = {2} \t", j, i, i*j);
                }
                Console.WriteLine();
            }
        }

        static void ExeBCCOne()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 2; i <= 9; i++)
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
