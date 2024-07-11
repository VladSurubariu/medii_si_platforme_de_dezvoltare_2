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

        protected void setName<T>() where T : Animal
        {
            name = typeof(T).Name;
        }

        protected void setSound(string sound)
        {
            this.sound = sound;
        }

        public void makesSound()
        {
            Console.WriteLine($"{name} makes the sound *{sound}*");
        }
    }
}
