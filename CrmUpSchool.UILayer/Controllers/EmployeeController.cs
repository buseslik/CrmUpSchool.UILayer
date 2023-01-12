using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.BusinessLayer.Concrete;
using CrmUpSchool.BusinessLayer.ValidationRules;
using CrmUpSchool.DataAccessLayer.EntityFramework;
using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CrmUpSchool.UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly ICategoryService categoryService;

        EmployeeManager employeeManager = new EmployeeManager(new EFEmployeeDal());

        public EmployeeController(IEmployeeService employeeService, ICategoryService categoryService)
        {
            this.employeeService = employeeService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = employeeService.TGetEmployeesByCategory();
            return View(values);
        } 
        [HttpGet]
        public IActionResult AddEmployee()
        {
            //dropdown içinde kategori listesi

            List<SelectListItem> categoryValues = (from x in categoryService.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,//dropdown içinde görünecek kısım
                                                       Value = x.CategoryID.ToString()//seçim yapıldığında id'sini alan kısım



                                                   }) .ToList();
            ViewBag.v = categoryValues;
            return View();  
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            EmployeeValidatior validationRules = new EmployeeValidatior();
            ValidationResult result = validationRules.Validate(employee);
            if(result.IsValid)
            {
                employeeService.TInsert(employee);
                return RedirectToAction("Index");

            }
            else
            {
                //bizim yazdığımız sonuçlardan dönen hatalar yazılır
                foreach (var item in result.Errors)
                {
                    //modelden gelen hata mesajı göstermek icin modelstate
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage); 
                }
               
            }
            return View();
        }

        public IActionResult DeleteEmployee(int id)
        {
            var values = employeeService.TGetByID(id);
            employeeService.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToFalse(int id)
        {
            employeeService.TChangeEmployeeStatusToFalse(id);
            return RedirectToAction("Index");

        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            employeeService.TChangeEmployeeStatusToTrue(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var values = employeeService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var values = employeeService.TGetByID(employee.EmployeeID);
            employee.EmployeeStatus = values.EmployeeStatus;
            employeeService.TUpdate(employee);
             return RedirectToAction("Index");
        }
    }
}
