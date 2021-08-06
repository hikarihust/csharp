using System;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SplitArray();
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

            Console.WriteLine("Chắn: " + String.Join(",", arrEven));
            Console.WriteLine("Lẻ: " + String.Join(",", arrOdd));
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
