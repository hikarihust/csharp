using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace csharp
{
    class DataFile
    {
        private string fileName;
        private string delimiter;

        public DataFile(string path, string strDelimiter)
        {
            fileName = path;
            delimiter = strDelimiter;
        }

        public void Write(List<Book> data)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8);

                data.ForEach(item =>
                {
                    sw.WriteLine(item.Id + delimiter + item.Name + delimiter + item.Price);
                });

                sw.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Có lỗi hệ thống!!");
            }
        }

        public List<Book> Read()
        {
            List<Book> listItems = new List<Book>();
            try
            {
                StreamReader sr = new StreamReader(fileName, Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    // p9q$$$$$$PHP$$$$$$4
                    string[] arrOuput = line.Split(delimiter);
                    Book bookObj = new Book(arrOuput[0], arrOuput[1], Int32.Parse(arrOuput[2]));
                    listItems.Add(bookObj);

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception)
            {
                WriteLine.Error("Có lỗi đọc dữ liệu");
            }

            return listItems;
        }
    }
}
