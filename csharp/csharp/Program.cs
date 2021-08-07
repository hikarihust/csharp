using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SortArray();
        }

        static void SortArray()
        {
            // Nhận 1 mảng số nguyên từ bàn phím: 6 4 3 1
            // Mảng chưa được sắp xếp, bạn có muốn sắp xếp mảng không? (Y/N)
            // N - thoát in ra mảng
            // Y - Bạn muốn sắp xếp mảng theo thứ tự tăng dần hay giảm dần (1/0)
            // 1(tăng) - in ra mảng
            // 0(giảm) - in ra mảng
            // Mảng được sắp xếp theo thứ tự tăng dần
            // Mảng được sắp xếp theo thứ tự giảm dần

            // 01 Nhập mảng
            Console.WriteLine("Số phần tử của mảng: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arrayInput = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Phần tử {0}:", i + 1);
                arrayInput[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Xác nhận loại mảng
            int countGreater = 0;
            int countLess = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (arrayInput[i] >= arrayInput[i + 1]) countGreater++;
                if (arrayInput[i] <= arrayInput[i + 1]) countLess++;
            }

            if (countGreater == length - 1)
            {
                Console.WriteLine("Giảm dần");
            }
            else if (countLess == length - 1)
            {
                Console.WriteLine("Tăng dần");
            }
            else
            {
                Console.WriteLine("Mảng chưa sắp xếp, hãy chọn kiểu sắp xếp [1 - Tăng dần, 2 - Giảm dần]");
                int functionID = Convert.ToInt32(Console.ReadLine());

                if (functionID == 1)
                {
                    Array.Sort(arrayInput);
                }
                else
                {
                    Array.Sort(arrayInput);
                    Array.Reverse(arrayInput);
                }
                Console.WriteLine(String.Join(",", arrayInput));
            }
        }

        static void CountElement()
        {
            string[] arrString = { "Python", "PHP", "Java", "Javascript " };

            // output: [6, 3, 4, 11] là 1 mảng chứa các phần tử số là chiều dài của các phần tử chuỗi
            int length = arrString.Length;

            int[] arrayOuput = new int[length];

            for (int i = 0; i < length; i++)
            {
                arrayOuput[i] = arrString[i].Length;
            }

            Console.WriteLine(String.Join(",", arrayOuput));
        }

        static void SplitArrayOptimize()
        {
            int[] arrInt = { 9, 1, 5, 8, 2, 0 };
            IEnumerable<int> arrEven = arrInt.AsQueryable().Where((a, index) => a % 2 == 0);
            IEnumerable<int> arrOdd = arrInt.AsQueryable().Where((a, index) => a % 2 != 0);

            Console.WriteLine("Chắn: " + String.Join(",", arrEven));
            Console.WriteLine("Lẻ: " + String.Join(",", arrOdd));
        }

        static void SplitArray()
        {
            int[] arrInt = { 1, 2, 4, 8, 0, 4, 2, 3, 5, 1 };

            // Input: 1 array
            // Output: 2 array, chẵn 2, 4, 8, 0, 4, 2,  lẻ 1 3, 5, 1 
            int length = arrInt.Length;
            int indexArrEven = 0;
            int indexArrOdd = 0;

            int[] arrEven = new int[length];
            int[] arrOdd = new int[length];  // dư

            for (int i = 0; i < length; i++)
            {
                if (arrInt[i] % 2 == 0)
                {
                    arrEven[indexArrEven] = arrInt[i];
                    indexArrEven++;
                }
                else
                {
                    arrOdd[indexArrOdd] = arrInt[i];
                    indexArrOdd++;
                }
            }

            int[] arrEvenResult = new int[indexArrEven];
            int[] arrOddResult = new int[indexArrOdd];

            Array.Copy(arrEven, 0, arrEvenResult, 0, indexArrEven);
            Array.Copy(arrOdd, 0, arrOddResult, 0, indexArrOdd);

            Console.WriteLine("Chắn: " + String.Join(",", arrEvenResult));
            Console.WriteLine("Số phần tử Chắn: " + indexArrEven);
            Console.WriteLine("Lẻ: " + String.Join(",", arrOddResult));
            Console.WriteLine("Số phần tử lẻ: " + indexArrOdd);
        }

        static void Check()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arrInt = { 0, 4, 0, 4, 4 };
            int number = 4;

            for (int i = 0; i < arrInt.Length - 1; i++)
            {
                if (arrInt[i] + arrInt[i + 1] == number)
                {
                    Console.WriteLine("Success");
                    break;
                }
            }
        }

        static void Count()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arrInt = { 1, 2, 5, 8, 3 };

            int sumEven = 0;
            int sumOdd  = 0;
            int sumAll  = 0;

            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] % 2 == 0) sumEven += arrInt[i];
                else sumOdd += arrInt[i];
            }
            sumAll = sumEven + sumOdd;

            Console.WriteLine("Tổng phần tử chẵn: " + sumEven);
            Console.WriteLine("Tổng phần tử lẻ: " + sumOdd);
            Console.WriteLine("Tổng phần các phần tử: " + sumAll);
        }
    }
}
