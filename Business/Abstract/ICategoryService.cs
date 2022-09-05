using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult <Category> GetById(int categoryId);  //bir tane category Id vericez,sende bize ilgili kategoriyi getir.
    }
}
