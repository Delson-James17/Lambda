using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    class Employees
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }

    class Q7_Department
    {
      static void department() {
            // Create a list of employees
            List<Employees> employees = new List<Employees> {
            new Employees { Name = "John", Department = "Sales" },
            new Employees { Name = "Jane", Department = "Marketing" },
            new Employees { Name = "Bob", Department = "Sales" },
            new Employees { Name = "Mary", Department = "Marketing" },
            new Employees { Name = "Tom", Department = "HR" }
        };

            try
            {
                // Get the department name from user input
                Console.Write("Enter department name: ");
                string department = Console.ReadLine();

                // Loop through the employees list and print the names of employees in the specified department
                foreach (Employees employee in employees)
                {
                    if (employee.Department == department)
                    {
                        Console.WriteLine(employee.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}

