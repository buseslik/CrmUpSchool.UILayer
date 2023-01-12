using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }

        public void TChangeEmployeeStatusToFalse(int id)
        {
            employeeDal.ChangeEmployeeStatusToFalse(id);
        }

        public void TChangeEmployeeStatusToTrue(int id)
        {
            employeeDal.ChangeEmployeeStatusToTrue(id);
        }

        public void TDelete(Employee t)
        {
            employeeDal.Delete(t);
        }

        public Employee TGetByID(int id)
        {
           return employeeDal.GetById(id);
           
        }

        public List<Employee> TGetEmployeesByCategory()
        {
            return employeeDal.GetEmployeesByCategory();
        }

        public List<Employee> TGetList()
        {
            return employeeDal.GetList();   
        }

        public void TInsert(Employee t)
        {
            employeeDal.Insert(t);
        }

        public void TUpdate(Employee t)
        {
           
           employeeDal.Update(t);
        }
    }
}
