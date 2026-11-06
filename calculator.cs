using System;
using System.Collections.Generic;

namespace UserIntCalculator
{
    class Calculator
    {
        // Check that at least two numbers were entered
        private void CheckNumbers(List<double> numbers)
        {
            if (numbers == null || numbers.Count < 2)
                throw new ArgumentException("At least two numbers are required.");
        }

        // Add all numbers in list
        public double Add(List<double> numbers)
        {
            CheckNumbers(numbers);

            double total = 0;

            foreach (double number in numbers)
                total += number;

            return total;
        }

        // Subtract each number from first number
        public double Subtract(List<double> numbers)
        {
            CheckNumbers(numbers);

            double total = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
                total -= numbers[i];

            return total;
        }

        // Multiply all numbers in list
        public double Multiply(List<double> numbers)
        {
            CheckNumbers(numbers);

            double total = 1;

            foreach (double number in numbers)
                total *= number;

            return total;
        }

        // Divide first number by each remaining number
        public double Divide(List<double> numbers)
        {
            CheckNumbers(numbers);

            double total = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                    throw new DivideByZeroException(
                        "Cannot divide by zero.");

                total /= numbers[i];
            }

            return total;
        }
    }
}
