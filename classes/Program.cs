using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company goobtown = new Company("Goobtown Inc.", new DateTime(2020, 1, 1));

            // Create three employees
            Employee doug = new Employee()
            {
                FirstName = "Doug",
                LastName = "Warrington",
                Title = "Security Guard"
            };
            Employee kismet = new Employee()
            {
                FirstName = "Kismet",
                LastName = "Warrington",
                Title = "CEO"
            };

            Employee tato = new Employee()
            {
                FirstName = "Tato",
                LastName = "Warrington",
                Title = "Customer Service Associate"
            };

            // Assign the employees to the company
            goobtown.AddEmployee(doug);
            goobtown.AddEmployee(kismet);
            goobtown.AddEmployee(tato);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            goobtown.ListEmployees();
        }
    }
}