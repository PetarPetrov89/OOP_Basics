using ConsoleMenu_Demo.Contracts;
using ConsoleMenu_Demo.Models;
using System;

namespace ConsoleMenu_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Cat();
            IAnimal animal2 = new Dog();
        }
    }
}
