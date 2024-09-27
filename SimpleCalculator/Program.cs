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

            }
            Console.ReadKey();
        }
    }
}
