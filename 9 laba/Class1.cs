using System;
using System.Collections.Generic;
using System.Text;

namespace _9_лаба
{
    public delegate void Message();

    abstract class Infa
    {
     
        public virtual void Addiction() { }
        public  int Salary;
        public int Expirience;
        public static int Fool;
       
        public string Name { get; set; }
        public Infa(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine($"This employee's name is {Name}");
        }

    }
}
