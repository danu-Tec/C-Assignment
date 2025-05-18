using System;

namespace MethodsAndObjectsAp{
    // Defines a base class 'Person' that will hold name information
    public class Person
    {
        // Property to store the first name
        public string FirstName { get; set; }

        // Property to store the last name
        public string LastName { get; set; }

        // Method to print the full name to the console
        public void SayName()
        {
            // Combines first and last name into a single output
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Defines a class 'Employee' that inherits from the 'Person' class
    public class Employee : Person
    {
        // Property to store the employee ID
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Employee object and set its properties
            Employee employee = new Employee()
            {
                FirstName = "Sample",   // Set first name
                LastName = "Student",   // Set last name
                Id = 1                  // Set employee ID
            };

            // Call the SayName() method from the base class to display the full name
            employee.SayName();

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


