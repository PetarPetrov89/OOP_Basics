using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.Name = "Gosho";
            //Console.WriteLine(cat.Name);

            Car bmwCar = new Car()
            {
                Make = "BMW",
                Model = "320i",
                HP = 150,
                dateCreated = new DateTime(2000, 10, 2)

            };

            Car opelCar = new Car()
            {
                Make = "Opel",
                Model = "Astra",
                HP = 125,
                dateCreated = new DateTime(1994, 10, 2)
            };

            Car mercedesCar = new Car()
            {
                Make = "Mercedes",
                Model = "ML 320",
                HP = 200,
                dateCreated = new DateTime(2003, 10, 2)
            };

            //Сравнява посредством метода Race конските сили.
            string result = bmwCar.Race(mercedesCar);
            Console.WriteLine(result);


            List<Car> cars = new List<Car>() { bmwCar, mercedesCar, opelCar };

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.HP} {car.dateCreated}");
            }

            //Пример с животни.
            Cat cat = new Cat("Tom");
            Dog dog = new Dog("Rex");



            //cat.Name = "Tom";
           // dog.Name = "Rex";
            cat.Age = 12;
            dog.Age = 10;
            cat.Owner = "Gosho";
            dog.Owner = "Pesho";

            Console.WriteLine(cat.Meow());
            Console.WriteLine(dog.Bau());

            Cat secondCat = new Cat("Berta");
            Console.WriteLine(secondCat);

            // Статичен метод за теглене на данни от база
            Car carFromDB = Car.GetCarFromDB(20);
    }
    }
}
