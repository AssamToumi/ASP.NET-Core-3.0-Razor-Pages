using Razor_Project.Models;
using System;
using System.Collections.Generic;


namespace Razor_Project.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updateEmployee);
    }
}
