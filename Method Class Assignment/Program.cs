using System;

namespace MathDemo
{
    // Class that holds a method to perform and display values
    public class Calculator
    {
        // Method performs an operation on first number and shows second one
        public void ProcessNumbers(int inputA, int inputB)
        {
            // Square the first number
            int square = inputA * inputA;

            // Output the square of inputA
            Console.WriteLine($"The square of the first number is: {square}");

            // Output the second number
            Console.WriteLine($"The second number provided is: {inputB}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Calculator class
            Calculator calc = new Calculator();

            // Call method using regular argument order
            calc.ProcessNumbers(3, 7);

            // Call method using named parameters
            calc.ProcessNumbers(inputB: 10, inputA: 4);

            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }
    }
}
