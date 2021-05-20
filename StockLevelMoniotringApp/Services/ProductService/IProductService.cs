using FormUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Service.ProductService
{
    public interface IProductService
    {
        public Product GetProductById(int id);
        public Product AddProduct(Product value);
    }
}
