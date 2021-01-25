using System;
namespace _8_laba
{
    public class Butic
    {
        public string NameOfFlower { get; set; }

        public Butic()
        {
            NameOfFlower = "Default name";
        }
        public Butic(string nm)
        {
            NameOfFlower = nm;
        }
    }
}