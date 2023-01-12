using CrmUpSchool.EntityLayer.Concrete;
using CrmUpSchool.UILayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace CrmUpSchool.UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        //dependency injection yaptık
        public RegisterController(UserManager<AppUser> userManager)
        {
            //tanımladığımız userManager mimaride tanımlı değil identityde tanımlı
            _userManager = userManager;
        }

        public string UserName { get; private set; }
        public object Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        //yeni bir kullanıcı kaydı eklemek için kullanılır
        //async methodunu kullanabilmek için methodu da async hale çevirmeliyiz
        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            //CreateAsync aynı anda birden çok işlemin gerçekleşmesini sağlar,kuyruğa almadan
            var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "UserList");
            }

            return View(result);


        }

        // hata mesajlarını görüntülemek için modelle çalışmak önemlidir

       
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index2(UserSignUpModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                {
                    UserName = p.UserName;
                    Name = p.Name;
                    Surname = p.Surname;
                    Email = p.Email;
                    PhoneNumber = p.PhoneNumber;
                };
                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    // model geçeliyse üstte bulunan işlemler gerçekleşir
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);

                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Şifreler Uyuşmuyor");
                }
            }
            else
            {

            }

            return View();

        }

    }
}
