using System;
using System.Threading.Tasks.Dataflow;

abstract class Bank
{
     public abstract void Moneywithdraw();
}

class ATM : Bank
{
    public override void Moneywithdraw()
    {
        Console.WriteLine("Money has been withdrawn");
    }
}

class Program
{
    public static void Main()
    {
        Bank bb = new ATM();
        bb.Moneywithdraw();
    }
   
}