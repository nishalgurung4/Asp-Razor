using System;
using System.ComponentModel.DataAnnotations;

namespace RazorDemo.Models
{
	public class Employee
	{
		public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
		public string PhotoPath { get; set; }
		public Dept? Department { get; set; }
	
	}
}

