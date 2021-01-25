using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_laba
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = DADLog.CreateStreamWriter("1.txt");

            DADDiskInfo.FreeSpace(file);
            DADDiskInfo.FileInfo(file);
            DADDiskInfo.DiskInfo(file); Console.WriteLine();

            DADFileInfo.FullDirection(file, "1.txt");
            DADFileInfo.FileInfo(file, "1.txt");
            DADFileInfo.CreationTime(file, "1.txt"); Console.WriteLine();

            DADDirInfo.CreationTime(file, "..");
            DADDirInfo.FileCount(file, "..");
            DADDirInfo.DirCount(file, "..");
            DADDirInfo.ParentsCount(file, ".."); Console.WriteLine();

            try
            {
                DADFileManager.DiskReader(file, "D://");
            }
            catch (IOException) { };
            // file.WriteLine("Мой любимое занятие- это спать!");
            try
            {
                DADFileManager.DiskReader(file, "D://");
            }
            catch (IOException) { };
            file.Close();      


            Console.ReadKey();

        }
    }
}
