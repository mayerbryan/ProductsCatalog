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

        [HttpGet("/v1/products")]        
        public IActionResult Get( [FromServices] AppDbContext context )
            => Ok (context.Product.ToList());

        

        [HttpGet("/v1/products/{id:int}")]        
        public IActionResult GetById( 
            [FromRoute] int id, 
            [FromServices] AppDbContext context ){              
            
            var Product = context.Product.FirstOrDefault(x => x.Id == id);
            if(Product == null)
                return NotFound();
            
            return Ok(Product);
        } 
    }
}