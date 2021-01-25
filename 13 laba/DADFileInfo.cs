using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_laba
{
    class DADFileInfo
    {
        public static void FullDirection(StreamWriter streamWriter, string f)//выводим полный путь до файла
        {
            DADLog.DADWriter(streamWriter, "Долгий ппуть может даже и не домой");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Полное имечко: {fi.DirectoryName}\\{fi.Name}");
            }
        }
        public static void FileInfo(StreamWriter streamWriter, string f)//Размер, расширение, имя
        {
            DADLog.DADWriter(streamWriter, "Информушка о файле");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Размерчик: {fi.Length}, расширение: {fi.Extension}, имечко: {fi.Name}");
            }
        }
        public static void CreationTime(StreamWriter streamWriter, string f)//Время создания файла
        {
            DADLog.DADWriter(streamWriter, "Хммм... Когда же я был создан???");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Так всё-таки...когда???? {fi.CreationTime}");
            }
        }
    }
}
