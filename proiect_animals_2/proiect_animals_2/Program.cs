using proiect_animals_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


List<Animal> animals = new List<Animal>
        {
            new Cat("Cat", "meow"),
            new Dog("Dog", "bark"),
            new Cow("Cow", "moooo")
        };

// Iterate over the list and call the Speak method
foreach (Animal animal in animals)
{
    animal.makesSound();
}

Console.ReadLine();