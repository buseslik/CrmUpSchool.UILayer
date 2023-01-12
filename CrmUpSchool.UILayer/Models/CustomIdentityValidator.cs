using Microsoft.AspNetCore.Identity;

namespace CrmUpSchool.UILayer.Models
{
    //ilgili hataları kendime göre düzenlemememi sağlayacak
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az {length} karakter olmalıdır."
            };

        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = $"Lütfen en az bir tane küçük harf giriniz."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = $"Lütfen en az bir tane büyük harf giriniz."
            };
        }
        public override IdentityError PasswordRequiresDigit ()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = $"Lütfen en az bir tane sayı giriniz."
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"İlgili mail adresi : {email} sistemde mevcut, lütfen farklı bir mail giriniz."
            };
        }
        public override IdentityError DuplicateUserName(string username)
        {
            return new IdentityError()
            {
                Code = "DuplicateUserName",
                Description = $"İlgili mail adresi : {username} sistemde mevcut, lütfen farklı bir kullanıcı adı giriniz."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
       
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Lütfen en az bir tane karakter giriniz.."
            };
        }

    }
  
}
