using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() =>
            _productService.Get();

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public ActionResult<Product> Get(string id)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
         
            if (product.Tags.Count < 2)
            {
                return BadRequest("Need almost 2 tags");
            }

            _productService.Create(product);

            return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        }

        [HttpPost("CreateBatch")]
        public ActionResult<Product> CreateBatch(Product product)
        {
            if (product.Tags.Count < 2)
            {
                return BadRequest("Need almost 2 tags");
            }

            List<Product> batch = new List<Product>();
            product.Id = ObjectId.GenerateNewId().ToString();

            for (int i = 1; i <= 10000; i++)
            {
                var batchProduct = new Product()
                {
                    Name = product.Name,
                    Id = ObjectId.GenerateNewId().ToString(),
                    Description = product.Description,
                    Price = product.Price,
                    Tags = product.Tags,
                    ImageUrl = product.ImageUrl,
                };
                batch.Add(batchProduct);
            }

            _productService.CreateBatch(batch);
            return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Product productIn)
        {
            var product = _productService.Get(id);
            productIn.Id = id;

            if (product == null)
            {
                return NotFound();
            }

            if (productIn.Tags.Count < 2)
            {
                return BadRequest("Need almost 2 tags");
            }

            _productService.Update(id, productIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var product = _productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            _productService.Remove(product.Id);

            return NoContent();
        }
    }
}
