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
                bool validOperation = true;

                switch (chosenOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You can't divide by 0, please try again.\n");
                            validOperation = false;
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                if (validOperation)
                {
                    Console.Clear();
                    Console.WriteLine($"Result: {firstNumber} {chosenOperator} {secondNumber} = {result}.");
                }

                Console.WriteLine("Do you want to perform another calculation?");
                continueLoop = inputMethods.Continue("Enter 'yes' to continue or 'no' to exit the program.");
            }
            Console.Clear();
            Console.WriteLine("You have exited the program!");
        }
    }
}
