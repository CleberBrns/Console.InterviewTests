using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Console.InterviewTests.Exercises
{
    public static class Exercises_21_30
    {
        /// <summary>
        /// Write a C# program to check the sum of the two given integers and return true if one of the integers is 20 or if their sum is 20.
        /// </summary>
        public static void Exercise21()
        {
            System.Console.WriteLine("Check the sum of the two given integers and return true if one of the integers is 20 or if their sum is 20");

            int number1, number2;

            System.Console.WriteLine("Input the first number: ");
            number1 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input the second number: ");
            number2 = int.Parse(System.Console.ReadLine());

            if(!CheckIfValueIsTwenty(number1, "first number") && !CheckIfValueIsTwenty(number2, "second number"))
            {
                CheckIfValueIsTwenty(number1 + number2, "sum of the first and the second numbers");
            }

            System.Console.ReadLine();
        }

        static bool CheckIfValueIsTwenty(int value, string fieldValue)
        {
            if (value == 20)
            {
                System.Console.WriteLine($"The {fieldValue} is 20!");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Write a C# program to check if a given integer is within 20 of 100 or 200.
        /// </summary>
        public static void Exercise22()
        {
            System.Console.WriteLine("\n Check if a given integer is within 20 of 100 or 200.");

            System.Console.WriteLine("\n Input an integer: ");
            int value = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Is the inputed value within 20? {AbsoluteResult(value)}");

            System.Console.ReadLine();
        }

        static bool AbsoluteResult(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }

        /// <summary>
        /// Write a C# program to convert a given string into lowercase.
        /// </summary>
        public static void Exercise23()
        {
            System.Console.WriteLine("\n Convert a given string into lowercase.");

            System.Console.WriteLine("\n Input a text: ");
            string txt = System.Console.ReadLine();

            System.Console.Write($"\n This is your inputed text in lowercase; {txt?.ToLower()}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to find the longest word in a string.
        /// </summary>
        public static void Exercise24()
        {          
            string text = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);

            string logestWord = string.Empty;
            int ctrl = 0;

            foreach (var item in words)
            {
                if (item.Length > ctrl)
                {
                    logestWord = item;
                    ctrl = item.Length;
                }
            }

            System.Console.WriteLine($"The longest word in the text is; {logestWord}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to print the odd numbers from a inputed integer. Prints one number per line.
        /// </summary>
        public static void Exercise25()
        {            
            System.Console.WriteLine("\n Print the odd numbers from a inputed integer. Prints one number per line.");

            System.Console.WriteLine("\n Input an integer number: ");
            int value = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"\n Odd numbers from 1 to {value}; ");

            for(int i = 1; i <= value; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to compute the sum of the first 500 prime numbers.
        /// </summary>
        public static void Exercise26()
        {
            System.Console.WriteLine("\nSum of the first 500 prime numbers: ");

            long sum = 0;
            int ctrl = 0;
            int number = 0;

            while (ctrl <= 500)
            {
                if (IsTheNumberPrime(number))
                {
                    sum += number;
                    ctrl++;

                    System.Console.WriteLine($"The number {number} is prime.");
                }
                number++;
            }

            System.Console.WriteLine(sum.ToString());

            System.Console.ReadLine();
        }

        static bool IsTheNumberPrime(int number)
        {
            //int x = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= (int)Math.Sqrt(number); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        /// <summary>
        /// Write a C# program and compute the sum of the digits of an integer.
        /// </summary>
        public static void Exercise27()
        {
            System.Console.WriteLine("Input an integer number: ");
            int number = int.Parse(System.Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            System.Console.WriteLine($"The sum of the digits of the inputed integer is {sum}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to reverse the words of a sentence.
        /// </summary>
        public static void Exercise28()
        {
            string wholeText = "Display the pattern like a pyramid using the alphabet.";
            System.Console.WriteLine($"Original Text: {wholeText}");

            string result = string.Empty;
            string[] words = wholeText.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += $"{words[i]} ";
            }

            System.Console.WriteLine($"\nRevesed text: {result}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to find the size of a specified file in bytes.
        /// </summary>
        public static void Exercise29()
        {
            System.IO.FileInfo f = new System.IO.FileInfo("/home/students/abc.txt");

            System.Console.WriteLine($"The size of the file is: {f.Length.ToString()}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to convert a hexadecimal number to a decimal number.
        /// </summary>
        public static void Exercise30()
        {
            //string hexval = "4B0";
            //Console.WriteLine("Hexadecimal number: " + hexval);
            //int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine("Convert to-");
            //Console.WriteLine("Decimal number: " + decValue);

            string hexaval = "4B0";
            System.Console.WriteLine($"Hexadecimal number: {hexaval}");

            int decimalValue = int.Parse(hexaval, System.Globalization.NumberStyles.HexNumber);

            System.Console.WriteLine("Convert to - ");

            System.Console.WriteLine($"Decimal number: {decimalValue}");

            System.Console.ReadLine();
        }
    }
}
