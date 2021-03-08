using System;
using System.Collections.Generic;


namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)

        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeesList { get; set; }
        

        /*
        Create a constructor method that accepts two arguments:
         1. The name of the company
         2. The date it was created

        The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            this.Name = name;
            this.CreatedOn = createdOn;

        }

    }

    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime startDate { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company seeSharp = new Company("SeeSharp", new DateTime());

            // Create three employees
            Employee jimmy = new Employee()
            {
                firstName = "Jimmy",
                lastName = "John",
                title = "Destroyer of Galaxies",
                startDate = new DateTime()
            };
            Employee john = new Employee()
            {
                firstName = "John",
                lastName = "Jimmy",
                title = "Builder of Galaxies",
                startDate = new DateTime()
            };
            Employee jimbo = new Employee()
            {
                firstName = "Jimbo",
                lastName = "Johnsmith",
                title = "Destroyer of Toilets",
                startDate = new DateTime()
            };

            // Assign the employees to the company
            seeSharp.EmployeesList = new List<Employee>();
            seeSharp.EmployeesList.Add(jimmy);
            seeSharp.EmployeesList.Add(john);
            seeSharp.EmployeesList.Add(jimbo);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach ( Employee e in seeSharp.EmployeesList )
            {
                Console.WriteLine($"Name: {e.firstName} {e.lastName}");
                Console.WriteLine($"Title: {e.title}");
            }
        }
    }
}
