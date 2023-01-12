using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.UILayer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail giriniz")]
         public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şİfrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor lütfen tekrar deneyin")]
        public string ConfirmPassword { get; set; }
       
    }
}
