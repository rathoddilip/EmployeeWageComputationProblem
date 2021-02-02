using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch!");
            int isPresent = 1;
            Random randomNumber = new Random();
            int empCheck = randomNumber.Next(0,2);
            Console.WriteLine(empCheck);
            if (empCheck == isPresent)
                Console.WriteLine("present");

              else
                Console.WriteLine("absent");
		Console.WriteLine("Added branch to UC2Test");
        }
    }
}
