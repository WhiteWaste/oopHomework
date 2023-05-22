using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _2201321087___Football_modeling
{
    abstract class ManOfTheFoot : Person
    {
        private int number;
        private double height;

        // намам си и на представа какви са правилата зад номерирането на играчите
        public int Number
        {
            get { return number; }
            private set { number = value < 1 ? Random.Shared.Next(1, 12) : value; }
        }
        public double Height
        {
            get { return height; }
            private set { height = value < 1 ? 1.7 : value; }
        }

        public ManOfTheFoot() : base() 
        { 
            Number = 0;
            Height = 0;
        }

        public ManOfTheFoot(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
