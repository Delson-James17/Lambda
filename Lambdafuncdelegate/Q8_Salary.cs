using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    class Employeess
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    class Q8_Salary
    {
        public static void salary() { 
        // Create a list of employees
        List<Employeess> employees = new List<Employeess>
        {
            new Employeess { Name = "John", Salary = 1500 },
            new Employeess { Name = "Jane", Salary = 10000 },
            new Employeess { Name = "Bob", Salary = 300 },
            new Employeess { Name = "Mary", Salary = 100000 },
            new Employeess { Name = "Tom", Salary = 20000 }
        };
        try
            {
                // Get the department name from user input

                // Loop through the employees list and print the names of employees in the specified department
                foreach (Employeess employee in employees)
                {
                    if (employee.Salary< 10000)
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
