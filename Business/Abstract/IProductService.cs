using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService // İş katmanında kullanacağımız servis.
    {
        IDataResult<List<Product>> GetAll();  // T = Product hem product döndür hem de sonucları döndür.
        IDataResult<List<Product>> GetAllByCategoryId(int id);  //Kategori Id'ye göre getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max); //Bu metotları servis ediyoruz.
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);  //Data olmadığı için sadece IResult
        IResult Update(Product product);
        
    }
}
