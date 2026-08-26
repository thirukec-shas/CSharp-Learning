using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Restaurant is Open....");
        Task<string> foodtask = PrepareFoodAsync(); // Pizza Ordered

        Console.WriteLine("Waiter is serving another customer");

        string food = await foodtask;

        Console.WriteLine(food);

        Console.WriteLine("Restaurant work completed !!!");

        Console.ReadLine();
    }

    static async Task<string> PrepareFoodAsync()
    {
        Console.WriteLine("Pizza Prpartion Startd !..");
        await Task.Delay(3000);
        Console.WriteLine("Pizza Prepartion Completed !...");
        return "Pizza is ready !!!!";
    }
}
