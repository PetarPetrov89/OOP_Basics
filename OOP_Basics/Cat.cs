using OOP_Basics;

public class Cat : Pet
    {
    public Cat(string name)
    {
        Name = name + "Cat";
    }
    public string Meow()
    {
        return $"Meow meow I am {Name}";
    }


}

