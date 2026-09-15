using System;
using System.Reflection.Metadata.Ecma335;

interface Ilogger
{
    void log(string messge);

}

class Filelogger : Ilogger
{
    public void log(string message)
    {
        Console.WriteLine("Message is : " + message);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Ilogger ilog = new Filelogger();
        ilog.log("Application Started");
    }
}