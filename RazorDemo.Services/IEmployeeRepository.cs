namespace RazorDemo.Services;
using RazorDemo.Models;
public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();

    public Employee GetEmployee(int id);

    Employee Update(Employee updatedEmployee);

    Employee Delete(int id);

    Employee Add(Employee employee);

}

