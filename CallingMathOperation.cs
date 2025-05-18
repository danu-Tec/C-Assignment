using System;

namespace CallingMethodsApp
{
    // A class that contains mathematical operations
    public class MathOperations
    {
        // Method 1: Adds 10 to the input number
        public int AddTen(int number)
        {
            return number + 10;
        }

        // Method 2: Multiplies the input number by 5
        public int MultiplyByFive(int number)
        {
            return number * 5;
        }

        // Method 3: Subtracts 3 from the input number
        public int SubtractThree(int number)
        {
            return number - 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class to access its methods
            MathOperations operations = new MathOperations();

            // Ask the user for a number to perform math operations on
            Console.WriteLine("Enter an integer number to perform operations on:");
            int userNumber;

            // Try to convert user input to an integer safely
            bool isValid = int.TryParse(Console.ReadLine(), out userNumber);

            if (isValid)
            {
                // Call each method and store the results
                int result1 = operations.AddTen(userNumber); // Adds 10
                int result2 = operations.MultiplyByFive(userNumber); // Multiplies by 5
                int result3 = operations.SubtractThree(userNumber); // Subtracts 3

                // Display the results to the console
                Console.WriteLine($"{userNumber} + 10 = {result1}");
                Console.WriteLine($"{userNumber} * 5 = {result2}");
                Console.WriteLine($"{userNumber} - 3 = {result3}");
            }
            else
            {
                // Inform the user of invalid input
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
