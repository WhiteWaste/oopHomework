using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201321087___Football_modeling
{
    abstract class Person
    {
        private string? name;
        private int age;
        public string? Name { 
            get => name; 
            private set => name = value; 
        }
        public int Age {
            get => age;
            private set { age = value < 12 ? 18 : value; }
        }

        public Person()
        {
            Name = "Jon";
            Age = 18;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
