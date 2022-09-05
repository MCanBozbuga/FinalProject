using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
        //  Business katmanı Veri Erişimine bağlı... => Bağımlılığı Constractor Injection ile yapıyoruz. => ICategoryDal _categoryDal;(DataAccess'de ICategoryDal)
    {
        ICategoryDal _categoryDal; //_categorDal => çözümleyip, generate constractor.
        
        public CategoryManager(ICategoryDal categoryDal)  //ICategoryDal categoryDal => generate constractor ile geliyor.
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        // select*from Categories where CategoryId=3
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
       
    }
}
