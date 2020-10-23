using API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Product product)
        {
            this.context.Add(product);
            this.context.SaveChanges();
        }

        public void Update(Product student)
        {
            this.context.Update(student);
            this.context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return this.context.Products.Find(id);
        }

        public void Remove(Product student)
        {
            this.context.Remove(student);
            this.context.SaveChanges();
        }


    }
}
