using EmployeeCard.Data.Interfaces;
using EmployeeCard.Data.Models;
using EmployeeCard.Data.Repositories;
using EmployeeCardAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //public static List<Employee> employees = new List<Employee>()
        //{
        //    new Employee
        //    {
        //        Id = 1,
        //        Name = "Jason J. Smith",
        //        Type = 1,
        //        //Birthdate = "18-08-1986",
        //        PhoneNumber = "15638793",
        //        IsAvailable = true
        //    },
        //    new Employee
        //    {
        //        Id = 2,
        //        Name = "Samantha Silver",
        //        Type = 2,
        //        //Birthdate = "18-08-1986",
        //        PhoneNumber = "14920185",
        //        IsAvailable = true
        //    },
        //    new Employee
        //    {
        //        Id = 3,
        //        Name = "Max Fisher",
        //        Type = 1,
        //        //Birthdate = "18-08-1986",
        //        PhoneNumber = "16903024",
        //        IsAvailable = false
        //    }
        //};

        private IEmployeeRepository employees = new EmployeeRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return employees.GetAllEmployees();
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id) 
        {
            //var employee = employees.FirstOrDefault(x => x.Id == id);
            var employee = employees.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        //POST, PUT, DELETE

    }
}
