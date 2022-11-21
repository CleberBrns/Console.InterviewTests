using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.InterviewTests.Exercises
{
    public static class Exercises_41_50
    {
        /// <summary>
        /// Write a C# program to check if a given string contains ‘w’ characters between 1 and 3 times.
        /// </summary>
        public static void Exercise41()
        {
            System.Console.WriteLine("Input a string (containing at least one 'w' char): ");
            string inputedText = System.Console.ReadLine();

            var count = inputedText.ToLower().Count(x => x == 'w');

            System.Console.WriteLine("Checking if the given string constains 'w' character between 1 and 3 times: ");

            //Console.WriteLine(count>=1 && count <= 3); 
            System.Console.WriteLine($"Does the character 'w' appears between 1 and 3 times in the given string: {count >= 1 && count <= 3}");
            System.Console.WriteLine($"The character appears {count} times in the inputed string.");

            System.Console.ReadLine();
        }

        /// <summary>
        /// Write a C# program to create a new string where the first 4 characters will be in lower case. 
        /// If the string is less than 4 characters then make the whole string in uppercase.
        /// </summary>
        public static void Exercise42() 
        {
            System.Console.WriteLine("Input a text: ");
            string txt = System.Console.ReadLine();

            if (txt.Length >= 4)
            {
                System.Console.WriteLine(txt.Substring(0, 4).ToLower() + txt.Substring(4, txt.Length - 4));
            }
            else
            {
                System.Console.WriteLine(txt.ToUpper());
            }

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".
        /// </summary>
        public static void Exercise43() 
        {
            System.Console.WriteLine("Input a text: ");
            string txt = System.Console.ReadLine();

            if (txt.Length >= 3 && txt.ToLower().Substring(0, 1) == "w" && txt.ToLower().Substring(1, 2) == "ww")
            {
                System.Console.WriteLine("The given text starts with 'w' and is followed by other two 'w'");
            }
            else
            {
                System.Console.WriteLine("The given text doesn't starts with 'w' nor is followed by two 'w'.");
            }

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
        /// </summary>
        public static void Exercise44()
        {
            System.Console.WriteLine("Input a text: ");
            string txt = System.Console.ReadLine();

            string newTxt = string.Empty;

            if (txt.Length > 1)
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!string.IsNullOrEmpty(txt[i].ToString()) && i % 2 != 0)
                    {
                        newTxt += txt[i];
                    }
                }

                System.Console.WriteLine($"Given string with only odd positions; {newTxt}");
            }
            else
            {
                System.Console.WriteLine("To run the program propertly, please, input a bigger text.");
            }

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to count a specified number in a given array of integers.
        /// </summary>
        public static void Exercise45()
        {
            System.Console.WriteLine("Input an integer: ");
            int x = int.Parse(System.Console.ReadLine());

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            System.Console.WriteLine($"The inputed number {x} appears {nums.Count(a => a == x)} times in the integer array.");

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
        /// </summary>
        public static void Exercise46()
        {
            System.Console.WriteLine("Input an integer: ");
            int x = int.Parse(System.Console.ReadLine());

            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            if (nums.Length > 1)
            {
                System.Console.WriteLine($"Values in the integer array: {string.Join(", ", nums)}");
                if (nums[0] == x)
                {
                    System.Console.WriteLine("The given integer is at the first position of the array.");
                }
                else if (nums[nums.Length -1] == x)
                {
                    System.Console.WriteLine("The given integer is at the last position of the array.");
                }
                else
                {
                    System.Console.WriteLine("The given integer isn't at the first nor last position of the array.");
                }
            }
            else
            {
                System.Console.WriteLine("The array doesn't have enough elements to check the given integer.");
            }

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to compute the sum of all the elements of an array of integers.
        /// </summary>
        public static void Exercise47()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

            System.Console.WriteLine($"Values in the integer array: {string.Join(", ", nums)}");

            int sum = 0;

            nums.ToList().ForEach(x => { sum += x; });

            System.Console.WriteLine($"The sum of the values in the array is: {sum}");

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to check if the first element and the last element are equal on an array of integers and if its length is 1 or more.
        /// </summary>
        public static void Exercise48()
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            System.Console.WriteLine($"Values in the integer array: {string.Join(", ", nums)}");

            if (nums[0] == nums[nums.Length -1] && nums.Length >= 1)
            {
                System.Console.WriteLine($"The first element in the array ({nums[0]}) " +
                    $"is equals to the last element ({nums[nums.Length - 1]}) in the array and its length is equals or longer than 1.");
            }

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
        /// </summary>
        public static void Exercise49()
        {
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            System.Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
            int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            System.Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

            if (nums1.Length >= 1 && nums2.Length >= 1)
            {
                System.Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
                System.Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
            }
            else
            {
                System.Console.WriteLine("Both arrays aren't long enough to be tested.");
            }            

            System.Console.ReadKey();
        }

        /// <summary>
        /// Write a C# program to rotate an array (length 3) of integers in the left direction.
        /// </summary>
        public static void Exercise50()
        {
            int[] nums1 = { 1, 2, 3 };

            System.Console.WriteLine($"Values in the integer array before the modification: {string.Join(", ", nums1)}");

            int[] newArray = new int[nums1.Length];

            int newArrayCount = 0;
            for (int i = (nums1.Length - 1); i >= 0; i--)
            {
                newArray[newArrayCount] = nums1[i];
                newArrayCount++;
            }

            System.Console.WriteLine($"Values in the integer array after the modification: {string.Join(", ", newArray)}");

            System.Console.ReadKey();
        }
    }
}
