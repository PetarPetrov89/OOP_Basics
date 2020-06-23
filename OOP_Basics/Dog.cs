using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Basics
{
    class Dog : Pet
    {
        public Dog(string name)
        {
            Name = name + "Dog";
        }
        public string Bau()
        {
            return $"Bau bau I am {Name}";
        }
    }
}
