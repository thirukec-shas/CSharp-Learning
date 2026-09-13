using System;


 namespace PolymorphsimMethoOverloadOverrid
{

    class Program
    {
        public static void Main()
        {
            Calculator Calc = new Calculator();
            Console.WriteLine(Calc.Add(5, 10));
            Console.WriteLine(Calc.Add(5, 10, 20));

            Animal Ani = new Peacock();
            Ani.Sound();
      }
    }
}