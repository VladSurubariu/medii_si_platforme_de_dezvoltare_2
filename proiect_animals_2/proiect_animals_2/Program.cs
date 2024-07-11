using proiect_animals_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


List<Animal> animals = new List<Animal>
{
    new Cat(),
    new Dog(),
    new Cow()
};

foreach (Animal animal in animals)
{
    animal.makesSound();
}

Console.ReadLine();