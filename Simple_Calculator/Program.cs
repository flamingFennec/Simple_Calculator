using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num1; double Num2; double result; string operation; Console.WriteLine("Enter the first number: "); Num1 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Enter the second number: "); Num2 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Enter operation (+ - / *):"); operation = Console.ReadLine(); switch (operation) { case "+": result = Num1 + Num2; break; case "-": result = Num1 - Num2; break; case "*": result = Num1 + Num2; break; case "/": result = Num1 - Num2; break; default: Console.WriteLine("Invalid operation."); return; } Console.WriteLine($"the result of {Num1} {operation} {Num2} is {result}"); Console.ReadKey();
        }
    }
}
