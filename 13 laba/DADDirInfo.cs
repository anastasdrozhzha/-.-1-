using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_laba
{
    class DADDirInfo
    {
        public static void CreationTime(StreamWriter streamWriter, string s)
        {
            DADLog.DADWriter(streamWriter, "Когда ж я был создан?");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
                Console.WriteLine($"Время моего рождения: {dir.CreationTime}");
            else Console.WriteLine("Эхх, я отсутсвуюююю");
        }
        public static void FileCount(StreamWriter streamWriter, string s)
        {
            DADLog.DADWriter(streamWriter, "Колоичество мне подобных");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
            {
                FileInfo[] fi = dir.GetFiles();
                Console.WriteLine($"Количество сородичей: {fi.Length}");
            }
        }
        public static void DirCount(StreamWriter streamWriter, string s)
        {
            DADLog.DADWriter(streamWriter, "Количество поддиректориев");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists && dir.Extension == "")
            {
                DirectoryInfo[] d = dir.GetDirectories();
                Console.WriteLine($"Д...количество штучек: {d.Length}");
            }
        }
        public static void ParentsCount(StreamWriter streamWriter, string s)
        {
            DADLog.DADWriter(streamWriter, "Количество родителей у дирр...");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
            {
                Console.WriteLine($"Количество: {dir.Root}");
            }
        }
    }
}
