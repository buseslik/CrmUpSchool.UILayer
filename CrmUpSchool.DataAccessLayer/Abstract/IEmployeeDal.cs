using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeDal : IGenericDal<Employee> 
    {
        //sadece employee sınıfına özel tanımlandı category e göre employee çağırmak için
        //personel tablosunda bulunan departmanları isimleriyle çağırmak için oluşturuldu.
        List<Employee> GetEmployeesByCategory();
        void ChangeEmployeeStatusToFalse(int id);
        void ChangeEmployeeStatusToTrue(int id);

    }
}
