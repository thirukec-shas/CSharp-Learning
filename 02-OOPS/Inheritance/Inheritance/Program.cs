using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Aimal is Eating");
    }
}

class Dog : Animal
{
   public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class Program
{
    static void Main()
    {
        Dog Dg = new Dog();
        Dg.Eat();
        Dg.Bark();

    }
}