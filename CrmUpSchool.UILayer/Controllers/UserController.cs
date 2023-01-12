using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CrmUpSchool.UILayer.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        //appuser tablosundaki verileri listelemek için injection yapıldı
        public UserController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = userManager.Users.ToString();
            return View(values);
        }
    }
}
