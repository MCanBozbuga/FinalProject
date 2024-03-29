﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        // ctor bellekte referans aldığı zaman çalışacak olan blok.
        public InMemoryProductDal() //CTOR
        {
            // VERİ TABANINDA GELİYOR GİBİ SİMÜLE ETTİK.
            _products = new List<Product> {
            new Product{CategoryId=1, ProductId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
            new Product{CategoryId=2, ProductId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
            new Product { CategoryId = 3, ProductId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2 },
            new Product { CategoryId = 4, ProductId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
            new Product { CategoryId = 5, ProductId = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 },

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); //Singleordefault tek bir ürün bulmaya yarar.
            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products; // veri tabanını döndürüyor.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();  
            // Where, içindeki şarta uyan elemanları yeni liste haline getirip onu döndürür.
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan Listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //Singleordefault tek bir ürün bulmaya yarar.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
