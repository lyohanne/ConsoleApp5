using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Utils
    {
        public static int GetNumber(string prompt)
        {
            int number;
            string strNumber;
            do
            {
                strNumber = GetInput(prompt);               // Use the method below to get input from the user
                if (Int32.TryParse(strNumber, out number))  // if it failed to parse TryParse will return false and keep looping
                {                                           //      TryParse succeeded in converting the text entered by the user 
                    break;                                  //      we can break out of the loop now that we have a valid number
                }
                Console.WriteLine("Not an integer");
            } while (true);

            return number;
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);                         // just ask the user to respond to the prompt
            string str = Console.ReadLine();               // get the users response
            return str;
        }
    }
}
