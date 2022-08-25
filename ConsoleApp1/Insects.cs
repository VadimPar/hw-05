using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Insects:Animal
    {
        public string name;
        public int age;
        public float size;
        public Insects() { name = "Unknown"; age = 0; size = 0; }
        public Insects(string name, int age, float size)
        {
            this.name = name;
            this.age = age;
            this.size = size;
        }

        new static public void Show(string name, int age, int size) => Console.WriteLine($"Наименование: {name}, возраст: {age} дней, размер: {size}.");
    }
}
