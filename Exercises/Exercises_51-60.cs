using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.InterviewTests.Exercises
{
    public static class Exercises_51_60
    {
        /// <summary>
        /// Write a C# program to get the larger value between the first and last element of an array (length 3) of integers.
        /// </summary>
        public static void Exercise51()
        {
            int[] nums = { 77, 45, 1, 2, 3, 9, 5, 7, 15, 21, 4, 8, 32 };

            System.Console.WriteLine($"Values in the integer array: {string.Join(", ", nums)}");

            int biggestValue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (biggestValue > nums[i])
                {
                    biggestValue = nums[i];
                }
            }

            System.Console.WriteLine($"The largest value between the values in the array is {biggestValue}.");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
        /// </summary>
        public static void Exercise52()
        {
            int[] array1 = { 1, 2, 5 };
            System.Console.WriteLine($"Values from the first Array: {string.Join(", ", array1)}");

            int[] array2 = { 0, 3, 8 };
            System.Console.WriteLine($"Values form the second Array: {string.Join(", ", array2)}");

            int[] array3 = { -1, 0, 2 };
            System.Console.WriteLine($"Values form the third Array: {string.Join(", ", array3)}");

            int[] newArray = { array1[1], array2[1], array3[1] };
            System.Console.WriteLine($"Values combined from the three other arrays: {string.Join(", ", newArray)}");

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to check if an array contains an odd number.
        /// </summary>
        public static void Exercise53()
        {
            int[] nums = { 2, 4, 7, 8, 6, 9, 12, 15, 20, 21, 23, 38 };
            System.Console.WriteLine($"\nValues from the original array: {string.Join(", ", nums)}");

            List<int> oddValues = new List<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddValues.Add(nums[i]);
                }
            }

            System.Console.WriteLine($"\nOdd values from the given array: {string.Join(", ", oddValues)}");

            System.Console.WriteLine($"\n(Second Solution)Odd values from the given array: {string.Join(", ", oddValues.Where(x => x % 2 != 0))}");

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to get the century from a year.
        /// </summary>
        public static void Exercise54()
        {
            System.Console.WriteLine("Input a year: ");
            int year = int.Parse(System.Console.ReadLine());

            System.Console.Write($"The century from the given year {year} is {GetTheCenturyOfTheYear(year)}.");

            System.Console.ReadLine();
        }

        static int GetTheCenturyOfTheYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        /// <summary>
        /// Write a C# program to find the pair of adjacent elements that has the largest product of a given array which is equal to a given value.
        /// </summary>
        public static void Exercise55()
        {
            System.Console.WriteLine(ArrayAdjacentElementsProduct(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            System.Console.WriteLine(ArrayAdjacentElementsProduct(new int[] { 0, -1, -1, -2 }) == 2);
            System.Console.WriteLine(ArrayAdjacentElementsProduct(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            System.Console.WriteLine(ArrayAdjacentElementsProduct(new int[] { 1, 4, 3, 0 }) == 16);

            System.Console.ReadKey();
        }

        static int ArrayAdjacentElementsProduct(int[] input_array)
        {
            int array_index = 0;
            int product = input_array[array_index] * input_array[array_index + 1];

            array_index++;
            while (array_index + 1 < input_array.Length)
            {
                product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
                           (input_array[array_index] * input_array[array_index + 1]) :
                            product;
                array_index++;
            }

            return product;
        }

        /// <summary>
        /// Write a C# program to check if a given string is a palindrome or not.
        /// </summary>
        public static void Exercise56()
        {
            ShowPalindromeMessage("aaa");
            ShowPalindromeMessage("abc");
            ShowPalindromeMessage("madam");
            ShowPalindromeMessage("1234");

            System.Console.ReadKey();
        }

        static void ShowPalindromeMessage(string inputString)
        {
            System.Console.WriteLine($"Is '{inputString}' a palindrome? {CheckPalindrome(inputString)}");
        }

        static bool CheckPalindrome(string inputString)
        {
            char[] cArray = inputString.ToCharArray();
            Array.Reverse(cArray);

            return new string(cArray).Equals(inputString);
        }

        /// <summary>
        /// Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range.
        /// </summary>
        public static void Exercise57()
        {
            int[] array1 = { 1, 3, 5, 6, 9 };
            int[] array2 = { 0, 10 };
            int[] array3 = { 1, 4 };

            ShowConsecutiveArrayMessage(array1, "first");
            ShowConsecutiveArrayMessage(array2, "second");
            ShowConsecutiveArrayMessage(array3, "third");

            System.Console.ReadKey();
        }

        static void ShowConsecutiveArrayMessage(int[] array, string arrayPosition)
        {
            System.Console.WriteLine($"Values in the {arrayPosition} array {string.Join(", ", array)}");
            System.Console.WriteLine($"Values to complete the range of the {arrayPosition} array: {ConsecutiveArray(array)}");
        }

        static int ConsecutiveArray(int[] inputArray)
        {
            Array.Sort(inputArray);
            int ctr = 0;

            for (int i = 0; i < inputArray.Length -1; i++)
            {
                var teste = inputArray[i + 1] - inputArray[i] - 1;
                ctr += inputArray[i + 1] - inputArray[i] - 1;
            }

            return ctr;
        }

    }
}
