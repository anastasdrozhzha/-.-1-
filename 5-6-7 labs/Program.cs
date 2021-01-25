using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using exersices_5 = exersices_5.Herb;



//Растение, Куст, Цветок, Роза, Гладиолус, Кактус, 
//Букет.
namespace exersices_5
{
    
    //7 лабораторная работа

        public class FlowExeption:Exception
        {
            public FlowExeption(string message) : base(message) { }
        }
        public class NullStringException : Exception
        {
            public NullStringException(string message) : base(message) { }
        }
        public class NolException : Exception
        {
            public NolException(string message) : base(message) { }
        }


    enum Names
    { Rose, Gladiolus, Allisium, Chamomile };


    class Program
    { 

        static void Main(string[] args)
        { 
                Herb Tulip = new Herb();
                Herb Alissum = new Herb();
                Bush Bluberry = new Bush();
                Flower Chamomile = new Flower();
                Rose Spike = new Rose();
                Gladiolus Flow = new Gladiolus();
                Printer Print = new Printer();

                Tulip.Name = "Тюльпан";
                Tulip.Quantity = 56789;
                Alissum.Number = 12345;
                Bluberry.Quantity = 102548;
                Bluberry.Age = 7;
                Alissum.Color = "Green";
                Tulip.Color = "Red";
                Chamomile.Quantity = 7;
                Chamomile.Sale = 18;
                Spike.Spike = 1;
                Flow.Quantity = 15;

                Console.WriteLine(Tulip.ToString());
                Alissum.HerbCut();
                Console.WriteLine(Bluberry.ToString());
                Console.WriteLine(Bluberry.GetHashCode());
                Console.WriteLine(Bluberry.Equals(Alissum));
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                Chamomile.CommonInf();
                Bluberry.CommonInf();
                Tulip.CommonInf();
                Spike.CommonInf();
                Flow.CommonInf();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                if (Bluberry is Bush)
                {
                    Console.WriteLine("Это растение относится к классу куст");
                }
                else Console.WriteLine("Объект тносится к другому классу");

                Alissum = Chamomile as Herb;

                if (Alissum == null)
                {
                    Console.WriteLine("Невозможно привести ромашку к типу аллисиума");
                }
                else
                    Console.WriteLine("Можно приводить ромашку к типу аллисиума");

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                List<object> array = new List<object>() { Tulip, Alissum, Bluberry, Chamomile, Spike, Flow };
                foreach (object ch in array)
                {
                    Print.IAmPrinting(ch);
                }

                Console.WriteLine("~~~~~~~~~~~~~~~~Лабораторная работа №6~~~~~~~~~~~~~~~~~~");

                Flowers fl = new Flowers();
                fl.Name = "Подсолнух";
                fl.Color = "Желтый";
                fl.Price = 8;
                fl.Info();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Cost(Names.Rose, 5);
                Cost(Names.Chamomile, 8);
                Cost(Names.Allisium, 10);
                Cost(Names.Rose, 5);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Butic Flow1 = new Butic("Роза белая", 8, "белый");
                Butic Flow2 = new Butic("Роза красная", 10, "красный");
                Butic Flow3 = new Butic("Тюльпан", 8, "желтый");
                Butic Flow4 = new Butic("Ромашка", 5, "белая");

                List<Butic> Flower = new List<Butic>() { Flow1, Flow2, Flow3 };
                Flower.Add(Flow4);


                Controller.Find(Flower);
                var sort = from u in Flower
                           orderby u.PriceOfFlower
                           descending
                           select u;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                foreach (Butic u in sort)
                    Console.WriteLine("Цветок стоит " + u.PriceOfFlower);

            try       //7 лабораторная работа 
            {
                Console.WriteLine("Проверка исключений");
                Butic Flow8 = new Butic("Роза белая", 15, "белый");
                int[] Array = new int[5] { 1, 2, 3, 4, 5 };
                  for (int i = 0; i < 7; i++)  //Error
                 {
                     Console.WriteLine(Array[i]);
                 }
               /* Butic Flow9 = new Butic("Роза белая", 251315, "белый");
                double a = 0;
                double k = (Flow8.PriceOfFlower) / a; //error
                {
                    throw new DivideByZeroException("Деление невозможно!");
                }
                 {
                      throw new FlowExeption("!!!!Число введено некорректно!!!!");
                  }*/
            }


            catch (DivideByZeroException message)
            {
                Console.WriteLine($"Error.Что-тоо пошло не так.{message.Message}");
            }
            catch (FlowExeption message)
            {
                Console.WriteLine($"Error.Смотрите ошибку {message.Message}");
            }
            catch (NullStringException message)
            {
                Console.WriteLine($"Error. {message.Message}");
            }
            catch (IndexOutOfRangeException message)
            {
                Console.WriteLine($"Error.Смотрите ошибку {message}");
            }

            catch (Exception)
            {
                Console.WriteLine($"Error.Что-то пошло не так");
            }
            finally 
            {
                Console.WriteLine("Проверка завершена!!!!!");
            }
          
        }


        abstract class CommonHerb
        {
            public string Name;
            public long Quantity;
            public abstract void CommonInf();
            public int Age;
        }
        //6 лабораторная работа
        struct Flowers
        {
            public string Name;
            public string Color;
            public double Price;
            public void Info()
            {
                Console.WriteLine($"Цветок, который вы выбрали, называется {Name}, его цена {Price}");
            }
        }
        class Butic
        {
            public string NameOfFlower;
            public string ColorOfFlower;
            public double PriceOfFlower;
            public Butic(string name, double sale, string color)
            {
                NameOfFlower = name;
                PriceOfFlower = sale;
                ColorOfFlower = color;
            }
            public void Inf()
            {
                Console.WriteLine($"Выбранный вами цветок называется {NameOfFlower}");
            }
            public double Service
            {
                get
                {
                    return PriceOfFlower;
                }
                set
                {
                    if ((value > 0 )&& (value <10000))
                    {
                        PriceOfFlower = value;
                    }
                    else
                    {
                        throw new FlowExeption("Значение введено некоректно");
                    }
                }
            }
            internal List<Butic> Flow = new List<Butic>();
            void Add(Butic c)
            {
                if (c == null)
                {
                    throw new NullStringException("Вы забыли указать название!!!!");

                }
                else
                {
                    Flow.Add(c);
                    Console.WriteLine($"В букет добавлен {c}");
                }
            }
            void Remove(Butic c)
            {
                Flow.Remove(c);
                Console.WriteLine($"Из букета убран {c}");
            }
            void Output(List<Butic> c)
            {
                foreach (object ch in c)
                {
                    Console.WriteLine(ch);
                }
            }
        }
        class Controller
        {
            List<object> Flow = new List<object>();

            public static void Find(List<Butic> Flowers)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (Flowers[i].Service == 10)
                    {
                        Console.WriteLine($"{Flowers[i].NameOfFlower} цветок стоит 10 рублей");
                    }
                    else
                    {
                        Console.WriteLine($"{Flowers[i].NameOfFlower} цветок стоит не 10 рублей");
                    }
                }

            }
        }


        public static void Cost(Names klass, int price)
        {
            switch (klass)
            {
                case Names.Rose:
                    Console.WriteLine("Одна роза стоит {0} рублей", price);
                    break;
                case Names.Gladiolus:
                    Console.WriteLine("Одна веточка гладиолуса стоит {0} рублей", price);
                    break;
                case Names.Allisium:
                    Console.WriteLine("Один цветок аллисиума стоит {0} рублей", price);
                    break;
                case Names.Chamomile:
                    Console.WriteLine("Букет ромашек стоит {0} рублей", price);
                    break;
            }
        }

        //Класс растений, наследуемый от абстрактного класса и интерфейся
        //6 лаба частичный класс
        partial class Herb : CommonHerb, IHerb
        {
            public string Color;
            public int Spike;
            public int Number;
            public int Sale;
            const int LimitNumber = 10000;

            public virtual void HerbCut()
            {
                if (Number < LimitNumber)
                {
                    Console.WriteLine("Это растение не может вырезаться для продажи!");
                }
                else Console.WriteLine("Это растение находится в профиците");
            }
            public override string ToString()
            {
                if (String.IsNullOrEmpty(Name))
                {
                    return "Название растения не определено";
                }
                return "Название растения - " + Name;
            }
            public override void CommonInf()
            {
                Console.WriteLine($"На складе имеется {Quantity} цветов с названием {Name}");
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
        }

        //Интерфейс
        interface IHerb
        {
            void HerbCut();
        }

        //Класс кустов,наследуемый от абстрактного класса
        class Bush : CommonHerb
        {
            public override string ToString()
            {
                if (Age < 2)
                {
                    return "Кусты достаточно молоды для обработки";
                }
                return "Корни кустов могут подвергаться обработке";
            }
            public override void CommonInf()
            {
                Console.WriteLine($"На складе имеется {Quantity} кустов ");
            }
        }
        class Flower : Herb, IHerb
        {

            public override string ToString()
            {
                return "Название растения - " + Name;
            }
            public override void CommonInf()
            {
                if (Quantity < 8)
                {
                    Console.WriteLine("Этот букет будет стоить 15 рублей");
                }
                else if ((Quantity >= 8) && (Quantity < 20))
                {
                    Console.WriteLine("Этот букет будет стоить 30 рублей");
                }

                else Console.WriteLine("Цену уточняйте у продовца");

            }
        }
        class Rose : Flower
        {
            public override void CommonInf()
            {
                if (Spike == 1)
                {
                    Console.WriteLine("Роза колючая!!! Осторожно!!!");
                }
                else Console.WriteLine("Шипы отсутствуют");
            }
            public override string ToString()
            {
                return $"Самим ничего с ветрины не брать!";
            }
        }
        class Gladiolus : Flower
        {
            public override string ToString()
            {
                return $"Цена цветка {Sale} копеек";
            }
            public override void CommonInf()
            {
                Console.WriteLine($"На складе имеется {Quantity} гладиолусов ");
            }
        }
        class Cactus : Flower
        {
            public override string ToString()
            {
                if (Spike == 1)
                {
                    return "Кактус колючий!!! Осторожно!!!";
                }
                return "Шипы отсутствуют";
            }

        }
        sealed class Bouquet : Flower
        {
            public override string ToString()
            {
                if (Spike == 1)
                {
                    return "Кактус колючий!!! Осторожно!!!";
                }
                return "Шипы отсутствуют";
            }

        }

        public class Printer
        {
            public void IAmPrinting(object obj)
            {
                Console.WriteLine(obj.GetType());
            }
        }

    }
}
