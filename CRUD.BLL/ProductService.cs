using CRUD.DAL;
using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _repo.GetProductById(id);
        }

        public void AddProduct(Product product)
        {
            _repo.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _repo.DeleteProduct(id);
        }




    }
}
