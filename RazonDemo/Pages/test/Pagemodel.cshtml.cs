using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazonDemo.Pages.test
{
    public class PagemodelModel : PageModel
    {
        //like model
        public string? Message { get; set; }

        //page template are like view in MVC
        // like controller
        public void OnGet()
        {
            Message = "Hello World! Current time = " + DateTime.Now.ToLongTimeString();
        }
    }
}
