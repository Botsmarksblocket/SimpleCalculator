﻿using System;
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

        public static string ValidOperator(string prompt) //Checks for valid operator input
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();

                if (userInput.Length == 1 && "+-*/".Contains(userInput))
                {
                    return userInput;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid operator, please try again.");
                }
            }
        }

        public static double ValidNumber(string prompt) //Checks for valid number input
        {
            double number;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();

                if(double.TryParse(userInput, out number))
                {
                    return number;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid number, please try again.");
                }
            }
        }
    }
}
