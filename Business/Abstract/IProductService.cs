using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService // İş katmanında kullanacağımız servis.
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);  //Kategori Id'ye göre getir.
        List<Product> GetByUnitPrice(decimal min, decimal max); //Bu metotları servis ediyoruz.
    }
}
