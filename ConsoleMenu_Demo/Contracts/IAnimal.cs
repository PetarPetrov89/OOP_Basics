using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMenu_Demo.Contracts
{
    public interface IAnimal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Eat();
    }
}
