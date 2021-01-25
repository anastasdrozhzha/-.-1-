using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Tracing;


namespace _3_laba
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Список покупателей: ");

            Customer buyer_1 = new Customer();
            buyer_1.name = "Виктор ";
            buyer_1.secondname = "Матвиенко";
            buyer_1.patronymic = "Олегович";
            buyer_1.adress = "Одоевского 23-55";
            buyer_1.balance = 25678594;
            buyer_1.number = 2500225789153645;
            buyer_1.Info();
            buyer_1.Get();


            Customer buyer_2 = new Customer(); //Экземпляр класса без конструктора=> автоматическое 
                                              //представление констуктора с параметрами по умолчанию
            buyer_2.Info();
            buyer_2.Get();
            
            Customer buyer_3 = new Customer();
            buyer_3.name = "Ярослав ";
            buyer_3.secondname = "Петушков";
            buyer_3.patronymic = "Дмитриевич";
            buyer_3.adress = "Свердлова 73-15";
            buyer_3.balance = 256;
            buyer_3.number = 7890256189456700;
            buyer_3.Info();
            buyer_3.Get();
            double count=0;
            buyer_3.Sum(buyer_3.balance,25, out count);
            Console.WriteLine("Новая сумма "+count);

            Customer buyer_4 = new Customer()
            {
                name = "Александр ",
                secondname = "Крабов",
                patronymic = "Викторович",
                adress = "Краково 15-15",
                balance = 12354,
                number = 1780254691587654,
            };
            buyer_4.Info();

            Customer buyer_5 = new Customer();
            buyer_5.name = "Виктор ";
            buyer_5.secondname = "Матвиенко";
            buyer_5.patronymic = "Олегович";
            buyer_5.adress = "Одоевского 23-55";
            buyer_5.balance = 25678594;
            buyer_5.number = 2500225789153645;
            buyer_5.Info();
            buyer_5.Get();



            Console.WriteLine("\nСортировка массива по алфавиту:");
            string[] Sort = { buyer_1.name + buyer_1.secondname,
                buyer_2.name + buyer_2.secondname,
                buyer_3.name + buyer_3.secondname,
                buyer_4.name + buyer_4.secondname
            };
            Array.Sort(Sort);
            foreach (string str in Sort)
                Console.WriteLine(str);

            Console.WriteLine("\nСортировка массива по номеру лицевого счета: ");
            string[] Customers = { buyer_1.name + buyer_1.secondname,
                buyer_2.name + buyer_2.secondname,
                buyer_3.name + buyer_3.secondname,
                buyer_4.name + buyer_4.secondname
            };
            long[] Count = { buyer_1.number, buyer_2.number, buyer_3.number, buyer_4.number };
            for (int i = 0; i < Count.Length; i++)
            {
                if (Count[i] > 2000000000000000 && Count[i] < 3000000000000000)
                {
                    Console.WriteLine(Customers[i]);
                }
            }
            Console.WriteLine("\nДополнительные задания из документа");
            var user = new
            {
                name = "Alex",
                secondname = "bruto",
                number = 654864685,
                balance = 23645345,
                ID = 123456789,
                adress = "Свердлова 73-15",
                market = "Bezway"
            };  //анонимный тип
            Console.WriteLine($"У покупателя {user.name} {user.secondname}  ID :{user.ID}," +
               $" он проживает по адресу {user.adress}," +
               $" имеет {user.balance} byn," +
               $"В банке {user.market}");
            
            Console.WriteLine(buyer_1.Equals(buyer_3));
            Console.WriteLine(buyer_2.GetHashCode());
            Console.WriteLine(buyer_4.ToString());
            Console.WriteLine(buyer_4.Equals(buyer_3));
            Console.WriteLine(buyer_3.GetHashCode());
            Console.WriteLine(buyer_1.ToString());
        }
    }
        
      
    } 
       
    
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
                if (value >10000000000000000 )
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

    //  private static int counter;//статическое поле
    //private Customer() { }   //закрытый конструктор, который запрещает создание конструктора без параметров

    /* static Customer()  // статический конструктор
    {
        int counter = 0;
         Console.WriteLine("0 objects");
     }
     public Customer()
     {
     counter++;
     Console.WriteLine(counter);
     }

     public Customer(int ID) //конструктор без параметров
     {  name = "Валентин"; 
     number = 1234567;
     balance = 123456789123456;}

     /*public Customer(string nm, long nmb, double blc) // конструктор с параметрами
     {
     name = nm; 
     number = nmb;
     balance = blc;}
       public string Name { get { return name; } set { name = value; } 
     }
   */
    public Customer()   //для каждого айди задаёт рандомное значение       
        {
            Random rnd = new Random();
            int value = rnd.Next();
            ID = value;
        }

        public void Info()
        {
            Console.WriteLine($"У покупателя {name} {secondname} {patronymic} ID :{ID}," +
                $" он проживает по адресу {adress}," +
                $" имеет {balance} byn," +
                $"В банке {market}");

        }
        public void Get()           //Метод добавления и списания денег на балансе у пользователей
        {
            if (balance < 50000)
            {
                balance += 23400;
                Console.WriteLine($"Сумма успешно добавлена {balance }");
            }
            if (balance > 500000)
            {
                balance -= 345567;
                Console.WriteLine($"Сумма успешно списана {balance}");
            }
        }

    public void Sum(double balance,int proc, out double sum)
   
    { 
            sum = balance / proc + balance;  
    }

    public override int GetHashCode()
    {
        // 269 или 47 простые
        int hash = 47;
        hash = string.IsNullOrEmpty(Name) ? 0 : Name.GetHashCode();
        hash = (hash * 47) + balance.GetHashCode();
        return hash;
    }
    public override string ToString()
    {
        return "Type" + " " + base.ToString() + secondname;
    }
}   
       

    

