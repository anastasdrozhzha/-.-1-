using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_laba
{
    class DADLog
    {
        public static StreamWriter CreateStreamWriter(string line)//Создает экземпляр класса записи в файл
        {
            StreamWriter streamWriter = new StreamWriter(line);
            return streamWriter;
        }
        public static StreamReader CreateStreamReader(string line)//Создает экземпляр класса чтение из файла
        {
            StreamReader streamReader = new StreamReader(line);
            return streamReader;
        }
        public static void DADWriter(StreamWriter streamWriter, string info)//Запись в файл время создания записи и запись 
        {
            streamWriter.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ", " + DateTime.Now.Day
                + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "\n");
            streamWriter.WriteLine(info);
        }
        public static void CloseStream(StreamWriter streamWriter)//Закрываем файл
        {
            streamWriter.Close();
        }
        public static string DADReader(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }
        public static void DADSearcher(StreamReader streamReader, string info)//Поиск в файле 
        {
            string text = DADReader(streamReader);
            if (text.Contains(info))
            {
                Console.WriteLine("Эта информация содержится в файле ");
            }
            else
            {
                Console.WriteLine("Упсс.. А её тут неть...");
            }
        }
    }
}

