using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CheckID();
        }

        static void CheckID()
        {
            // Nhận ID nhập vào từ bàn phím, In ra hợp lệ hoặc không hợp lệ. ID hợp lệ thỏa
            // Chiều dài 9 ký tự có dạng XZZZ-YYYX
            // X Ký đầu tiên và ký tự cuối cùng phải là số chẵn (khác không, 2 4 6 8)
            // Z là tập hợp các ký tự chữ thường a b c d e
            // Y là tập hợp các ký tự in hoa hoặc ký tự số lẻ

            string id = "2abc-B138";
            bool flagCheck = false;

            Regex regex = new Regex(@"^[2468]([a-e]{3})-([A-Z]|[13579]){3}[2468]$"); // AB BX HD NG AX
            Match match = regex.Match(id);
            if (match.Success)
            {
                flagCheck = true;
            }

            if (flagCheck == true) Console.WriteLine("Hợp lệ");
            else Console.WriteLine("KHÔNG Hợp lệ");
        }
    }
}
