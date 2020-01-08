using Razor_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Razor_Project.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Assam", Department = Dept.HR,
                    Email = "assamtomi@outlook.com", PhotoPath="assam.png" },
                new Employee() { Id = 2, Name = "Hany", Department = Dept.IT,
                    Email = "hany@outlook.com", PhotoPath="hany.png" },
                new Employee() { Id = 3, Name = "Sarra", Department = Dept.IT,
                    Email = "sarra@outlook.com", PhotoPath="sarra.png" },
                new Employee() { Id = 4, Name = "Marton", Department = Dept.Payroll,
                    Email = "marton@outlook.com", PhotoPath="marton.png" },
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id== id);
        }

        public Employee Update(Employee updatedEmployee)
        {
           Employee employee = _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Department = updatedEmployee.Department;
            }
            return employee;
        }
    }
}
