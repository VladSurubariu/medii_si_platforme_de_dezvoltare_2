using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_animals_2
{
    public abstract class Animal
    {
        protected string name;
        protected string sound;

        protected Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void makesSound()
        {
            Console.WriteLine($"{name} makes the sound *{sound}*");
        }
    }
}
