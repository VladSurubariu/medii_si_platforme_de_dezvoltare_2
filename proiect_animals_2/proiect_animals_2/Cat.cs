﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_animals_2
{
    public class Cat : Animal
    {
        public Cat()
        {
            setName<Cat>();
            setSound("meow");
        }
    }
}
