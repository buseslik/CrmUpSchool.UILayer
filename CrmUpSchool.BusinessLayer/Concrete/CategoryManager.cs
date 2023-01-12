using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.EntityFramework;
using CrmUpSchool.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.Concrete
{
    //genericservice içinde tanımlanan methodlar implemente oldu//dependency enjection yapılır
   
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        //bağımlılıktan kurtulmak için yapılır CategoryManager ctrl.>generate constructor
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        
        //void türünde olmayan methodlarda return kullanılıyor
        public Category GetByID(int id)
        {
           return categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetList();
        }

        public void TDelete(Category t)
        {
            categoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return categoryDal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            //if(t.CategoryName!==null && t.CategoryName.Length>=5 && t.CategoryDescription.StartsWith("a"))
            // {
            //   categoryDal.Insert(t);
            // }
            // else
            // {
            //hata mesajı
            // }
            categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            categoryDal.Update(t);  
        }
    }
}
