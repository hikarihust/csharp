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
            StuyList();
        }

        static void StuyList()
        {
            var cities = new List<string>();
            cities.Add("New York"); // index=0  value=
            cities.Add("London");   // index=1
            cities.Add("Mumbai");   // 2
            cities.Add("Chicago");  // 3

            // Truy cập / In các phần tử
            // cities.ForEach(item => Console.WriteLine(item + ", "));
            // for (int i = 0; i < cities.Count; i++) Console.WriteLine(cities[i]);

            // Truy cập 1 phần tử
            // Console.WriteLine("1: " + cities[0]);

            // Thêm mói ADD or INSERT
            cities.Insert(1, "HCM");

            // KIểm tra tồn tại
            if (cities.Contains("HCM"))
            {
                Console.WriteLine("CÓ");
            }
            else
            {
                Console.WriteLine("KHÔNG CÓ");
            }

            // Remove
            // cities.RemoveAt(1);
            //for (int i = 0; i < cities.Count; i++) Console.WriteLine(cities[i]);

            // Update 
            cities[1] = "Hồ Chí MInh";
            for (int i = 0; i < cities.Count; i++) Console.WriteLine(cities[i]);
        }

        static void CheckDate()
        {
            // Nhận chuỗi ngày sinh nhập vào từ bàn phím, In ra hợp lệ hoặc không hợp lệ. ID hợp lệ thỏa
            // Chiều dài 8 ký tự có dạng XX-YY-ZZZZ
            // XX ngày sinh
            // YY tháng sinh
            // ZZZZ là năm sinh (ZZZZ phải có giá trị từ năm 1945 - năm hiện tại) // 2021
            // Kiểm tra xem ngày tháng năm có hợp lệ hay không  31/02/2021 ko hợp lệ

            string dateInput = "30-11-2000";
            bool flagCheck = false;

            Regex regex = new Regex(@"^\d{2}-\d{2}-\d{4}$");
            Match match = regex.Match(dateInput);
            if (match.Success)
            {
                try
                {
                    DateTime dateTime = DateTime.ParseExact(dateInput, "dd-MM-yyyy", null);
                    int dateInputYear = dateTime.Year;
                    int currentYear = DateTime.Now.Year;

                    if (dateInputYear < currentYear && dateInputYear > 1945) flagCheck = true;
                }
                catch (Exception)
                {
                    flagCheck = false;
                }
            }

            if (flagCheck == true) Console.WriteLine("Hợp lệ");
            else Console.WriteLine("KHÔNG Hợp lệ");
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
