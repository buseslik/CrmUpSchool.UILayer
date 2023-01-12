using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }   
        public string EmployeeSurname { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeeImage { get; set; }
        //property olarak category ve employee tablosunu ilişkilendirmek için 
        //nerden ilişki aldığımızı ve neyi aldığımızı ekle (Category tablosundan Category)
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public bool EmployeeStatus { get; set; }
    }
}

//migration eklenemedi ona bakman gerek No DbContext was found in assembly 'CrmUpSchool.UILayer'.
//Ensure that you're using the correct assembly and that the type is neither abstract nor generic.
