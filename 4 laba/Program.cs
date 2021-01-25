using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Set obj1 = new Set();
            obj1.Add(6);
            obj1.Add(2);
            obj1.Add(7);
            obj1.Add(9);
            obj1.Add(-6);
            obj1.Add(-5);
            Set obj2 = new Set();
            obj2.Add(5);
            obj2.Add(7);
            obj2.Add(2);
            obj2.Add(-8);
            Set obj3 = new Set();
            Console.WriteLine("Операция проверка множеств на неравенство: "+(obj1 < obj2));
            Console.WriteLine("Операция проверка на множества на подмножетва: "+(obj2 > obj1));
            var qw = obj2 >> 2;
            var qwe = obj2 << 9;
            var qqq = obj1 % obj2;
            Console.WriteLine("Операция пересечение множеств: "+qqq);
            Console.WriteLine("Операция на удаление элемента в множество: "+qw);
            Console.WriteLine("Операция на добавления элемента в множество: "+qwe);

            Set.Date Create = new Set.Date();
            Set.Date Create2 = new Set.Date();
            Set.Owner pro = new Set.Owner();
            Operation.Difference(obj2);
            Operation.Sum(obj2);
            Operation.Count(obj2);
            Operation.Short();
            Operation.Minus(obj1, obj3);



        }
    }
}
public class Set
{
    public static int count;
    public Set()
    {
        count++;
        Console.WriteLine($"Создано {count}-е множество");
    }
    public List<int> Items = new List<int>();

    public void Add(int _item) //Добавление элемента в множество
    {
        if (!Items.Contains(_item))
        {
            Items.Add(_item);
        }
    }
    public static string operator >>(Set item, int elem) //удаление элемента из множества
    {
        if (item.Items.Remove(elem))
        {
            return $"{elem} удалён из {item}";
        }
        else
        {
            return $"{elem} не удалён из {item}";
        }
    }
    public static string operator <<(Set item, int elem) //добавление элемента во множество
    {

        item.Items.Add(elem);
        for (int i = 0; i < item.Items.Count; i++)
        {
            Console.WriteLine(item.Items[i] + " ");
        }
        return $"{elem} добавлен в {item}";


    }

    public static bool operator >(Set item1, Set item2) // проверка на подмножество
    {
        int howMany = 0;
        foreach (int ch1 in item1.Items)
        {
            foreach (int ch2 in item2.Items)
            {
                if (ch1 == ch2)
                    howMany++;

            }

        }
        return (howMany == item1.Items.Count);

    }

    public static bool operator <(Set item1, Set item2) // проверка множеств на неравенство
    {
        if (item1.Items.Count != item2.Items.Count)
        {
            int howMany = 0;
            foreach (int ch1 in item1.Items)
            {
                foreach (int ch2 in item2.Items)
                {
                    if (ch1 != ch2)
                        howMany++;

                }

            }
            return (howMany != item1.Items.Count);

        }
        return false;

    }

    public static string operator %(Set item1, Set item2) //пересечение множеств
    {
        List<int> item3 = new List<int>();
        Console.WriteLine("Пересечение множеств");
        foreach (int ch in item1.Items)
        {
            if (item2.Items.Contains(ch))
            {
                item3.Add(ch);
            }

        }
        foreach (int cc in item3)
        {
            Console.WriteLine(cc);
        }
        return null;
    }

    public class Date
    {
        public static int count = 1;
        public string createdate;
        public Date()
        {

            createdate = DateTime.Now.ToString();
            Console.WriteLine($"Время создания {count} объекта {createdate}");
            count++;
        }
    }
    public class Owner
    {
        public int id = 256;
        public string name = "Nastya";
        public string organization = "Beazway";
    }
}
static public class Operation
{
    static int count;
    static int sum;
    static int max;
    static int min = 99999;
    public static void Sum(Set Item)

    {
        foreach (int ch in Item.Items)
        {
            sum += ch;
        }
        Console.WriteLine($"Сумма элементов {sum}");
    }
    public static void Difference(Set Item)
    {

        foreach (int ch in Item.Items)
        {
            if (ch > max)
            {
                max = ch;
            }
            if (ch < min)
            {
                min = ch;
            }
        }
        int raz = max - min;
        Console.WriteLine($"Разница между максимальным и минимальным элементом {raz}");
    }
    public static void Count(Set Item)
    {
        foreach (int ch in Item.Items)
        {
            count++;
        }
        Console.WriteLine($"Количество элементов {count}");
    }
    public static void Minus(this Set item, Set item2) // Удаление отрицательных элементов из множества
    {
        for (int i = 0; i < item.Items.Count; i++)
        {
            if (item.Items[i] >= 0)
            {
                item2.Items.Add(item.Items[i]);
            }
        }
        Console.WriteLine("После удаление отрицательных элементов");
        for (int i = 0; i < item2.Items.Count; i++)
        {
            Console.Write(item2.Items[i] + " ");
        }

    }
    public static void Short() //поиск короткого слова в строке
    {
        System.Console.WriteLine("Введите строку");
        string str = System.Console.ReadLine();
        string[] mas = str.Split(' ');
        int min = mas[0].Length;
        string ms = mas[0];
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i].Length < min)
            {
                min = mas[i].Length;
                ms = mas[i];
            }
        }

        Console.Write("Самое короткое слово ");
        Console.WriteLine(ms);

    }
}

