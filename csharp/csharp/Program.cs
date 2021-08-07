﻿using System;
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
            StringID();
        }

        static void StringID()
        {
            int id = 69;

            // ID
            //                       1  2                                               3   
            string str = "78, 60,62,69,69,68,73,85,66  ,69,65,74,63,67 ,65,64,68,73,75,69,73,169";
            int count = 0;

            string[] idArr = str.Split(',');

            // string -> array      split
            // array  -> string     join
            for (int i = 0; i < idArr.Length; i++)
            {
                int idCurrent = Int32.Parse(idArr[i]);
                if (idCurrent == id) count++;
            }

            Console.WriteLine("ID {0} đi trễ {1} lần", id, count);
        }

        static void StringReverse()
        {
            string str = "  J a e Va c SHARP ";

            // Xóa ký khoảng trắng trong chuỗi						  JaVa 
            str = Regex.Replace(str, @"[\s]", "");

            // Chuyển chuỗi sang dạng ký tự đối lập hoa / thường	  jAvA
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    str = str.Remove(i, 1).Insert(i, Char.ToLower(str[i]) + "");
                }
                else
                {
                    str = str.Remove(i, 1).Insert(i, Char.ToUpper(str[i]) + "");
                }
            }

            Console.WriteLine(str);
            Console.WriteLine(str.Length);
        }

        static void StringRemove()
        {
            //            012345
            string str = "ab239JA2VAc1de";

            // Xóa ký tự thứ hai và ký tự kế cuối			a239JA2VAc1e
            str = str.Remove(1, 1);
            str = str.Remove(str.Length - 2, 1);

            // Xóa các ký tự SỐ trong chuỗi					aJAVAce
            str = Regex.Replace(str, @"[\d]", string.Empty);

            // Thêm giá trị quangvu vào giữa chuỗi		aJAVquangvuAce
            str = str.Insert(str.Length / 2, "quangvu");
            Console.WriteLine(str);
        }

        static void Document()
        {
            // Xóa các ký tự SỐ trong chuỗi					aJAVAce
            // a239JA2VAc1e
            // 01
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    if (Char.IsNumber(str[i]))
            //    {
            //        str = str.Remove(i, 1);
            //    }
            //}
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
