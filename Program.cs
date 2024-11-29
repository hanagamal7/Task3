using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Channels;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem 1 


            /*Console.WriteLine("Enter a string to convert to integer:");
            string userInput = Console.ReadLine();

            try
            {
                int result1 = int.Parse(userInput);
                Console.WriteLine($"Using int.Parse: {result1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"int.Parse failed: {ex.Message}");
            }

            try
            {
                int result2 = Convert.ToInt32(userInput);
                Console.WriteLine($"Using Convert.ToInt32: {result2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Convert.ToInt32 failed: {ex.Message}");
            }
            */


            //What is the difference between int.Parse and Convert.ToInt32 when handling null inputs?

            //int.Parse throws a ArgumentNullException when the input is null.
            //Convert.ToInt32 returns 0 when the input is null.

            //problem 2
            //Console.WriteLine("Enter a number:");
            //string userInput = Console.ReadLine();

            //if (int.TryParse(userInput, out int number))
            //{
            //    Console.WriteLine($"Valid integer: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input.");
            //}


            //Why is TryParse recommended over Parse in user - facing applications ?

            //TryParse avoids exceptions by returning a boolean indicating success or failure, making it safer and more efficient for validating user input.



            //problem 3


            //object obj;

            //obj = 42;
            //Console.WriteLine($"HashCode for int: {obj.GetHashCode()}");

            //obj = "Hello";
            //Console.WriteLine($"HashCode for string: {obj.GetHashCode()}");

            //obj = 3.14;
            //Console.WriteLine($"HashCode for double: {obj.GetHashCode()}");



            //What is the real purpose of the GetHashCode() method ?


            //GetHashCode() generates a numeric value representing the hash code of an object.
            //It is used in hash - based collections like Dictionary and HashSet for efficient lookups.


            //problem 4

            //object obj1 = "Hello";
            //object obj2 = obj1;

            //Console.WriteLine($"Before change: obj1 = {obj1}, obj2 = {obj2}");

            //obj1 = "World";
            //Console.WriteLine($"After change: obj1 = {obj1}, obj2 = {obj2}");


            //What is the significance of reference equality in .NET ?

            //Reference equality checks if two references point to the same memory location,
            //    which is important when working with mutable objects or managing resources.


            //Problem 5

            //string str = "Hi Willy";
            //Console.WriteLine($"HashCode before modification: {str.GetHashCode()}");

            //str += " Welcome!";
            //Console.WriteLine($"HashCode after modification: {str.GetHashCode()}");

            //Why is a string immutable in C#?

            //Strings are immutable to ensure thread safety and optimize performance through interning and memory sharing.



            //Problem 6


            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine($"HashCode before modification: {sb.GetHashCode()}");

            //sb.Append(" Welcome!");
            //Console.WriteLine($"HashCode after modification: {sb.GetHashCode()}");



            //How does StringBuilder address the inefficiencies of string concatenation?

            //    StringBuilder avoids creating new string instances for every modification,
            //    reducing memory allocation and improving performance.


            //Why is StringBuilder faster for large-scale string modifications?
            //It maintains a dynamic buffer to manage string changes in-place without allocating new memory for each operation.



            //Problem 7

            //Console.WriteLine("Enter first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Using + operator: Sum is " + (num1 + num2));
            //Console.WriteLine("Using string.Format: {0} + {1} = {2}", num1, num2, num1 + num2);
            //Console.WriteLine($"Using string interpolation: {num1} + {num2} = {num1 + num2}");


            //Which string formatting method is most used and why?

            //String interpolation($) is the most used because it is concise,
            //    readable, and integrates directly with expressions.



            //Problem 8


            //StringBuilder sb = new StringBuilder("Hi Willy");

            //sb.Append(" Welcome!");
            //Console.WriteLine($"After Append: {sb}");

            //sb.Replace("Willy", "John");
            //Console.WriteLine($"After Replace: {sb}");

            //sb.Insert(0, "Hello, ");
            //Console.WriteLine($"After Insert: {sb}");

            //sb.Remove(0, 7);
            //Console.WriteLine($"After Remove: {sb}");



            //How is StringBuilder designed to handle frequent modifications compared to strings ?

            //StringBuilder uses a mutable buffer that dynamically adjusts to modifications, avoiding the creation of new instances for each operation.
            //    This improves performance in scenarios with frequent changes



        }
    }
}
