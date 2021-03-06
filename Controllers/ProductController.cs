using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTenStore.Interfaces;
using ApiTenStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.AspNetCore.Cors;

namespace ApiTenStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct productProvider;

        public ProductController(IProduct productProvider)
        {
            this.productProvider = productProvider;
        }

        [HttpPost]
        [EnableCors]
        public ActionResult AddProduct(Product product)
        {
            var result = productProvider.AddProduct(product);            
            return Ok(new { status = result.status, message = result.message });
        }

        [HttpGet]
        [EnableCors]
        public ActionResult GetProducts()
        {
            var products = productProvider.GetProducts();            
            return Ok(new { status = products.status, message = products.message, data = products.products });
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetProduct(int id)
        {
            var product = productProvider.GetProduct(id);
            return Ok(new { status = product.status, message = product.message, data = product.product });
        }

        [HttpPut]
        [Route("update/{id}")]
        public ActionResult UpdateProduct(int id, Product product)
        {
            var result = productProvider.UpdateProduct(id, product);
            return Ok(new {status = result.status, message = result.message });
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var result = productProvider.DeleteProduct(id);
            return Ok(new { status = result.status, message = result.message });
        }
    }
}
