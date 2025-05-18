using System;

// Define the IQuittable interface
interface IQuittable
{
    // Declare the Quit method that implementing classes must define
    void Quit();
}

// Employee class that inherits from IQuittable
class Employee : IQuittable
{
    // Property to store employee's name
    public string Name { get; set; }
    
    // Property to store employee's ID
    public int ID { get; set; }

    // Constructor to initialize employee properties
    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Implement the Quit method from IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{Name} (ID: {ID}) has quit the company.");
    }

    // Method to display employee information
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, ID: {ID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new Employee object
        Employee emp = new Employee("John Doe", 1001);
        
        // Display employee information
        emp.DisplayInfo();

        // Use polymorphism to create an IQuittable reference to the Employee object
        IQuittable quittableEmp = emp;
        
        // Call the Quit method through the interface reference
        quittableEmp.Quit();

        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}