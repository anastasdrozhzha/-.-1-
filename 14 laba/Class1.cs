using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersices_5
{
    [Serializable]
    public abstract class CommonHerb
    {
        public string Name;
        public long Quantity;
        public abstract void CommonInf();
        public int Age;
    }
    interface IHerb
    {
        void HerbCut();
    }

    [Serializable]
    public class Herb : CommonHerb, IHerb
    {
        public static Random rand = new Random();
        public string Color = "blue";
        public int Spike;
        public int Number = rand.Next();
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
    }
}
