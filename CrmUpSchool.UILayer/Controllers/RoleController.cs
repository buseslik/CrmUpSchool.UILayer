using CrmUpSchool.EntityLayer.Concrete;
using CrmUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var values = roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        
        //role tablosuna eklemek istediğimiz propertileri tutmak için model kısmından yeni bir sınıf oluşturduk ve addrole içne ekledik
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            return View();
        }
    }
   
}
