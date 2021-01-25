using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_laba
{
    class DADDiskInfo
    {

        private static DriveInfo[] Drive = DriveInfo.GetDrives();//Возвращает имена всех логических дисков на компьютере

        public static void FreeSpace(StreamWriter streamWriter)//инф о свободном месте на диске
        {
            DADLog.DADWriter(streamWriter, "А СВОБОДНОЕ МЕСТЕЧКО НЕ НАЙДЕТСЯ???? ");
            for (int i = 0; i < Drive.Length; i++)
            {
                if (Drive[i].IsReady)//готов ли диск к работе
                {
                    Console.WriteLine(Drive[i].Name + " свободное место: " + Drive[i].AvailableFreeSpace);
                }
            }
        }

        public static void FileInfo(StreamWriter streamWriter)//вывод информации о файловой системе
        {
            DADLog.DADWriter(streamWriter, "Инфа о системе");
            Console.WriteLine($"Информативный пунктик о файловой системе: {Drive[0].DriveFormat}");
        }

        public static void DiskInfo(StreamWriter streamWriter)//имя, объем, доступный объем, метка тома каждого существующего диска
        {
            DADLog.DADWriter(streamWriter, "Опп, инфушка о диске");
            for (int i = 0; i < Drive.Length; i++)
            {
                if (Drive[i].IsReady)
                {
                    Console.WriteLine($"[{Drive[i].Name}] " +
                        $"Размерчик диска: {Drive[i].TotalSize}, " +
                        $"Неужели есть свободное место?? Надо глянуть: {Drive[i].AvailableFreeSpace}, " +
                        $"Метка томика: {Drive[i].VolumeLabel}");
                }
            }
        }
    }
}

