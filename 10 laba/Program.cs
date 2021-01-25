using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _10_laba
{
    class Program
    {
        public interface IEnumerable
        {       
            IEnumerator GetEnumerator();
        }
      
        class Student :IComparable<Student>
        {
            public string Name;
            public string Position;
            public int Age;
            public static bool Decription { get; set; }

            public Student(string name,string position)
            {
                Name = name;
                Position = position;
            }
            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public int CompareTo(Student p)
            { 
                return this.Age.CompareTo(p.Age);
            }
        }
            
      



        static void Main(string[] args)
        {
            //Task 1
            ArrayList MyList = new ArrayList();

            Random rnd = new Random();
            Student student = new Student("Настя", "2 курс");
            Student student2 = new Student("Костя", "2 курс");
            Student student3 = new Student("Вика", "2 курс");
            Student student4 = new Student("Милла", "2 курс");
            Student student5 = new Student("Люся", "2 курс");
            Student student6 = new Student("Нина", "2 курс");
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                MyList.Add(Convert.ToString(rnd.Next(1, 500)));
            }
            Console.WriteLine("New non-generic List:");
            foreach (object o in MyList) Console.Write(o + "; ");
            string str = "New string";
            MyList.Add(str);
            Console.WriteLine("\nString is added:");
            foreach (object obj in MyList) Console.Write(obj + "; ");
            MyList.Add(student);

            Console.WriteLine("Object is added:");
            foreach (object ob in MyList) Console.Write(ob + "; ");
            if (MyList.Contains(student))
            {
                Console.WriteLine("\nOur List contains this element");
            }
            else Console.WriteLine("This element didn't found");
            MyList.Remove(student);
            Console.WriteLine("\nObject is deleted:");
            foreach (object bo in MyList) Console.Write(bo + "; ");
            foreach (object o in MyList) count++;
            Console.WriteLine($"\nNumber of elements in our ArrayList is {count}");

            //2 Task
            Console.WriteLine($"\n New Array of float types:");
            List<float> NewList = new List<float>();
            Stack<float> NewStack = new Stack<float>();
            NewList.Add(-45.7f);
            NewList.Add(254.36f);
            NewList.Add(2513.3f);
            NewList.Add(2478.36548f);
            NewList.Add(-2521.3f);
            NewList.Add(-2486f);
            NewList.Add(45.7f);
            NewList.Add(-7452.365f);
            NewList.Add(-4523f);
            foreach (object bo in NewList) Console.Write(bo + "; ");
            NewList.RemoveRange(2, 3);
            Console.WriteLine($"\n Deleted range:");
            foreach (object o in NewList) Console.Write(o + "; ");
           
            foreach (object o in NewList)
            {
                NewStack.Push((float)o);
            }
            Console.WriteLine($"\n New Stack:");
            foreach (object o in NewStack) Console.Write(o + "; ");
            NewList.Insert(2, 253);
            NewList.AddRange(NewStack);
            Console.WriteLine($"\n Added methods: ");
            foreach (object bo in NewList) Console.Write(bo + "; ");
           if( NewStack.Contains(45.7f))
            {
                Console.WriteLine("\nOur List contains this element");
            }

            //Task 3
            Student student11 = new Student("Настя", 18);
            Student student22 = new Student("Костя", 2);
            Student student33 = new Student("Вика", 16);
            Student student44 = new Student("Милла", 45);
            Student student55 = new Student("Люся", 2);
            Student student66 = new Student("Нина", 76);

            Student[] people = new Student[] { student11, student22, student33, student44 ,student55, student66};
            

            Console.WriteLine("Our array of students: \n");
            foreach (Student p in people)
            {
                Console.WriteLine(p.Name);
            }

            foreach (Student p in people)
            {
                Console.WriteLine(student11.CompareTo(p));
            }

            var obsCol = new ObservableCollection<Student>();

            Student student57 = new Student("Люся", 2);
            Student student67 = new Student("Нина", 76);

            obsCol.CollectionChanged += ObsCollectionEventHandler;
            obsCol.Add(student57);
            obsCol.Add(student67);
            obsCol.Add(student67);
            obsCol.Remove(student57);
        }
        static void ObsCollectionEventHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine($"Действие - {e.Action}, объект - {e.NewItems}");
            if (e.Action == NotifyCollectionChangedAction.Remove)
                Console.WriteLine($"Действие - {e.Action}, объект - {e.OldItems}");
        }
    }
}
    

