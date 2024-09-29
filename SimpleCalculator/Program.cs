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
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.Clear();
                InputMethods inputMethods = new InputMethods();

                Console.WriteLine("Simple calculator");
                Console.WriteLine("-----------------");

                string chosenOperator = InputMethods.ValidOperator("Enter operator (+, -, *, /): ");
                double firstNumber = InputMethods.ValidNumber("Enter the first number: ");
                double secondNumber = InputMethods.ValidNumber("Enter the second number: ");

                double result = 0;
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
                Console.WriteLine("Do you want to perform another calculation?");
                continueLoop = inputMethods.Continue("Enter 'yes' to continue or 'no' to exit the program.");
            }
            Console.Clear();
            Console.WriteLine("You have exited the program!");
        }
    }
}
