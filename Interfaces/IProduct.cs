using ApiTenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Interfaces
{
    public interface IProduct
    {
        public (int status, string message) AddProduct(Product product);
        public (int status, string message, ICollection<Product> products) GetProducts();
        public (int status, string message, Product product) GetProduct(int idProduct);
        public (int status, string message) UpdateProduct(int idProduct, Product product);
        public (int status, string message) DeleteProduct(int idProduct);
    }
}
