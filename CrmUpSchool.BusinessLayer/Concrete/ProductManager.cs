using Crm.UpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal productDal;

        //dependency enjection yapıldı
        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public Product GetByID(int id)
        {
            return productDal.GetById(id);
        }

        public List<Product> GetList()
        {
            return productDal.GetList();    
        }

        public void TDelete(Product t)
        {
            productDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return productDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return productDal.GetList();
        }

        public void TInsert(Product t)
        {
            productDal.Insert(t);   
        }

        public void TUpdate(Product t)
        {
            productDal.Update(t);
        }
    }
}
