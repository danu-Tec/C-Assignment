using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to select an index of the string array
            Console.WriteLine("Select an index for the string array (0 to 4):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Display the string at the selected index, or an error message if the index is invalid
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine($"String at index {stringIndex}: {stringArray[stringIndex]}");
            }
            else
            {
                Console.WriteLine("Invalid index selected for the string array.");
            }

            // Step 2: Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index of the integer array
            Console.WriteLine("Select an index for the integer array (0 to 4):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Display the integer at the selected index, or an error message if the index is invalid
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine($"Integer at index {intIndex}: {intArray[intIndex]}");
            }
            else
            {
                Console.WriteLine("Invalid index selected for the integer array.");
            }

            // Step 4: Create a list of strings
            List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

            // Ask the user to select an index of the list
            Console.WriteLine("Select an index for the string list (0 to 4):");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Display the content at the selected index, or an error message if the index is invalid
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine($"String at index {listIndex}: {stringList[listIndex]}");
            }
            else
            {
                Console.WriteLine("Invalid index selected for the string list.");
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
