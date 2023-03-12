// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Data;
using System.Collections.Generic;

namespace Questionares
{
    class Employeers
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public decimal Salary { get; set; }
    }

    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }

    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public int ID { get; set; }
        public string Door { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
    }

    class EmployeeManager
    {
        private List<Employeers> employees;

        public EmployeeManager()
        {
            employees = new List<Employeers>();
        }

        public void AddEmployee(Employeers employee)
        {
            employees.Add(employee);
        }

        public List<Employeers> GetEmployees()
        {
            return employees;
        }

        public Employeers GetEmployeeByID(int id)
        {
            return employees.Find(e => e.ID == id);
        }

        public void UpdateEmployee(Employeers employee)
        {
            Employeers existingEmployee = employees.Find(e => e.ID == employee.ID);
            if (existingEmployee != null)
            {
                existingEmployee.DepartmentID = employee.DepartmentID;
                existingEmployee.Salary = employee.Salary;
            }
        }

        public void DeleteEmployee(int id)
        {
            employees.RemoveAll(e => e.ID == id);
        }
    }

    class DepartmentManager
    {
        private List<Department> departments;

        public DepartmentManager()
        {
            departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public Department GetDepartmentByID(int id)
        {
            return departments.Find(d => d.ID == id);
        }

        public void UpdateDepartment(Department department)
        {
            Department existingDepartment = departments.Find(d => d.ID == department.ID);
            if (existingDepartment != null)
            {
                existingDepartment.Name = department.Name;
                existingDepartment.Location = department.Location;
            }
        }

        public void DeleteDepartment(int id)
        {
            departments.RemoveAll(d => d.ID == id);
        }
    }

    class PersonManager
    {
        private List<Person> people;

        public PersonManager()
        {
            people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetPeople()
        {
            return people;
        }

    }
}