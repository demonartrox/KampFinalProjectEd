using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; //bağımlılığı constructor injection ile yaptım.

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları yazılacak.
            return _categoryDal.GetAll();
        }

        //Alttaki kod alttaki satırı gerçekleştiriyor aslında.
        //Select * from Categories where CategoryId = 3 (burada 3 ü biz verdik)
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
