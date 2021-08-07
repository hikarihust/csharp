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
            StringCount();
        }

        static void StringCount()
        {
            string str = "JAVA";
            string[] arrInput = { "java", "JAVA", "php", "c#", "jaVA", "JaVa" };

            int resultOne = 0;
            int resultTwo = 0;
            int resultThree = 0;
            int resultFour = 0;

            foreach (string item in arrInput)
            {
                if (item.Equals(str)) // so sánh tuyệt đối
                {
                    resultTwo++;
                }
                else if (item.Equals(str, StringComparison.OrdinalIgnoreCase)) // KO phân biệt hoa thường
                {
                    resultThree++;
                }
                else
                {
                    resultFour++;
                }
                Console.WriteLine(item);
            }

            resultOne = arrInput.Length;

            Console.WriteLine("Tổng số phần tử so sánh: " + resultOne);     // 4
            Console.WriteLine("Trùng khớp tuyết đối: " + resultTwo);        // 1
            Console.WriteLine("Trùng khớp tương đối: " + resultThree);      // 2
            Console.WriteLine("Không trùng khớp: " + resultFour);           // 1
        }
    }
}
