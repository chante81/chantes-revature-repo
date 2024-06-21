using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductsController : ControllerBase
    {
        // This appdbContext is used to interact with our database
        // The constructor is used by our dependency manager to inject it into our clases
        // We do not have to initialize the controller or provide the abb db context into the constructor
        // this is managed for us by the dependency Injection Container  
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
         [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = p.Category.Name
                }).ToList();

            return products;
        }

        [HttpGet("{ProductId}")] // Should we take in any property not included in DTO??
        public ActionResult<ProductDTO> GetProductByProductId(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            var productDto = new ProductDTO
            {
                Name = product.Name,
                Price = product.Price,
                CategoryName = product.Category.Name
            };
            return (productDto);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> PostProduct(ProductDTO productDto)
        {
            var category = await _context.Categories.FirstAsync(c => c.Name == productDto.CategoryName);

            
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = category.CategoryId,
                Category = category
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProducts), new { ProductId = product.ProductId }, productDto);
        }

        [HttpPut]
        public ActionResult<ProductDTO> UpdateProduct(int ProductId, ProductDTO updatedProduct)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Category.Name = updatedProduct.CategoryName;

            _context.Products.Update(product);
            _context.SaveChanges();
            return Ok(updatedProduct);

        }

        [HttpDelete]
        public IActionResult DeleteProduct (int ProductId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == ProductId);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }
    }
}
