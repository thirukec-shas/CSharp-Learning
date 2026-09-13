using System;

class Employee
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    class Program
    {
        public static void Main()
        {
            Employee Emp = new Employee();
            Emp.Name = "ThiruRajesh";
            Console.WriteLine(Emp.Name);
        }
    }



}
