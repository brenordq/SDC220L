using System.Collections.Generic;

namespace UserIntCalculator
{
    // This class contains the calculator's math methods.
    class Calculator
    {
        // Add two numbers.
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtract the second number from the first.
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiply two numbers.
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divide the first number by the second.
        public double Divide(double a, double b)
        {
            return a / b;
        }

        // Add all integers in the list.
        public long Sum(List<int> numbers)
        {
            long total = 0;

            foreach (int number in numbers)
                total += number;

            return total;
        }

        // Calculate the average of the stored integers.
        public double Average(List<int> numbers)
        {
            return (double)Sum(numbers) / numbers.Count;
        }
    }
}
