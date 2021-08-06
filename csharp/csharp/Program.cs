using System;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Count();
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
