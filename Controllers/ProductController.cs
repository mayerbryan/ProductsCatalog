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

        [HttpGet("/test")]
        public IActionResult Gettest([FromServices] AppDbContext context)
            => Ok("test");



        [HttpGet("/v1/products/{id:int}")]        
        public IActionResult GetById( 
            [FromRoute] int id, 
            [FromServices] AppDbContext context ){              
            
            var Product = context.Product.FirstOrDefault(x => x.Id == id);
            if(Product == null)
                return NotFound();
            
            return Ok(Product);
        } 

        [HttpPut("/v1/products/{id:int}")]        
        public IActionResult Put( 
            [FromRoute] int id, 
            [FromBody] ProductModel Product,
            [FromServices] AppDbContext context ){              
            
            var model = context.Product.FirstOrDefault(x => x.Id == id);
            if(model == null)
                return NotFound();

            model.Name = Product.Name;
            model.Price = Product.Price;
            model.SKU = Product.SKU;
            model.Description = Product.Description;

            context.Product.Update(model);
            context.SaveChanges(); 
            return Ok(model);
        } 

        [HttpDelete("/v1/products/{id:int}")]        
        public IActionResult Delete( 
            [FromRoute] int id, 
            [FromServices] AppDbContext context ){              
            
            var model = context.Product.FirstOrDefault(x => x.Id == id);
            if(model == null)
                return NotFound();

            context.Product.Remove(model);
            context.SaveChanges(); 
            return Ok(model);
        }
    }
}