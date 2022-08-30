using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string name;
        public int age; 
        public float size;

        public Animal() { name = "Unknown"; age = 0; size = 0; }
        public Animal(string name, int age, float size)
        {
            this.name = name;
            this.age = age;
            this.size = size;
        }

        static public void Show(string name, int age, float size) =>  Console.WriteLine($"Наименование: {name}, возраст: {age} лет, размер: {size}.");

        static public void GetGrow(ref float animalSize, int foodSize)
        {
            animalSize = (float)(animalSize+(foodSize*0.3));
            Console.WriteLine($"Животное увеличилось на {(float)(foodSize * 0.3)}");
        }

        static public void GetEat(string nameAnimal, string nameFood)
        {
            Console.WriteLine($"{nameAnimal} съел {nameFood}");
        }
    }
}
