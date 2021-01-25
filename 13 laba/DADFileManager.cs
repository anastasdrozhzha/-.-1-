using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_laba
{
    class DADFileManager
    {
        public static void DiskReader(StreamWriter streamWriter, string str)
        {
            DADLog.DADWriter(streamWriter, "Создаём файлик DADInspect");//пишем в файл начало создания DADInspect
            Directory.CreateDirectory("DADInspect");//создаем необходимую директорию
            FileStream fs = File.Create("DADInspect\\DADdirinfo.txt");//создаем файл
            fs.Close();

            DADLog.DADWriter(streamWriter, "А теперь предлагаю что-нибудь записать в DADdirinfo.txt");//пишем в файл создание ADPdirinfo.txt
            StreamWriter sw = new StreamWriter("DADInspect\\DADdirinfo.txt");// в директорию в файл ADPdirinfo.txt открываем поток
            DirectoryInfo dir = new DirectoryInfo(str);//получаем информацию о директории

            if (dir.Exists)
            {
                DirectoryInfo[] d = dir.GetDirectories();//если существует получаем директории и файлы
                FileInfo[] f = dir.GetFiles();

                for (int i = 0; i < d.Length; i++)//выводим все директоии и файлы
                {
                    Console.WriteLine(d[i].Name);
                    sw.WriteLine(d[i].Name);
                }
                for (int i = 0; i < f.Length; i++)
                {
                    Console.WriteLine(f[i].Name);
                    sw.WriteLine(f[i].Name);
                }
                sw.Close();

                DADLog.DADWriter(streamWriter, "А давайте копирнем все туды--> DADdirinfo to DADdirinfocopy");//пишем в файл "копирование директория"
                if (File.Exists("DADInspect\\DADdirinfocopy.txt"))//перемещаем файл создавая его копию, после удаляем 
                {
                    File.Delete("DADInspect\\DADdirinfocopy.txt");
                }
                FileInfo q = new FileInfo("DADInspect\\DADdirinfo.txt");
                q.CopyTo("DADInspect\\DADdirinfocopy.txt");
                File.Delete("DADInspect\\DADdirinfo.txt");

                Directory.CreateDirectory("DADFiles");
                DADLog.DADWriter(streamWriter, "А ну-ка создадим DADFiles");
                DADLog.DADWriter(streamWriter, "А сейчас запишем в DADFile");
                for (int i = 0; i < f.Length; i++)
                {
                    if (f[i].Extension == ".pdf")
                    {
                        if (File.Exists("DADFiles\\" + f[i].Name))
                        {
                            File.Delete("DADFiles\\" + f[i].Name);
                        }
                        f[i].CopyTo("DADFiles\\" + f[i].Name);
                    }
                }

                ///////////////срабатывает исключение при не первом запуске... удалить перед работой
                ///
                DirectoryInfo d1 = new DirectoryInfo("DADFiles");//перемещаем директорий
                d1.MoveTo("DADInspectMe");

                DADLog.DADWriter(streamWriter, "Я захотел переместиться DADFiles");

                DADLog.DADWriter(streamWriter, "Запихихнули меня в зип DADFiles");
                ZipFile.CreateFromDirectory("DADInspect", "DAD.zip");
                DADLog.DADWriter(streamWriter, "ННЕЕЕЕТТ! Хочу обратно!!!!!!!! DADFiles");
                ZipFile.ExtractToDirectory("DAD.zip", "DADEnd");
            }
        }
    }
}
    
