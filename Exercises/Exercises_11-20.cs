using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.InterviewTests.Exercises
{
    public static class Exercises_11_20
    {
        /// <summary>
        /// Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
        /// </summary>
        public static void Exercise11()
        {
            System.Console.Write("Input your age: ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write($"You look older than {age} :)");
            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), 
        /// and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
        /// </summary>
        public static void Exercise12()
        {
            System.Console.Write("Input a number: ");
            int number = int.Parse(System.Console.ReadLine());

            // Part A: "num num num num" using Write
            for (int i = 0; i < 2; i++)
            {
                System.Console.Write(number);
                System.Console.Write(" ");
            }
    
            System.Console.Write(number);
            System.Console.WriteLine();

            //// Part B: "numnumnumnum" using Write
            for (int i = 0; i < 2; i++)
            {
                System.Console.Write(number);
            }

            System.Console.WriteLine(number);
            System.Console.WriteLine();

            //// Part C: "num num num num" using {0}
            System.Console.WriteLine($"{number} {number} {number} {number}");

            //// Part D: "numnumnumnum" using {0}
            System.Console.WriteLine($"{number}{number}{number}{number}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
        /// </summary>
        public static void Exercise13()
        {
            System.Console.Write("Input a number: ");
            int number = int.Parse(System.Console.ReadLine());
          
            System.Console.WriteLine($"{number}{number}{number}");

            for (int i = 0; i < 2; i++)
            {
                System.Console.WriteLine($"{number} {number}");
            }

            System.Console.WriteLine($"{number}{number}{number}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
        /// </summary>
        public static void Exercise14()
        {
            //kelvin = celsius + 273
            //fahrenheit = celsius x 18 / 10 + 32

            System.Console.Write("Input the amount of Celsius: ");
            int celsius = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Kelvin = {celsius + 273}");
            System.Console.WriteLine($"Fahrenheint = {celsius * (18 / 10 + 32)}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program remove specified a character from a non-empty string using the index of a character.
        /// </summary>
        public static void Exercise15()
        {
            //Console.WriteLine(remove_char("w3resource", 1));
            //Console.WriteLine(remove_char("w3resource", 9));
            //Console.WriteLine(remove_char("w3resource", 0));

            string text = "w3resource";
            System.Console.WriteLine($"The original Text is: {text}");
            System.Console.WriteLine($"Result of the Text removed is; {RemoveChar(text, 1)}");
            System.Console.WriteLine($"Result of the Text removed is; {RemoveChar(text, 9)}");
            System.Console.WriteLine($"Result of the Text removed is; {RemoveChar(text, 0)}");
            System.Console.WriteLine($"Result of the Text removed is; {RemoveChar(text, 11)}");
            System.Console.WriteLine($"Result of the Text removed is; {RemoveChar(text, -1)}");


            System.Console.ReadLine();
        }

        static string RemoveChar(string str, int index)
        {
            if (index >= 0 && index <= str.Length)
            {
                return str.Remove(index, 1);
            }
            else if (index < 0)
            {
                return "Index can't be a negative number.";
            }
            else
            {
                return "Index was outside the bounds of the text.";
            }
        }

        /// <summary>
        /// Write a C# program to create a new string from a given string where the first and last characters will change their positions.
        /// </summary>
        public static void Exercise16()
        {
            System.Console.WriteLine(ChangeFirstLastPositions("w3resource"));
            System.Console.WriteLine(ChangeFirstLastPositions("Python"));
            System.Console.WriteLine(ChangeFirstLastPositions("x"));

            System.Console.ReadLine();
        }

        static string ChangeFirstLastPositions(string stringReposition)
        {
            return stringReposition.Length > 1 ? 
                stringReposition.Substring(stringReposition.Length - 1) + 
                stringReposition.Substring(1, stringReposition.Length - 2) + 
                stringReposition.Substring(0, 1) : stringReposition;
        }

        /// <summary>
        /// Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
        /// </summary>
        public static void Exercise17()
        {
            System.Console.Write("Input a string: ");
            string texto = System.Console.ReadLine();

            if(string.IsNullOrEmpty(texto) && texto.Length >= 1)
            {
                var firstLetter = texto.Substring(0, 1);
                System.Console.WriteLine($"{firstLetter}{texto}{firstLetter}");
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to check two given integers and return true if one is negative and one is positive.
        /// </summary>
        public static void Exercise18()
        {
            System.Console.Write("Input the first number: ");
            int a = int.Parse(System.Console.ReadLine());

            System.Console.Write("Input the second number: ");
            int b = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Check if one is negative and one is positive: ");

            System.Console.WriteLine($"The first number is {IsNegativeOrPositive(a)}, and the second number is {IsNegativeOrPositive(b)}.");

            System.Console.ReadLine();
        }

        static string IsNegativeOrPositive(int number)
        {
            return number >= 0 ? "positive" : "negative";           
        }

        /// <summary>
        /// Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
        /// </summary>
        public static void Exercise19()
        {
            System.Console.WriteLine(SumTriple(2, 2));
            System.Console.WriteLine(SumTriple(12, 10));
            System.Console.WriteLine(SumTriple(-5, 2));

            System.Console.ReadLine();
        }

        static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }

        /// <summary>
        /// Write a C# program to get the absolute value of the difference between two given numbers. 
        /// Return double the absolute value of the difference if the first number is greater than the second number.
        /// </summary>
        public static void Exercise20()
        {
            System.Console.WriteLine(AbsoluteResult(13, 40));
            System.Console.WriteLine(AbsoluteResult(50, 21));
            System.Console.WriteLine(AbsoluteResult(0, 23));

            System.Console.ReadLine();
        }

        static int AbsoluteResult(int a, int b)
        {
            return a > b ? (a - b) * 2 : b - a;
        }

    }
}
