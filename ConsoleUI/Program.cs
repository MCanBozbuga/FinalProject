using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProdcutTest();  Extract Metot ile yaptık.
            //CategoryTest();
            //DTO Data Transfromation Object
            //ProductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetProductDetails();
            //if (result.Success)
            //{
            //    foreach (var product in productManager.GetProductDetails().Data)
            //    {
            //        Console.WriteLine(product.ProductName + product.CategoryName);
            //        //JOİN İŞLEMİ YAPTIK O YÜZDEN BU ŞEKİLDE YAZABİLİYORUZ. DİĞER TÜRLÜ İKİSİNİ BİR ARADA YAZAMAZDIK.
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

           

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("Category ID = " + category.CategoryId + "\nCategory Name = " + category.CategoryName);
            }
        }

        //private static void ProdcutTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    foreach (var product in productManager.GetByUnitPrice(40, 100))
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}
    }
}
