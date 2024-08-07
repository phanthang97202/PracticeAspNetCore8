using PracticeDI.Interfaces;
using PracticeDI.Models;

namespace PracticeDI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = "1", Name = "Quan dui", Price = 50000, Description = "Mac mat vcc" }
            };
            _products = products;
        }

        public List<Product> GetAllProduct()
        {
            return _products;
        }

        public Product GetProductById(string id)
        {
            if (_products == null)
            {
                Product _product = new Product { Id = "", Description = "", Name = "", Price = 0 };
                return _product;
            }

            Product product = _products.Where(item => item.Id == id).FirstOrDefault();
            return product;

        }
    }
}
