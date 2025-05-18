using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();
            
            // Call the method by passing two numbers directly (positional parameters)
            mathOps.DoMathAndDisplay(10, 20);
            
            // Call the method by specifying the parameters by name
            mathOps.DoMathAndDisplay(firstNumber: 15, secondNumber: 30);
            
            // Wait for user input before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    // Class containing our math operation method
    public class MathOperations
    {
        // Void method that takes two integers as parameters
        public void DoMathAndDisplay(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (in this case, multiply by 2)
            int result = firstNumber * 2;
            
            // Display the second integer to the screen
            Console.WriteLine($"The result of the math operation is: {result}");
            Console.WriteLine($"The second number displayed is: {secondNumber}");
        }
    }
}