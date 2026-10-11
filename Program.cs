/****************************************************************************
 * Name: Breanna Gonzalez
 * Date: October 11, 2026
 * Assignment: 1.4 Project: User Interactions and I/O
 * Description: A console-based C# application that welcomes the user, performs 
 * formatted integer addition and floating-point subtraction based on user input, 
 * and displays an informative closing message.
 */

using System;

namespace UserIntCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Print project week, title, and name
            Console.WriteLine("Project Week 1 | Basic Application | Breanna Gonzalez");

            // 2. Print a welcome message giving basic instructions
            Console.WriteLine("Welcome to the Prototype Calculator!");
            Console.WriteLine("Instructions: You will be prompted to enter two integers followed by two floating-point values.");
            Console.WriteLine("The program will calculate the sum of the integers and the difference of the floating-point values.");
            Console.WriteLine();

            // 3. Addition 
            Console.WriteLine("Integer Operations");
            
            Console.Write("Enter the first integer value: ");
            int int1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer value: ");
            int int2 = int.Parse(Console.ReadLine());

            int intSum = int1 + int2;

            // Formats the result as described in user interactions (e.g., clearly displaying operands and outcome)
            Console.WriteLine($"[Result] The sum of {int1} and {int2} is: {intSum}");
            Console.WriteLine();

            // 4. Subtraction with floating-point values
            Console.WriteLine("Floating-Point Operations");

            Console.Write("Enter the first floating-point value: ");
            double float1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second floating-point value: ");
            double float2 = double.Parse(Console.ReadLine());

            // Subtracts the first value from the second (first - second)
            double floatDifference = float1 - float2;

            // Formats result in a smooth way
            Console.WriteLine($"[Result] Subtracting {float2:F2} from {float1:F2} gives: {floatDifference:F2}");
            Console.WriteLine();

            // 5. Closing Message
            Console.WriteLine("Thank you for using my calculator! Come back soon.");

            // Pause before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
