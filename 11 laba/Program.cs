/*1. Задайте массив типа string, содержащий 12 месяцев (June, July, May,
December, January ….). Используя LINQ to Object напишите запрос выбирающий
последовательность месяцев с длиной строки равной n, запрос возвращающий
только летние и зимние месяцы, запрос вывода месяцев в алфавитном порядке,
запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х..

2. Создайте коллекцию List<T> и параметризируйте ее типом (классом)
из лабораторной №3 (при необходимости реализуйте нужные интерфейсы).

3. На основе LINQ сформируйте следующие запросы по вариантам.
При необходимости добавьте в класс T (тип параметра) свойства.

4. Придумайте и напишите свой собственный запрос, в котором было
бы не менее 5 операторов из разных категорий: условия, проекций,
упорядочивания, группировки, агрегирования, кванторов и разиения.

5. Придумайте запрос с оператором Join*/




using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_лаба
{
    class Program
    {

        public partial class Customer
        {
            public string name;
            public string Name
            {
                set
                {
                    if (value.Length == 0)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        name = value;
                    }
                }
                get { return name; }
            }
            public string secondname;
            public string Secondname
            {
                set
                {
                    if (value.Length == 0)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        secondname = value;
                    }
                }
                get { return secondname; }
            }
            readonly int ID;
        }
        public partial class Customer
        {
            public string patronymic;
            public string Patronymic
            {
                set
                {
                    if (value.Length == 0)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        patronymic = value;
                    }
                }
                get { return patronymic; }
            }
            public string adress;
            public string Adress
            {
                get
                {
                    return adress;
                }

                private set
                {
                    adress = value;
                }
            }
            public long number;
            public long Number
            {
                set
                {
                    if (value > 10000000000000000)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        number = value;
                    }
                }
                get { return number; }
            }
            public double balance;
            public double Balance
            {
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        balance = value;
                    }
                }
                get { return balance; }
            }
            public const string market = "Bezway";     //поле-константа
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (obj.GetType() != this.GetType()) return false;
                Customer byuer = (Customer)obj;
                return (this.Name == byuer.Name && this.Secondname == byuer.Secondname);

            }
        }

        public class Data
        {
            public int number;
            public int Number { get; set; }

            public string month;
            public string Month { get; set; }
            public int year;
            public int Year { get; set; }
            public Data(int n, string a, int k) { number = n; month = a; year = k; }

        }

        static void Main(string[] args)
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("ArrayList of mounth");
            foreach (string m in month)
                Console.WriteLine(m + "; ");

            Console.WriteLine("~~~~~~~~Intire the number of letters that program can finf them");
            int n = int.Parse(Console.ReadLine());
            IEnumerable<string> Months = month.Where(m => m.Length == n);
            foreach (string item in Months)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("~~~~~~~~Month of winter and summer");
            IEnumerable<string> Month_2 = month.Where(p => p.StartsWith("Au") || p.StartsWith("J") || p.StartsWith("F") || p.StartsWith("D"));
            foreach (string s in Month_2)
                Console.WriteLine(s);

            Console.WriteLine("~~~~~~~~Sorted List");
            IEnumerable<string> Months_3 = month.OrderBy(s => s);
            foreach (string item in Months_3)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("~~~~~~~~Word contains u");
            IEnumerable<string> Month_4 = month.Where(n => n.Contains("u") && n.Length >= 4);
            foreach (string k in Month_4)
            {
                Console.WriteLine(k);
            }



            Console.WriteLine("~~~~~~~~List of class from laba 3");

            Customer buyer_5 = new Customer();
            buyer_5.name = "Виктор ";
            buyer_5.secondname = "Матвиенко";
            buyer_5.patronymic = "Олегович";
            buyer_5.adress = "Одоевского 23-55";
            buyer_5.balance = 25678594;
            buyer_5.number = 2500225789153645;

            Customer buyer_3 = new Customer();
            buyer_3.name = "Ярослав ";
            buyer_3.secondname = "Петушков";
            buyer_3.patronymic = "Дмитриевич";
            buyer_3.adress = "Свердлова 73-15";
            buyer_3.balance = 256;
            buyer_3.number = 7890256189456700;

            List<Customer> ListOfCustomer = new List<Customer>();
            ListOfCustomer.Add(buyer_3);
            ListOfCustomer.Add(buyer_5);
            var sortedCustomers = from u in ListOfCustomer
                                  orderby u.Name
                                  select u;
            foreach (Customer u in sortedCustomers)
                Console.WriteLine(u.Name);



            Data date1 = new Data(15, "February", 2001);
            Data date2 = new Data(24, "March", 1985);
            Data date3 = new Data(19, "October", 2020);

            List<Data> ListOfData = new List<Data>();
            ListOfData.Add(date1);
            ListOfData.Add(date2);
            ListOfData.Add(date3);

            var sortedData = from u in ListOfData
                             orderby u.Number
                             select u;
            foreach (Data u in sortedData)
                Console.WriteLine(u.Month);

        }
    }
}

