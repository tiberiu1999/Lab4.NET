using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/products")]
  public class ProductsController : ControllerBase
  {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
               _context=context;
        }

    [HttpGet] 

    
    public ActionResult<IEnumerable<Product>> Get(){
            return this._context.Products.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        return _context.Products.Find(id);
    } 

    [HttpGet("validOrNot")]
    public ActionResult<List<Product>> ValidOrNot()
    {
          List<Product> validProducts = new List<Product>();
          foreach (var Product in _context.Products)
          {
            if(DateTime.Compare(DateTime.Now, Product.ValidTo) <0)
            {
              validProducts.Add(Product);
            }
          }
          return validProducts;
    }
    [HttpGet("allSum")]
    public ActionResult<double> GetSum(){
      double sum=0;
      foreach(var Product in _context.Products)
      {
        sum += Product.Price;
      }
      return sum;
    }

    public ActionResult<double> ValidSum()
    {
          double sum=0;
          foreach (var Product in _context.Products)
          {
            
            if(DateTime.Compare(DateTime.Now, Product.ValidTo) <0)
            {
              sum += Product.Price;
            }
          }
          return sum;
    }
  }
}