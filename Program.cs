/*********************************************************
* Name: Breanna Gonzalez
* Date: 10.22.26
* Assignment: 3.2 Project Arrays and Lists
* Description: create an application that will perform some
* basic input, output, and array manipulation operations
*/
using System;
using System.Collections.Generic;

namespace UserIntCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the calculator object.
            Calculator calc = new Calculator();

            // Store one numeric value in memory.
            double memory = 0;
            bool hasMemory = false;

            // ARRAY: Reserve space for up to 10 integers.
            int[] numbers = new int[10];
            int numberCount = 0;

            Console.WriteLine("Project Week 2 | Arrays & Lists Update | Breanna Gonzalez");
            Console.WriteLine("Welcome to Bre's Calculator!");
            Console.WriteLine("Please make your selections based off of the menus.");

            string choice = "";

            // Repeat the main menu until the user quits.
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
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    double a = GetNumber("Enter first number: ");
                    double b = GetNumber("Enter second number: ");
                    Console.WriteLine("Result: " + calc.Add(a, b));
                }
                else if (choice == "2")
                {
                    double a = GetNumber("Enter first number: ");
                    double b = GetNumber("Enter second number: ");
                    Console.WriteLine("Result: " + calc.Subtract(a, b));
                }
                else if (choice == "3")
                {
                    double a = GetNumber("Enter first number: ");
                    double b = GetNumber("Enter second number: ");
                    Console.WriteLine("Result: " + calc.Multiply(a, b));
                }
                else if (choice == "4")
                {
                    double a = GetNumber("Enter first number: ");
                    double b = GetNumber("Enter second number: ");

                    // Check for division by zero.
                    if (b == 0)
                        Console.WriteLine("Cannot divide by zero.");
                    else
                        Console.WriteLine("Result: " + calc.Divide(a, b));
                }
                else if (choice == "5")
                {
                    string memoryChoice = "";

                    // Display the memory menu until the user returns.
                    while (memoryChoice != "6")
                    {
                        Console.WriteLine("\n Memory Menu ");
                        Console.WriteLine("1. Store a number");
                        Console.WriteLine("2. Retrieve number");
                        Console.WriteLine("3. Replace number");
                        Console.WriteLine("4. Clear number");
                        Console.WriteLine("5. Integer collection");
                        Console.WriteLine("6. Return to main menu");
                        Console.Write("Choose an option: ");
                        memoryChoice = Console.ReadLine();

                        if (memoryChoice == "1")
                        {
                            if (hasMemory)
                                Console.WriteLine("Memory already has a value. Use Replace.");
                            else
                            {
                                memory = GetNumber("Enter number to store: ");
                                hasMemory = true;
                                Console.WriteLine("Number stored.");
                            }
                        }
                        else if (memoryChoice == "2")
                        {
                            if (hasMemory)
                                Console.WriteLine("Stored number: " + memory);
                            else
                                Console.WriteLine("Memory is empty.");
                        }
                        else if (memoryChoice == "3")
                        {
                            memory = GetNumber("Enter new number: ");
                            hasMemory = true;
                            Console.WriteLine("Number replaced.");
                        }
                        else if (memoryChoice == "4")
                        {
                            memory = 0;
                            hasMemory = false;
                            Console.WriteLine("Memory cleared.");
                        }
                        else if (memoryChoice == "5")
                        {
                            string listChoice = "";

                            // Display the integer collection menu.
                            while (listChoice != "8")
                            {
                                Console.WriteLine("\n Integer Collection ");
                                Console.WriteLine("1. Display numbers");
                                Console.WriteLine("2. Count numbers");
                                Console.WriteLine("3. Remove a number");
                                Console.WriteLine("4. Add numbers");
                                Console.WriteLine("5. Sum");
                                Console.WriteLine("6. Average");
                                Console.WriteLine("7. First minus last");
                                Console.WriteLine("8. Return to memory menu");
                                Console.Write("Choose an option: ");
                                listChoice = Console.ReadLine();

                                if (listChoice == "1")
                                {
                                    // Display the values stored in the array.
                                    if (numberCount == 0)
                                        Console.WriteLine("No numbers stored.");
                                    else
                                    {
                                        for (int i = 0; i < numberCount; i++)
                                            Console.WriteLine((i + 1) + ". " + numbers[i]);
                                    }
                                }
                                else if (listChoice == "2")
                                {
                                    // Display how many integers are stored.
                                    Console.WriteLine("Count: " + numberCount);
                                }
                                else if (listChoice == "3")
                                {
                                    // Remove a value by its position.
                                    if (numberCount == 0)
                                        Console.WriteLine("No numbers to remove.");
                                    else
                                    {
                                        for (int i = 0; i < numberCount; i++)
                                            Console.WriteLine((i + 1) + ". " + numbers[i]);

                                        int position = GetInteger("Enter position to remove: ");

                                        if (position >= 1 && position <= numberCount)
                                        {
                                            // Shift remaining values to fill the empty position.
                                            for (int i = position - 1; i < numberCount - 1; i++)
                                                numbers[i] = numbers[i + 1];

                                            numberCount--;
                                            Console.WriteLine("Number removed.");
                                        }
                                        else
                                            Console.WriteLine("Invalid position.");
                                    }
                                }
                                else if (listChoice == "4")
                                {
                                    // Add integers if the array has available space.
                                    int available = 10 - numberCount;

                                    if (available == 0)
                                        Console.WriteLine("Memory is full.");
                                    else
                                    {
                                        int amount = GetInteger("How many numbers do you want to add? ");

                                        if (amount < 1 || amount > available)
                                            Console.WriteLine("Invalid amount. Available spaces: " + available);
                                        else
                                        {
                                            for (int i = 0; i < amount; i++)
                                            {
                                                numbers[numberCount] = GetInteger("Enter an integer: ");
                                                numberCount++;
                                            }

                                            Console.WriteLine("Numbers added.");
                                        }
                                    }
                                }
                                else if (listChoice == "5")
                                {
                                    // Convert stored array values to a List for the sum method.
                                    List<int> storedNumbers = GetStoredNumbers(numbers, numberCount);
                                    Console.WriteLine("Sum: " + calc.Sum(storedNumbers));
                                }
                                else if (listChoice == "6")
                                {
                                    // Calculate the average only when values exist.
                                    if (numberCount == 0)
                                        Console.WriteLine("No numbers to average.");
                                    else
                                    {
                                        List<int> storedNumbers = GetStoredNumbers(numbers, numberCount);
                                        Console.WriteLine("Average: " + calc.Average(storedNumbers));
                                    }
                                }
                                else if (listChoice == "7")
                                {
                                    // Subtract the last stored value from the first.
                                    if (numberCount < 2)
                                        Console.WriteLine("Enter at least two numbers first.");
                                    else
                                        Console.WriteLine("Difference: " +
                                            ((long)numbers[0] - numbers[numberCount - 1]));
                                }
                                else if (listChoice != "8")
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                        }
                        else if (memoryChoice != "6")
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                }
                else if (choice != "6")
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            // Display the closing message when the user quits.
            Console.WriteLine("\nThank you for using Bre's Calculator!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Copy the active array values into a List for calculations.
        static List<int> GetStoredNumbers(int[] numbers, int count)
        {
            List<int> storedNumbers = new List<int>();

            for (int i = 0; i < count; i++)
                storedNumbers.Add(numbers[i]);

            return storedNumbers;
        }

        // Read a valid numeric value from the user.
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

        // Read a valid whole number from the user.
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
