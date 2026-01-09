using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public static class ErrorCheck
    {
        //This method loops giving the user the option to write a string and checks to see if it's empty or not.
        //If it's empty the user is prompted to try again. Otherwise it returns the user input.
        public static string StringCheck(string question)
        {
            while (true)
            {
                Console.Write(question + "\n> ");
                string text = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("You didn't enter anyting try again");
                }
                else
                {
                    return text;
                }
            }

        }

        //This method checks the user input with a Int32.TryParse to check if it's a number or not.
        public static int IntCheck(string question)
        {

            while (true)
            {
                Console.Write(question + "\n> ");
                if (Int32.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input!\nOnly numbers are allowed!");
                }
            }
        }

        //Similarly to the int checker this uses a DataTime.TryParse to check that the user input is of the right format.
        public static DateTime DateTimeCheck(string question)
        {
            while (true)
            {
                Console.Write(question + "\n> ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input!\nNeeds to be the YYYY-MM-DD format including the '-'");
                }
            }
        }
    }
}
