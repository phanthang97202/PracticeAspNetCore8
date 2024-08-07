using PracticeDI.Models;

namespace PracticeDI.Interfaces
{
    public interface IProductRepository
    {
        public List<Product> GetAllProduct();
        public Product GetProductById(string id);
    }
}
