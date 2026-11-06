
/*********************************************************
* Name: Breanna Gonzalez
* Date: 11.04.26
* Assignment: 5.2 Project Exception Handling
* Description: Finalization of the overall project
*********************************************************/

using System;
using System.Collections.Generic;

namespace UserIntCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create calculator object
            Calculator calc = new Calculator();

            // Create a list to store up to 10 numbers
            List<double> memory = new List<double>();

            Console.WriteLine("Project Week 5 | Final Update | Breanna Gonzalez");
            Console.WriteLine("Welcome to Bre's Calculator!");
            Console.WriteLine("Please make your selections based off of the menus.");

            string choice = "";

            // Repeat the main menu until user quits
            while (choice != "6")
            {
                Console.WriteLine("\n Calculator Menu ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Memory");
                Console.WriteLine("6. Quit");
                Console.Write("Choose an option: ");
                choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    List<double> numbers = GetNumbers();
                    Console.WriteLine("Result: {0:F2}", calc.Add(numbers));
                }
                else if (choice == "2")
                {
                    List<double> numbers = GetNumbers();
                    Console.WriteLine("Result: {0:F2}", calc.Subtract(numbers));
                }
                else if (choice == "3")
                {
                    List<double> numbers = GetNumbers();
                    Console.WriteLine("Result: {0:F2}", calc.Multiply(numbers));
                }
                else if (choice == "4")
                {
                    bool tryAgain = true;

                    while (tryAgain)
                    {
                        try
                        {
                            List<double> numbers = GetNumbers();

                            double result = calc.Divide(numbers);

                            Console.WriteLine("Result: {0:F2}", result);
                            tryAgain = false;
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Exception Information: " + ex.Message);
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }

                        if (tryAgain)
                        {
                            Console.Write("Would you like to try again? (Y/N): ");

                            string answer = Console.ReadLine() ?? "";

                            if (answer.ToUpper() != "Y")
                                tryAgain = false;
                        }
                    }
                }
                else if (choice == "5")
                {
                    string memoryChoice = "";

                    // Display the memory menu until user returns
                    while (memoryChoice != "6")
                    {
                        Console.WriteLine("\n Memory Menu ");
                        Console.WriteLine("1. Store a number");
                        Console.WriteLine("2. Retrieve number");
                        Console.WriteLine("3. Replace number");
                        Console.WriteLine("4. Clear number");
                        Console.WriteLine("5. Display all numbers");
                        Console.WriteLine("6. Return to main menu");
                        Console.Write("Choose an option: ");
                        memoryChoice = Console.ReadLine() ?? "";

                        if (memoryChoice == "1")
                        {
                            if (memory.Count >= 10)
                                Console.WriteLine("Memory is full. Maximum is 10.");
                            else
                            {
                                double number = GetNumber("Enter number to store: ");
                                memory.Add(number);
                                Console.WriteLine("Number stored.");
                            }
                        }
                        else if (memoryChoice == "2")
                        {
                            if (memory.Count == 0)
                                Console.WriteLine("Memory is empty.");
                            else
                            {
                                int position = GetInteger("Enter memory position: ");

                                if (position >= 1 && position <= memory.Count)
                                    Console.WriteLine("Stored number: {0:F2}",
                                        memory[position - 1]);
                                else
                                    Console.WriteLine("Invalid position.");
                            }
                        }
                        else if (memoryChoice == "3")
                        {
                            if (memory.Count == 0)
                                Console.WriteLine("Memory is empty.");
                            else
                            {
                                DisplayMemory(memory);

                                int position = GetInteger("Enter number position to replace: ");

                                if (position >= 1 && position <= memory.Count)
                                {
                                    memory[position - 1] =
                                        GetNumber("Enter new number: ");

                                    Console.WriteLine("Number replaced.");
                                }
                                else
                                    Console.WriteLine("Invalid position.");
                            }
                        }
                        else if (memoryChoice == "4")
                        {
                            if (memory.Count == 0)
                                Console.WriteLine("Memory is empty.");
                            else
                            {
                                DisplayMemory(memory);

                                int position = GetInteger("Enter number position to clear: ");

                                if (position >= 1 && position <= memory.Count)
                                {
                                    memory.RemoveAt(position - 1);
                                    Console.WriteLine("Number cleared.");
                                }
                                else
                                    Console.WriteLine("Invalid position.");
                            }
                        }
                        else if (memoryChoice == "5")
                        {
                            DisplayMemory(memory);
                        }
                        else if (memoryChoice != "6")
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                }
                else if (choice != "6")
                {
                    Console.WriteLine("Invalid. Please try again.");
                }
            }

            // Display closing message when user quits
            Console.WriteLine("\nThank you for using Bre's Calculator!");
        }

        // Get multiple numbers entered by user
        static List<double> GetNumbers()
        {
            List<double> numbers = new List<double>();

            while (true)
            {
                Console.WriteLine("Enter at least two numbers separated by spaces:");
                string input = Console.ReadLine() ?? "";

                string[] values = input.Split(
                    new char[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries);

                bool valid = values.Length >= 2;

                foreach (string value in values)
                {
                    double number;

                    if (double.TryParse(value, out number) &&
                        !double.IsNaN(number) &&
                        !double.IsInfinity(number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                    return numbers;

                Console.WriteLine("Please enter at least two valid numbers.");
                numbers.Clear();
            }
        }

        // Display all numbers stored in memory
        static void DisplayMemory(List<double> memory)
        {
            if (memory.Count == 0)
                Console.WriteLine("No numbers were stored.");
            else
            {
                for (int i = 0; i < memory.Count; i++)
                    Console.WriteLine((i + 1) + ". " + memory[i].ToString("F2"));
            }
        }

        // Read a valid number value from user
        static double GetNumber(string message)
        {
            double number;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out number) &&
                    !double.IsNaN(number) && !double.IsInfinity(number))
                    return number;

                Console.WriteLine("Please enter a valid number.");
            }
        }

        // Read a valid whole number from user
        static int GetInteger(string message)
        {
            int number;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out number))
                    return number;

                Console.WriteLine("Please enter a whole number.");
            }
        }
    }
}
