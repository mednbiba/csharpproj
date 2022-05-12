using Microsoft.AspNetCore.Mvc;
using projetnbiba.Models;

namespace projetnbiba.Controllers
{
    public class EmployeeController : Controller
    {


        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            return View("./views/Employee/ConfirmPage.cshtml",employee);

        }
    }
}
