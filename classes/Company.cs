using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; } = DateTime.Now;

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; } = new List<Employee>();

        public Company(string name, DateTime createDate)
        {
            Name = name;
            CreatedOn = createDate;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

    }
}