
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    // JOIN leri burada yapacağız.
    public class ProductDetailDto : IDto  //Idto üzerinden new generate type yaparak Core Katmanına İnterface ekledik.
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
