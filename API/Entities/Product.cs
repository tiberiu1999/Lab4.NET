using System;

namespace API.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string ProductName { get; set; }

    public double Price{get; set;}

    public DateTime ValidFrom{get; set;}

    public DateTime ValidTo{get; set;}
    
  }
}