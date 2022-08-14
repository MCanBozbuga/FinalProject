using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Başka bir katmanı kullanmak için referans veririz.Data access'de ürünleri listelicez.
    //Ürünler Entities katmanında. Product üzerine gelip, entities referan ekle.

    //DATAACCESS PROJESİ , CORE 'A BAĞLI OLDUĞU İÇİN PROJECT REFERENCES'DEN CORE REFERANS VERDİK.
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();


    }
}
