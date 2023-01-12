using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.ValidationRules
{
    public class EmployeeValidatior: AbstractValidator<Employee>
    {
        //RuleFor sadece constructor yazıldıktan sonra kullanılabilir
       public EmployeeValidatior()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel Adını Boş Geçemezsiniz!");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel Soyadını Boş Geçemezsiniz!");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriniz!");
            RuleFor(x => x.EmployeeName).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Giriniz!");
        }
    }
}
