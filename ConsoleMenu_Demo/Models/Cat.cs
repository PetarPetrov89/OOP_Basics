using ConsoleMenu_Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMenu_Demo.Models
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get ; set; }
        

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
