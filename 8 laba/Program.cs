using System;
using System.Collections.Generic;
using System.IO;
using static _8_laba.Program;

namespace _8_laba
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {



                Console.WriteLine("Collection of int: ");
                CollectionType<int?> CollectionInt = new CollectionType<int?>();
                CollectionInt.Add(15);
                CollectionInt.Add(26);
                CollectionInt.Add(69);
                //CollectionInt.Add(null);
                CollectionInt.Add(4);
                CollectionInt.Add(89);
                CollectionInt.Add(10);
                CollectionInt.Remove(3);
                CollectionInt.Display();



                Console.WriteLine("Collection of flowers: ");
                CollectionType<Butic> ButicOfFlowers = new CollectionType<Butic>();
                Butic FFlower = new Butic("Rose");
                Butic SFlower = new Butic("White Rose");
                Butic TFlower = new Butic("Tulip");
                Butic FoFlower = new Butic("Chamomile");
                Butic FiFlower = new Butic("Alisium");
                Butic SiFlower = new Butic("Lily");
                ButicOfFlowers.Add(FFlower);
                ButicOfFlowers.Add(SFlower);
                ButicOfFlowers.Add(TFlower);
                ButicOfFlowers.Add(FoFlower);
                ButicOfFlowers.Add(FiFlower);
                ButicOfFlowers.Add(SiFlower);
                ButicOfFlowers.Remove(FiFlower);
                ButicOfFlowers.Display();


                string MyFile = @"C:\Users\Anastasia PC\Desktop\Универ\2 курс\ООП\Лабораторные\8 laba\File.txt";
                string content = $"Обобщенный тип CollectionType<T> {CollectionInt} и {ButicOfFlowers}";
                File.WriteAllText(MyFile, content);

            }
            catch (ThisException)
            {
                Console.WriteLine($"An exception found there.\n");
            }
            finally
            {
                Console.WriteLine("All are correct");
            }
        }

        public interface IPlant<T> where T : new()
        {
            void Add(T item);
            void Remove(T item);
            void Display();

        }

        public class ThisException : Exception
        {
            public ThisException(string message) : base(message)
            { }
        }

    }

    public class CollectionType<T> : IPlant<T> where T : new()
    {

        public List<T> Flow = new List<T>();
        public int item { get; set; }
        int Count = 0;

        public void Add(T item)  //Добавление элемента
        {
            if (item == null)
            {
                throw new ThisException("Our number is empty!!!!\n");
            }
            else
            {
                Flow.Add(item);
                Count++;
                Console.WriteLine("Element add to List! Congratulations!");
            }
        }

        public static bool operator true(CollectionType<T> myList)
        {
            return myList.Count == 0;
        }

        public static bool operator false(CollectionType<T> myList)
        {
            return myList.Count != 0;
        }
        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ThisException("Our number is empty!!!!\n");
            }

            else
            {
                Flow.Remove(item);
                Count--;
                Console.WriteLine("Element remove from List! Congratulations!");
            }

        }

        public void Display()
        {
            for (int i = 0; i < Flow.Count; i++)
                Console.WriteLine(Flow[i]);
        }
    }
}

