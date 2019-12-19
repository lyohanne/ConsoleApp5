using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        //Print Hello World
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Print the sum, diff etc. of two numbers
            int num = Utils.GetNumber("Enter the first number: ");
            int num1 = Utils.GetNumber("Enter the second number: ");
            int sum = (num + num1);
            int diff = (num - num1);
            int multiply = (num * num1);
            int div = (num / num1);
            int remainder = (num % num1);
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(multiply);
            Console.WriteLine(div);
            Console.WriteLine(remainder);

            num = Utils.GetNumber("Enter a number: ");
            PrintTree(num); //calling this method here
            int answer = MultiplicationTable(num); //calling this method here
            string name = Utils.GetInput("Give me a name: ");
            Console.WriteLine(ReverseString(name));
        }
        //Print a multiplication table


        public static int MultiplicationTable(int num2)
        {

            int result;

            result = num2 * 1;
            Console.WriteLine(num2 + " times 1 is " + result);
            result = num2 * 2;
            Console.WriteLine(num2 + " times 2 is " + result);
            result = num2 * 3;
            Console.WriteLine(num2 + " times 3 is " + result);
            result = num2 * 4;
            Console.WriteLine(num2 + " times 4 is " + result);
            result = num2 * 5;
            Console.WriteLine(num2 + " times 5 is " + result);
            result = num2 * 6;
            Console.WriteLine(num2 + " times 6 is " + result);
            result = num2 * 7;
            Console.WriteLine(num2 + " times 7 is " + result);
            result = num2 * 8;
            Console.WriteLine(num2 + " times 8 is " + result);
            result = num2 * 9;
            Console.WriteLine(num2 + " times 9 is " + result);
            result = num2 * 10;
            Console.WriteLine(num2 + " times 10 is " + result);
            result = num2 * 11;
            Console.WriteLine(num2 + " times 11 is " + result);
            result = num2 * 12;
            Console.WriteLine(num2 + " times 12 is " + result);
            return result;
        }
        public static void PrintTree(int height)
        {
            //from one to height, that's the number of lines = height (how many lines)
            for (var h = 1; h < height - 1; h++)
            {
                //        *
                //       ***
                //      *****
                //     *******
                //first inner loop is spaces
                // how many spaces on line one? Three, so start at zero
                //w=0, go to (4-1)=3, 3-2=1

                for (var w = 0; w < (height - h); w++)
                {
                    Console.Write(" ");
                }

                //second loop is *
                for (var w = 0; w < (h * 2) - 1; w++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static String ReverseString(String name)
        {
            String rev = "";
            for (int i = name.Length - 1; i >= 0; i--) //start at last character and go backwards adding it to rev
            {
                rev += name[i];
            }
            return rev;
        }


        //Find the largest, smallest and avg number in an array of integers
        //Find the second largest and second smallest
        //Return the total of all values
        public static void FindStuff()
        {
            int[] number = { 5, 6, 4, 10, 45 };
            int secondLargest = number[number.Length - 2];
            Console.WriteLine(number.Max());
            Console.WriteLine(number.Min());
            Console.WriteLine(number.Average());
            Array.Sort(number);
            Console.WriteLine(" Second largest number is " + secondLargest);
            Console.WriteLine(" Second smallest number is " + number[1]);
            Console.WriteLine(number.Sum());

            int length = 6, width = 6;
            Console.Write("");

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                }
                Console.Write("\n ");
            }

        }
    }
}













