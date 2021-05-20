using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Service.ProductService
{
    class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _genericRepository;

        public ProductService(IGenericRepository<Product> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Product AddProduct(Product value)
        {
            var newProduct = new Product() { DisplayName = value.DisplayName };
            _genericRepository.AddEntity(newProduct);
            return newProduct;
        }

        public Product GetProductById(int id)
        {
            return _genericRepository.GetEntityById(id);
        }

    }
}
