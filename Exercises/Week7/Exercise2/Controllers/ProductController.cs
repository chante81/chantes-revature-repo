using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    // In memory data that you will be referencing in your methods
    private static List<Product> products = new()
    {
        new (1, "Towel Small", true),
        new (2, "Beach Ball", true),
        new (3, "Cooler 15 Gallon", true),
        new (4, "Towel Medium", true),
        new (5, "Towel Large", true),
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var product = products.FirstOrDefault(p => p.ProductId == id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        product.ProductId = products.Count + 1;
        products.Add(product);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Product updatedProduct)
    {
        var product = products.FirstOrDefault(p => p.ProductId == id);
        if (product == null)
        {
            return NotFound("ID NOT FOUND. Please try again.");
        }
        // products.Remove(product);
        // products.Add(updatedProduct);
        int index = products.FindIndex(p => p.ProductId == id);
        products[index] = updatedProduct;
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.ProductId == id);
        if (product == null)
        {
            return NotFound();
        }
        products.Remove(product);
        return Ok();
    }
}