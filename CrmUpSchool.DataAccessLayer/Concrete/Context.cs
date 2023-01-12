using CrmUpSchool.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CrmUpSchool.DataAccessLayer.Concrete
{
    //bağlantıları tutacak
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FOH8AGD;Database=DbCRM;integrated security=True;");
            
    }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }  
        public DbSet<Employee> employees { get; set; }
        


    }
}
