using System;

namespace OperatorDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        // Compare based on Id
        public static bool operator ==(Employee e1, Employee e2)
        {
            if (ReferenceEquals(e1, e2)) return true;
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null)) return false;

            return e1.Id == e2.Id;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            return this == obj as Employee;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            // Create two employees
            Employee emp1 = new Employee { Id = 2, First = "Yaser", Last = "AlKamha" };
            Employee emp2 = new Employee { Id = 2, First = "Jack", Last = "Jones" };

            // Use overloaded operators
            Console.WriteLine(emp1 == emp2 
                ? "These employees have matching IDs." 
                : "These employees are different.");

            Console.WriteLine(emp1 != emp2 
                ? "Employees are not the same (using !=)" 
                : "Employees are considered the same (using !=)");

            Console.ReadLine();
        }
    }
}
