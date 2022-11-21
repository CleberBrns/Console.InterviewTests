using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.InterviewTests.Exercises
{
    public static class Exercises_31_40
    {
        /// <summary>
        /// Write a C# program to multiply corresponding elements of two arrays of integers.
        /// </summary>
        public static void Exercise31()
        {
            int[] firstArray = { 1, 3, -5, 4 };
            int[] secondArray = { 1, 4, -5, -2 };

            System.Console.WriteLine($"First Array; {string.Join(", ", firstArray)}");
            System.Console.WriteLine($"Second Array; {string.Join(", ", secondArray)}");

            System.Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < firstArray.Length; i++)
            {
                System.Console.Write($"{firstArray[i] * secondArray[i]} ");
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to create a new string of four copies, taking the last four characters from a given string. 
        /// If the length of the given string is less than 4 return the original one.
        /// </summary>
        public static void Exercise32()
        {
            System.Console.WriteLine("Input a string text: ");
            string inputedText = System.Console.ReadLine();

            if (inputedText.Length > 4)
            {
                string modifiedText = inputedText.Substring(inputedText.Length - 4);
                System.Console.WriteLine($"Modified inputed string: {modifiedText}{modifiedText}{modifiedText}{modifiedText}");                
            }
            else if (inputedText.Length < 4)
            {
                System.Console.WriteLine($"Original inputed string: {inputedText}");
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
        /// </summary>
        public static void Exercise33()
        {
            System.Console.WriteLine("\nInput an integer number: ");
            int number = int.Parse(System.Console.ReadLine());

            if (number > 0)
            {
                string multipleOf = CheckIfNumberIsMultipleOfThreeOrSeven(number);
                if (!string.IsNullOrEmpty(multipleOf))
                {
                    System.Console.WriteLine($"The inputed number ({number}) is a multiple of {multipleOf}");
                }
                else
                {
                    System.Console.WriteLine($"The inputed number ({number}) isn't a multiple of 3 nor 7.");
                }
            }

            System.Console.ReadLine();
        }

        static string CheckIfNumberIsMultipleOfThreeOrSeven(int number)
        {
            List<int> multipleNumbers = new List<int> { 3, 7 };

            foreach (var item in multipleNumbers)
            {
                if (number % item == 0)
                {
                    return item.ToString();
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Write a C# program to check if a string starts with a specified word.
        /// </summary>
        public static void Exercise34()
        {
            System.Console.WriteLine("Input a text: ");
            string inputedText = System.Console.ReadLine();

            if (!string.IsNullOrEmpty(inputedText?.Trim()))
            {
                if (inputedText.Contains("Hello") && inputedText.StartsWith("Hello"))
                {
                    System.Console.WriteLine("The inputed text starts with the word 'Hello'.");
                }
                else
                {
                    System.Console.WriteLine("The inputed text doesn't start with the word 'Hello'.");
                }
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
        /// </summary>
        public static void Exercise35()
        {
            System.Console.WriteLine("Input the first number: ");
            int firstNumber = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input the second number: ");
            int secondNumber = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Is the first number less than 100: {firstNumber < 100}");
            System.Console.WriteLine($"Is the second number higher than 200: {secondNumber > 200}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
        /// </summary>
        public static void Exercise36()
        {
            System.Console.WriteLine("Input the first number: ");
            int fstNum = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input the second number: ");
            int scdNum = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"{ShowMessageBetweenNumbers("first")} {IsTheNumberBetweenTheGivenTest(fstNum)}");
            System.Console.WriteLine($"{ShowMessageBetweenNumbers("second")} {IsTheNumberBetweenTheGivenTest(scdNum)}");

            System.Console.ReadLine();
        }

        static object ShowMessageBetweenNumbers(string numberPosition)
        {
            return $"Is the {numberPosition} number between >= -10 and <= 10:";
        }

        static bool IsTheNumberBetweenTheGivenTest(int number)
        {
            return number >= -10 && number <= 10;
        }

        /// <summary>
        /// Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
        /// </summary>
        public static void Exercise37()
        {
            string stringText = "PHP Tutorial";
            string result = stringText.Substring(1, 2).Equals("HP") ? stringText.Remove(1, 2) : stringText;
            System.Console.WriteLine($"Result: {result}");

            System.Console.WriteLine();
        }

        /// <summary>
        /// Write a C# program to get a new string of two characters from a given string. 
        /// The first and second character of the given string must be "P" and "H", so PHP will be "PH".
        /// </summary>
        public static void Exercise38() 
        {
            string strText = "PHP Tutorial";
            string result = string.Empty;

            if (strText.Length >= 1 && strText[0] == 'P')
            {
                result = strText[0].ToString();
            }

            if (strText.Length >= 2 && strText[1] == 'H')
            {
                result += strText[1];
            }

            System.Console.WriteLine($"Original text: {strText}");
            System.Console.WriteLine($"Result: {result}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to find the largest and lowest values from three integer values.
        /// </summary>
        public static void Exercise39() 
        {
            System.Console.WriteLine("Input the first integer: ");
            int x = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input the second integer: ");
            int y = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input the thrid integer: ");
            int z = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Inputed integers: {x}, {y}, {z}.");

            System.Console.WriteLine($"The largest integer of the inputed values is: {Math.Max(x, Math.Max(y, z))}");
            System.Console.WriteLine($"The lowest integer of the inputed values is: {Math.Min(x, Math.Min(y, z))}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
        /// </summary>
        public static void Exercise40()
        {
            System.Console.WriteLine("Input the first integer: ");
            int x = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input the second integer: ");
            int y = int.Parse(System.Console.ReadLine());

            int n = 20;

            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);

            if (val1 == val2)
            {
                System.Console.WriteLine("Since both numbers are equal, then the result will be zero.");
            }
            else
            {
                var result = val1 < val2 ? x : y;
                System.Console.WriteLine($"The nearest inputed value of 20 is {result}");
            }

            System.Console.ReadLine();
        }
    }
}
