/****************************************************************************
 * Name: Breanna Gonzalez
 * Date: October 11, 2026
 * Assignment: 2.2 Project: User Interactions and I/O
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
            // Instantiate an object instance of the Calculator class
            Calculator calc = new Calculator();

            // Print project week, title, and name (Only shows once at startup)
            Console.WriteLine("Project Week 1 | Basic Application | Breanna Gonzalez");
            Console.WriteLine("Welcome to the Prototype Calculator!");
            Console.WriteLine("Please make your selections from the menu.");

            string choice;

            do
            {
                bool isValidChoice = false;

                // Inner loop forces the menu to repeat until a valid choice (1-5) is selected
                do
                {
                    Console.WriteLine("\nBre's Calculator Menu");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Quit");
                    Console.Write("Select an operation (1-5): ");
                    choice = Console.ReadLine();

                    if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                    {
                        isValidChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid please try again.");
                    }

                } while (!isValidChoice);

                Console.WriteLine();

                if (choice == "5")
                {
                    break;
                }

                // Execute operations by passing inputs to our calculator instance
                if (choice == "1")
                {
                    Console.WriteLine("Integer Operations");

                    Console.Write("Enter the first integer value: ");
                    int int1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter the second integer value: ");
                    int int2 = int.Parse(Console.ReadLine());

                    // Calling the Add method 
                    int intSum = calc.Add(int1, int2);

                    Console.WriteLine($"[Result] The sum of {int1} and {int2} is: {intSum}");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Floating-Point Operations");

                    Console.Write("Enter the first floating-point value: ");
                    double float1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second floating-point value: ");
                    double float2 = double.Parse(Console.ReadLine());

                    // Calling the Subtract method
                    double floatDifference = calc.Subtract(float1, float2);

                    Console.WriteLine($"[Result] Subtracting {float2:F2} from {float1:F2} gives: {floatDifference:F2}");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Multiplication Operations");

                    Console.Write("Enter the first value: ");
                    double mult1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second value: ");
                    double mult2 = double.Parse(Console.ReadLine());

                    // Calling the Multiply method
                    double product = calc.Multiply(mult1, mult2);

                    Console.WriteLine($"[Result] Multiplying {mult1:F2} by {mult2:F2} gives: {product:F2}");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Division Operations");

                    Console.Write("Enter the first value: ");
                    double div1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second value (divisor): ");
                    double div2 = double.Parse(Console.ReadLine());

                    if (div2 == 0)
                    {
                        Console.WriteLine("[Error] Cannot divide by zero.");
                    }
                    else
                    {
                        // Calling the Divide method
                        double quotient = calc.Divide(div1, div2);
                        Console.WriteLine($"[Result] Dividing {div1:F2} by {div2:F2} gives: {quotient:F2}");
                    }
                }


            } while (choice != "5");

            Console.WriteLine();
            Console.WriteLine("Thank you for trying my calculator.");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
