using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.InterviewTests.Exercises
{
    public static class Exercises_1_10
    {
        /// <summary>
        /// Write a C# Sharp program to print Hello and your name in a separate line.
        /// </summary>
        public static void Exercise1()
        {
            System.Console.WriteLine("Hello :)");
            System.Console.WriteLine("Cleber");
            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program to print the sum of two numbers.
        /// </summary>
        public static void Exercise2()
        {
            System.Console.WriteLine(27 + 52);
            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program to print the result of dividing two numbers.
        /// </summary>
        public static void Exercise3()
        {
            System.Console.WriteLine(28 / 4);
            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program to print the result of the specified operations.
        /// </summary>
        public static void Exercise4()
        {
            System.Console.WriteLine(-1 + 4 * 6);
            //-1 + 24 = 23
            System.Console.WriteLine((35 + 5) % 7);
            //40 % 7 = 5 (remainder of 40/7)
            System.Console.WriteLine(14 + -4 * 6 / 11);
            //14 - (24/11)= 14 - 2 = 12
            System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program to swap two numbers.

        /// </summary>
        public static void Exercise5()
        {
            /*The act of swapping two variables refers to mutually exchanging the values of the variables. Generally, 
                this is done with the data in memory.
                Using a temporary variable :
                The simplest method to swap two variables is to use a third temporary variable :

                define swap(x, y)
                    temp:= x
                    x:= y
                    y:= temp
            */

            int number1, number2, temp;

            System.Console.Write("\nInput the First Number: ");
            number1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("\nInput the Second Number: ");
            number2 = int.Parse(System.Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            System.Console.Write("\nAfter Swapping: ");
            System.Console.Write($"xFirst Number: {number1}");
            System.Console.Write($"\nSecond Number: {number2}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
        /// </summary>
        public static void Exercise6()
        {
            int num1, num2, num3;

            System.Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Output: {num1} x {num2} x {num3} = {(num1 * num2 * num3)}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of 
        /// two numbers which will be entered by the user.
        /// </summary>
        public static void Exercise7()
        {
            int number1, number2;

            System.Console.Write("Input the First Number: ");
            number1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Input the Second Number: ");
            number2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"{number1} + {number2} = {(number1 + number2)}");
            System.Console.WriteLine($"{number1} - {number2} = {(number1 - number2)}");
            System.Console.WriteLine($"{number1} x {number2} = {(number1 * number2)}");
            System.Console.WriteLine($"{number1} / {number2} = {(number1 / number2)}");
            System.Console.WriteLine($"{number1} mod {number2} = {(number1 % number2)}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program that takes a number as input and prints its multiplication table.
        /// </summary>
        public static void Exercise8()
        {
            System.Console.Write("Input a number to show its Multiplication Table: ");
            int value = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"The Multiplication Table for the Number {value} is: ");
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"{value} x {i + 1} = {value * (i + 1)}");
            }            

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program that takes four numbers as input to calculate and print the average.
        /// </summary>
        public static void Exercise9()
        {
            /*
             An average is the sum of a list of numbers divided by the number of numbers in the list. In mathematics and statistics, 
             this would be called the arithmetic mean. The term "arithmetic mean" is preferred in some contexts in mathematics and 
             statistics because it helps distinguish it from other means, such as the geometric mean and the harmonic mean.
             */

            double number1, number2, number3, number4;

            System.Console.Write("Input the First Number: ");
            number1 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Input the Second Number: ");
            number2 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Input the Third Number: ");
            number3 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Input the Fourth Number: ");
            number4 = double.Parse(System.Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            System.Console.WriteLine($"The Average of {number1}, {number2}, {number3}, {number4} is {result}");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# Sharp program that takes three numbers(x,y,z) as input and prints the output of (x+y).z and x.y + y.z.
        /// </summary>
        public static void Exercise10()
        {
            int number1, number2, number3;

            System.Console.Write("Input the first number: ");
            number1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Input the second number: ");
            number2 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Input the third number: ");
            number3 = int.Parse(System.Console.ReadLine());

            System.Console.Write($"The result of the specified numbers {number1}, {number2} and {number3}, " +
                $"(x+y)*z is {(number1 + number2) * number3} " +
                $"and x*y + y*z is {(number1 * number2) + (number2 * number3)}\n\n");

            System.Console.ReadLine();
        }        
    }
}
