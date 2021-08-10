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
    }
}
