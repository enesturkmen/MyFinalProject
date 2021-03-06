using DataAccess.Abstract;
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
        public InMemoryProductDal()
        {
            //veri tabanindan geliyormus gibi
            _products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName ="Bardak", CategoryId = 1, UnitPrice=15, UnitsInStock=15},
                new Product{ProductId = 2, ProductName ="Telefon", CategoryId = 2, UnitPrice=1500, UnitsInStock=5},
                new Product{ProductId = 3, ProductName ="Kamera", CategoryId = 2, UnitPrice=1500, UnitsInStock=25},
                new Product{ProductId = 4, ProductName ="Klavye", CategoryId = 2, UnitPrice=150, UnitsInStock=65},
                new Product{ProductId = 5, ProductName ="Fare", CategoryId = 2, UnitPrice=150, UnitsInStock=45}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            //linq - language integrated query
            //linq ile listeyi ayni sql gibi filtreliyebiliyoruz
            //linq olmasaydi listeyi dolasmak (for ile) ve sart koymak
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete=p;
            //    }
            //}
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId==product.ProductId);
            //FirstOrDefault, First de kullanilsa da olur.
            _products.Remove(productToDelete);
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId== categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gonderdigim urun idsine sahip olan listedeki urunu bul demek
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        List<ProductDetailDto> IProductDal.GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
