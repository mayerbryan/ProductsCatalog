using Microsoft.AspNetCore.Mvc;
using ProductsCatalog.Data;
using ProductsCatalog.Models;

namespace ProductsCatalog.Controllers{
    [ApiController]
    
    public class HomeController : ControllerBase {
       
        [HttpGet("/get")]        
        public List<ProductModel> Get( [FromServices] AppDbContext context ){
            return context.Product.ToList();
        }

        [HttpPost("/post")]        
        public ProductModel Post( 
            [FromBody]ProductModel Product, 
            [FromServices] AppDbContext context ){
                
            context.Product.Add(Product);
            context.SaveChanges();
            return Product;
        }
    }
}