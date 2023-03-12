using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdafuncdelegate
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int ID { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, int id, string department, double salary)
        {
            Name = name;
            Age = age;
            ID = id;
            Department = department;
            Salary = salary;
        }
    }
        class Q6_Employees
    {
            static public void employees()
            {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("John Smith", 23, 001, "Marketing", 1000));
            employees.Add(new Employee("Delson", 23, 001, "Marketing", 1000));

            Console.WriteLine("List of Employees");
            foreach (Employee e in employees)
            {
                Console.WriteLine("Name : {0}\nAge: {1}\nID: {2}\n Department: {3}\nSalary : {4}", e.Name, e.Age, e.ID, e.Department, e.Salary);
            }

        }
    }
}
