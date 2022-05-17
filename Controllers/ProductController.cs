using Microsoft.AspNetCore.Mvc;
using ProductsCatalog.Data;
using ProductsCatalog.Models;

namespace ProductsCatalog.Controllers{
    [ApiController]
    
    public class ProductController : ControllerBase { 

        [HttpPost("/v1/products")]        
        public IActionResult Post( 
            [FromBody] ProductModel Product, 
            [FromServices] AppDbContext context ){
                
            context.Product.Add(Product);
            context.SaveChanges();
            return Created("/{Product.Id}", Product);
        }
    }
}