using ApiTenStore.Interfaces;
using ApiTenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Providers
{
    public class IProductProvider : IProduct
    {
        private readonly AppDbContext context;

        public IProductProvider(AppDbContext context)
        {
            this.context = context;
        }

        public (int status, string message) AddProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
                var lastProduct = context.Products.OrderByDescending(pro => pro.id).FirstOrDefault();
                Console.WriteLine(lastProduct);
                return (200, "Producto insertado correctamente");
            }
            catch(Exception exc)
            {
                return (400, "Ocurrio un error al insertar el producto " + exc.ToString());
            } 
        }

        public (int status, string message) DeleteProduct(int idProduct)
        {
            try
            {
                var productDb = context.Products.FirstOrDefault(pro => pro.id == idProduct);
                if (productDb != null)
                {
                    context.Products.Remove(productDb);
                    context.SaveChanges();
                    return (200, "Producto Eliminado");
                }

                return (400, "Producto a eliminar no fue encontrado");
            }
            catch(Exception exc)
            {
                return (400, "Ocurrio un error al eliminar el producto:" + exc.ToString());
            }
        }

        public (int status, string message,Product product) GetProduct(int idProduct)
        {
            try
            {
                var result = context.Products.FirstOrDefault(pro => pro.id == idProduct);
                return (200, "Producto consultado", result);
            }
            catch(Exception exc)
            {
                var productEmpty = new Product();
                return (400, "Ocurrio un error al consultar el producto." + exc.ToString(), productEmpty);
            }
            
        }

        public (int status, string message, ICollection<Product> products) GetProducts()
        {
            var products = context.Products.ToList();
            return (200, "Producto consultado", products);
        }

        public  (int status, string message) UpdateProduct(int idProduct, Product product)
        {
            try
            {                
                var productDb = context.Products.FirstOrDefault(pro => pro.id == idProduct);                
                if(productDb != null)
                {
                    productDb.nombre = product.nombre;
                    productDb.descripcion = product.descripcion;
                    productDb.iva = product.iva;
                    productDb.precio = product.precio;
                    context.SaveChanges();
                    return (200, "Producto actualizado");
                }

                return (400, "Producto a actualizar no fue encontrado");
            }
            catch(Exception exc)
            {
                return (400, "Ocurrio un error al actualizar el producto: " + exc.ToString());
            }
        }
    }
}
