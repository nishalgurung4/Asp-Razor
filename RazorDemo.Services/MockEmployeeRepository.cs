using System;
using RazorDemo.Models;

namespace RazorDemo.Services
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
        private List<Employee> _employeeList;

		public MockEmployeeRepository()
		{
            _employeeList = new List<Employee>()
            {
                new Employee() { ID = 1, Name = "Nishal", Department = Dept.HR, Email = "nishal.gurung4@gmail.com", PhotoPath = "nishal.png"},
                new Employee() { ID = 2, Name = "Bishal", Department = Dept.IT, Email = "bishal@gmail.com", PhotoPath = "bishal.png"}
            };
		}

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.ID == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            Employee employee = this.GetEmployee(updatedEmployee.ID);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Department = updatedEmployee.Department;
                employee.PhotoPath = updatedEmployee.PhotoPath;
            }
            return employee;
        }

        public Employee Delete(int id)
        {
            var employeeToDelete = this.GetEmployee(id);

            if (employeeToDelete != null)
            {
                _employeeList.Remove(employeeToDelete);
            }

            return employeeToDelete;
        }

        public Employee Add(Employee employee)
        {
            employee.ID = _employeeList.Max(e => e.ID) + 1;
            _employeeList.Add(employee);
            return employee;
        }
    }
}

