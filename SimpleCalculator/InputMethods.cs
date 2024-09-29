using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputMethods
    {
        public bool Continue(string prompt) //Asks the user if they want to continue or exit the program
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine().ToLower();

                if(userInput == "yes")
                {
                    return true;
                }
                else if (userInput == "no")
                {
                    return false;
                }
                Console.Clear();
                Console.WriteLine("Invalid input, please try again.");
            }
        }
        public string ValidOperator()
        {
            while (true)
            {
                Console.WriteLine("Enter operator (+, -, *, /) or type 'exit' to quit: ");
                string checkOperator = Console.ReadLine();

                if (checkOperator.Length != 1 || "+-*/".IndexOf(checkOperator) == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid operator, please try again.");
                }
                else
                {
                    return checkOperator;
                }
            }
        }
    }
}
