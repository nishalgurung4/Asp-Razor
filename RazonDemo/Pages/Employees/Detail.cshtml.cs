using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Models;
using RazorDemo.Services;

namespace RazonDemo.Pages.Employees
{
	public class DetailModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public Employee Employee { get; private set; }

        public DetailModel(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);
            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}
