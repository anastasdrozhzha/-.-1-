using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         //Задание 1. Типы 

         // a)
         int fir = 28;
         double sec = 25.2582564;
         float thir = 55.35F;
         long four = 0x10a;
         byte five = 3;
         short six = -2435;
         bool sev = true;
         char eig = 'A';

         //b)Неявные

         int a = 256;
         long b = a; 
         byte d = 102;
         short c = d; 
         float g = 35.21531F;
         double k = g;
         long z = 21382654;
         float x = z;
         short s = -256;
         long q = s;

         //Явные
         a = (short)s;
         s = (byte)d;
         k = (float)g;
         z = (int)a;
         c = (byte)d;

         //c)
         int ch = 36;
         object o = ch;
         int ck=(int)ch;

         //d)
         var h = 342.51;
         var m = -42;

         //е)
         int ? w = null;
         Nullable<int> w2 = 34;

        /* Console.WriteLine("Введенные числа: " + fir + " " + sec + " " + thir + " " + four + " " + five + " " + six + " " + sev + " "+ eig );
         Console.WriteLine("Неявные преобразования: " + b + " " + c + " "+ g + " "+ x + " " + q);
         Console.WriteLine("Явные преобразования: " + a + " " + s + " " + k + " " + z + " " + c);
         Console.WriteLine("Распоковка и обратно "+ch+" "+ck);
         Console.WriteLine("Типизированные переменные " + h + " " +m);
         Console.WriteLine("Nullable " + w + " " + w2);
         Console.ReadLine();

            //Задание 2. Строки
            //а)
            string path = "Мы встречались с тобой на закате ";
            string path2 = "Ты веслом рассекала залив";
            //b)
            string str = "Если бы люди могли знать,";
            string str2 = "кто думает о ниx переед сном,";
            string str3 = "счастья в этом мире было бы больше";
            string str4= str3.Substring(0, 20);
            path = path.Insert(33, path2);
            string str5 = "0215Стремись не к успеху, а к ценностям, что он дает";
            str5 = str5.Remove(0,4);
            //c)
            string s = string.Empty;
            string s2 = null;

            Console.WriteLine(String.Compare(path,path2));
            Console.WriteLine(String.Concat(str,str2,str3));
            Console.WriteLine(String.Copy(str3));
            Console.WriteLine(str4);

            string[] words = str3.Split(' ');
            foreach (var word in words)
            Console.WriteLine(word);

            Console.WriteLine(path);
            Console.WriteLine(str5);

            Console.ReadLine();
          //d Строка на основе StringBuilder

            StringBuilder sb = new StringBuilder("У всего есть своя красота, но не каждый может ее увидеть.////", 70);
            sb.Insert (0, "~~~ ");
            sb = sb.Remove(57, 4);
            Console.WriteLine("{0} chars: {1}", sb.Length);
            Console.ReadLine();*/

            //Задание 3. Массивы
            //a) Матрица
            /*int n = 2, m = 3;
            int[,] mas = { { 12,12,56 }, { 75, 15,65 } };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(String.Format("{0,3}", mas[i, j]));
                Console.WriteLine();
            }
            //b)Одномерный массив строк
            
            string[] line = { "Упади", "семь", "раз", "и", "восемь", "раз", "поднимись" };
            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine(line[i]);
            }
            Console.WriteLine(line.Length);
            
         
            string temp = line[5];
            line[3] = temp;
            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine(line[i]);
            }
            Console.ReadLine();
            
            //c Ступенчатый массив
            int[][] array = new int[3][];
            array[0] = new int[2];
            array[1] = new int[3];
            array[2] = new int[4];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("Введите число в массив");
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.Write("\n");
            }
            //d Создание неявно типизированных переменных
            var array = new[] { 130, 580, 230, 100 };
            var str = new[] { "Огни ночной Москвы" };
            
            //Задание 4. Кортежи
            //a.b
            ValueTuple<int, string, char, string, ulong> name = (25, "love", '=', "boy", 2651684651);
            ValueTuple<int, string, char> name_2 = (25, "love", '=');
            Console.WriteLine(name);
            Console.WriteLine(name.Item3);
            Console.WriteLine(name.Item1);
            Console.WriteLine(name.Item4);
            //d
            Console.WriteLine(name.Equals(name_2)); 

            
           
            //c Распаковка кортежа
            var Student = new Tuple <int, string, string,int,int>(2001,"Настя","Дрожжа",11,2 );
            Console.WriteLine("Студентка " + Student.Item1+" года рождения. По имени " + Student.Item2+" "+ Student.Item3+ " группы "+Student.Item4+" "+Student.Item5+" курса");
            */
            //Задание 5 Создание локальной функции

            int[] Array = { 2, 65, 25, 59, 1, 23, 15, 0 };
            string str = ("Новая строка для 5 задания");
            Console.WriteLine(TupleBack(Array, str));
                //Задание 5 Создание локальной функции
           (int,int,int,char) TupleBack(int[] Array, string str) 
            {
                int max;
                max = Array[0];
                int min = Array[0];
                int sum = 0;
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] > max)
                    {
                        max = Array[i];
                    };
                    if (Array[i] < min)
                    {
                        min = Array[i];
                    };

                    sum += Array[i];
                }                    
                char one = Convert.ToChar(str.Substring(0, 1));
                (int, int, int, char) result = (max, min, sum, one);
                return result;
                
            }   
         }
    }
}
