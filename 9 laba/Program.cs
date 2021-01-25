using System;
using System.Linq;

namespace _9_лаба
{
    class Program
    {

        public class WorkString 
        {
            public static string RemoveString(string str)  //удаление знаков препинания
            {
                char[] signs = { '.', ',', '!', '?', '-', ':' };
                for (int i = 0; i < str.Length; i++)
                {
                    if (signs.Contains(str[i]))
                    {
                        str = str.Remove(i, 1);
                    }
                }
                return str;
            }
            public static string AddString(string str)  //Добавление подстроки
            {  
                return str += "Дополнительная строка добавлена в исзодную";
            }
            public static string UpString(string str)  //
            {
                return str.ToUpper();
            }
            public static string RemovePr(string str)  //удаление
            {
                return str.Replace(" ","");
            }
            public static string LowString(string str)  //
            {
                return str.ToLower();
            }

        }
        public class Worker : Infa
        {
            //Событие Notify c типом делегата Message.
            public event Message Notify;
            public Worker(string name, int fool) : base(name)
            {
                Fool = fool;
            }
            public string Position;
            public Worker(string name, string pos, int exp, int fool, int salary) : base(name)
            {
                Position = pos;
                Expirience = exp;
                Fool = fool;
                Salary = salary;
            }
            public override void Display()
            {
                Console.WriteLine($"This employee's name is {Name} and his position is {Position}: the salary is {Salary}");
            }
            
            public override void Addiction()       //метод добавления бонусов
            {
                if (Expirience > 3)
                {
                    Salary += 150;
                    Notify();                       //хапускаю событие в условиях кода
                    Console.WriteLine($"{Name} has bonus to salary");
                }
            }
        }

        public class Student : Infa
        {
            
            public event Message Notify2;
            public int Kurs;
            public override void Display()
            {
                Console.WriteLine($"This student's name is {Name} and salary is {Salary}");
            }
           
            public override void Addiction()       //метод добавления бонусов
            {
                if (Expirience > 3)
                {
                    Salary += 150;
                    Notify2(); //хапускаю событие в условиях кода
                    Console.WriteLine($"{Name} has bonus to salary");
                }
            }
            public Student(string name, int kurs) : base(name)
            {
                Kurs = kurs;
            }
            public string Position;
            
            public Student(string name, string pos, int exp, int fool, int salary) : base(name)
            {
                Position = pos;
                Expirience = exp;
                Fool = fool;
                Salary = salary;
            }

        }
        public class Director : Infa
        {
          
            public int Unic;
            public Director(string name, int unic) : base(name)
            {
                Unic = unic;
            }

            static void Main(string[] args)
            {

                Worker One = new Worker("Maxim", "Ingeneer", 8, 2, 2056);
                Worker Two = new Worker("Helena", "Ingeneer", 6, 0, 1890);
                Student Four = new Student("Brain", "Student", 6, 5, 1508);
                Student Five = new Student("Flor", "Student", 0, 0, 1067);
               
                One.Display();
                Two.Display();
                Four.Display();
                Five.Display();
                
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                One.Notify += One.Display;
                Two.Notify += Two.Display;
                Four.Notify2 += Four.Display;
                Five.Notify2 += Five.Display;
                

                One.Addiction();
                Two.Addiction();
                Four.Addiction();
                Five.Addiction();

                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                Func<string, string> work = WorkString.RemoveString;///стандартный делегат Func
                string str = Console.ReadLine();
                Console.WriteLine($"\nBefore: {str}\nAfter: {str = work(str)}\n");
                work = WorkString.UpString;
                Console.WriteLine($"\nBefore: {str}\nAfter: { str = work(str)}\n");
                work = WorkString.AddString;
                Console.WriteLine($"\nBefore: {str}\nAfter: {str = work(str)}\n");
                work = WorkString.RemovePr;
                Console.WriteLine($"\nBefore: {str}\nAfter: {str = work(str)}\n");
                work = WorkString.LowString;
                Console.WriteLine($"\nBefore: {str}\nAfter: {str = work(str)}\n");

            }
        }
    }
}
