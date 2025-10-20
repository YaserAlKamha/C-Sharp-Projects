using System;

namespace InterfaceDemo
{
    // Interface declaration with a Quit method
    public interface IQuittable
    {
        void Quit();
    }

    // Employee implements IQuittable
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Quit()
        {
            Console.WriteLine($"Notice: {FirstName} {LastName} (ID #{Id}) has resigned.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism in action: interface type holding a concrete object
            IQuittable staff = new Employee
            {
                Id = 102,
                FirstName = "Yaser",
                LastName = "AlKamha"
            };

            // Call Quit method via interface
            staff.Quit();

            Console.ReadKey();
        }
    }
}
