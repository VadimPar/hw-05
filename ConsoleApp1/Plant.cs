using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Plant
    {
        public string name;
        public int size;

        public Plant() { name = "Unknown"; size = 0; }
        public Plant(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
    }

    public sealed class Fresh:Plant
    {
        new public string name;
        new public int size;

        public Fresh() { name = "Unknown"; size = 0; }
        public Fresh(string name, int size) : base(name, size)
        {
        }
    }

    public sealed class Dried:Plant
    {
        new public string name;
        new public int size;

        public Dried() { name = "Unknown"; size = 0; }
        public Dried(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
    }
}
