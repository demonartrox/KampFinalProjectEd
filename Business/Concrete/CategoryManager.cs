﻿using Business.Abstract;
using Core.Utilities.Results;
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

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //iş kodları yazılacak.
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        //Alttaki kod alttaki satırı gerçekleştiriyor aslında.
        //Select * from Categories where CategoryId = 3 (burada 3 ü biz verdik)
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        //IDataResult<List<Category>> ICategoryService.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //IDataResult<Category> ICategoryService.GetById(int categoryId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
