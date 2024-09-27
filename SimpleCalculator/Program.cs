using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                InputMethods inputMethods = new InputMethods();

                Console.WriteLine("Simple calculator");
                Console.WriteLine("-----------------");

                string userInput = inputMethods.ValidOperator();

                if (userInput.ToLower() == "exit")//Breaks the while-loop which allows user to exit the program
                    break;

                Console.WriteLine("\nEnter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (userInput)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }
                Console.WriteLine($"Result: {result}");
                inputMethods.ContinuePrompt();
                Console.Clear();
            }
            Console.WriteLine("You have exited the program!");
        }
    }
}
