using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputMethods
    {
        public void ContinuePrompt()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
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
