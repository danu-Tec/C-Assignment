using System;

namespace OperatorsAssignment
{
    // Define the Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Property to store employee ID
        public int Id { get; set; }
        
        // Property to store employee's first name
        public string FirstName { get; set; }
        
        // Property to store employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null or if one is null
            if (ReferenceEquals(emp1, null))
            {
                return ReferenceEquals(emp2, null);
            }
            
            // Use the Equals method to handle the comparison
            return emp1.Equals(emp2);
        }

        // Overload the != operator (required when overloading ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply return the inverse of the == operator
            return !(emp1 == emp2);
        }

        // Override the Equals method to compare by Id
        public override bool Equals(object obj)
        {
            // If the object is null or not an Employee, return false
            if (obj == null || !(obj is Employee))
            {
                return false;
            }
            
            // Compare the Id properties
            return this.Id == ((Employee)obj).Id;
        }

        // Override GetHashCode since we overrode Equals
        public override int GetHashCode()
        {
            // Use the Id as the hash code since it's our comparison key
            return this.Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create first employee object and set properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create second employee object with same ID but different names
            Employee employee2 = new Employee
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Create third employee object with different ID
            Employee employee3 = new Employee
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe"
            };

            // Compare employee1 and employee2 using overloaded == operator
            bool areEqual1And2 = (employee1 == employee2);
            Console.WriteLine($"Employee 1 and Employee 2 are equal: {areEqual1And2}"); // True (same Id)

            // Compare employee1 and employee3 using overloaded == operator
            bool areEqual1And3 = (employee1 == employee3);
            Console.WriteLine($"Employee 1 and Employee 3 are equal: {areEqual1And3}"); // False (different Ids)

            // Compare employee1 and employee2 using overloaded != operator
            bool areNotEqual1And2 = (employee1 != employee2);
            Console.WriteLine($"Employee 1 and Employee 2 are not equal: {areNotEqual1And2}"); // False (they are equal)

            // Compare employee1 and employee3 using overloaded != operator
            bool areNotEqual1And3 = (employee1 != employee3);
            Console.WriteLine($"Employee 1 and Employee 3 are not equal: {areNotEqual1And3}"); // True (they are not equal)

            // Wait for user input before closing the console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}