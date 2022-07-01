using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Başka bir katmanı kullanmak için referans veririz.Data access'de ürünleri listelicez.
    //Ürünler Entities katmanında. Product üzerine gelip, entities referan ekle.

    public interface IProductDal : IEntityRepository<Product>
    {
       


    }
}
