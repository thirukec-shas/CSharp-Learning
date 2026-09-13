using System;


class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine(Name + " is eating");

    }
    public static void Main(string[] args)
    {
        Animal A = new Animal();
        A.Name = "Cat";
        A.Eat();
     

    }

}
