using CrmUpSchool.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CrmUpSchool.UILayer.Controllers
{
    public class CustomerController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.customers.ToList();
            return View(values);
        }
    }
}
