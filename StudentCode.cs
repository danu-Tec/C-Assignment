using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StudentCodeFirstApp
{
    // This is the Student entity class
    public class Student
    {
        [Key] // Marks this as the primary key
        public int StudentId { get; set; }

        public string Name { get; set; }
    }

    // This is the Entity Framework DbContext
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDbConnection") { }

        public DbSet<Student> Students { get; set; }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    Name = "John Doe"
                };

                // Add student to database
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadKey();
        }
    }
}