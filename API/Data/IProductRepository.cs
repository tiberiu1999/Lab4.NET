using API.Entities;
using System.Collections.Generic;

namespace API.Data
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Remove(Product product);
        void Update(Product product);
    }
}