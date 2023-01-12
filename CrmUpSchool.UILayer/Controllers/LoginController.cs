using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]  
        public async Task <IActionResult> Index(AppUser appUser)
        {
            var result = await signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
    }
}
