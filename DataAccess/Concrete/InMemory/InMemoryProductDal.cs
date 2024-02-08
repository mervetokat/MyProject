using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() {
            new Product{CategoryId=1,ProductId=1,ProductName="kasa",UnitPrice=10,UnitsInStock=3},
            new Product{CategoryId=2,ProductId=2,ProductName="kamera",UnitPrice=15,UnitsInStock=5},
            new Product{CategoryId=1,ProductId=3,ProductName="kalem",UnitPrice=1,UnitsInStock=30},
            new Product{CategoryId=2,ProductId=4,ProductName="dolap",UnitPrice=1000,UnitsInStock=13}

            };
        }

        public List<ProductDetailDto> ProductDetails => throw new NotImplementedException();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {//LINQ Language ıntegrated query
         // Product productToDelete = null;
         //gelen product ıd sını bulduk alttaki satırda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();//ıd listeler
        }

        public void Update(Product product)
        {
            Product productUpDate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productUpDate.ProductName = product.ProductName;
            productUpDate.CategoryId = product.CategoryId;
            productUpDate.UnitPrice = product.UnitPrice;
            productUpDate.UnitsInStock = product.UnitsInStock;
        }

        List<ProductDetailDto> IProductDal.ProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}