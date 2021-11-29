using EmployeeCard.Data.Interfaces;
using EmployeeCard.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCard.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Jason J. Smith",
                Type = 1,
                //Birthdate = "18-08-1986",
                PhoneNumber = "15638793",
                IsAvailable = true
            },
            new Employee
            {
                Id = 2,
                Name = "Samantha Silver",
                Type = 2,
                //Birthdate = "18-08-1986",
                PhoneNumber = "14920185",
                IsAvailable = true
            },
            new Employee
            {
                Id = 3,
                Name = "Max Fisher",
                Type = 1,
                //Birthdate = "18-08-1986",
                PhoneNumber = "16903024",
                IsAvailable = false
            }
        };

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
