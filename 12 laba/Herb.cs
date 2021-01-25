using System;
namespace exersices_5
{
    public partial class Herb
    {
        public string Color;
        public int Spike;
        public int Number;
        public int Sale;
        const int LimitNumber = 10000;
        public virtual string HerbCutting()
        {
            if (Number < LimitNumber)
            {
                return "Впринципе, вы можете вырубать эти деревья, но подумайте об экологии";
            }
            else return "Необходимо большее количество деревьев";
        }
        public void ShowString()
        {
            Console.WriteLine("All operations are completely");
        }
    }
}