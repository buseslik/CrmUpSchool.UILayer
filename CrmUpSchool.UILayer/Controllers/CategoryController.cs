using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Controllers
{
    public class CategoryController : Controller
    {
       private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = categoryService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var values = categoryService.TGetByID(id);
            categoryService.TDelete(values);
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = categoryService.TGetByID(id);
            categoryService.TUpdate(values);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
