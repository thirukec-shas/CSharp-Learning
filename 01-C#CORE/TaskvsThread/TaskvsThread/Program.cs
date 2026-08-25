using System;
using System.Collections.Generic;
using System.Text;

namespace TaskvsThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method execution is started");
            //Thread
            //Thread thread1 = new Thread(Method1);
            //thread1.Start();

            //Task
            Task<int> task1 = Task.Run(MethodwithResult);
            Console.WriteLine("Main Method execution is completed");
            int result = task1.Result;
            Console.WriteLine($"Task Result :{result}");

            Console.ReadLine();
        }

        static void Method1()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Method execution:{i}");
                Thread.Sleep(1000); // Simulate work with 1-second delay
            }
        }

        static int MethodwithResult()
        {
            int Sum = 0;

            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine($"MethodwithResult execution: {1}");
                Sum += i;
                Thread.Sleep(1000); // Simulate work with 1-second delay
            }

            return Sum;
        }

    }
}
