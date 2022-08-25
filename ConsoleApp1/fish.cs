using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public sealed class Fish:Animal
    {
        public string name;
        public int age;
        public float size;
        public Fish() { name = "Unknown"; age = 0; size = 0; }
        public Fish(string name, int age, float size)
        {
            this.name = name;
            this.age = age;
            this.size = size;
        }
    }
}
