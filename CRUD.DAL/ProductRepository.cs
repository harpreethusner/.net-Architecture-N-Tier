using CRUD.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DAL
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;

        public ProductRepository(DapperContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            var sql = "SELECT * FROM Products";
            using var connection = _context.CreateConnection();
            return connection.Query<Product>(sql);
        }


        public Product GetProductById(int id)
        {
            var sql = "SELECT * FROM Products WHERE ProductId = @Id";
            using var connection = _context.CreateConnection();
            return connection.QueryFirstOrDefault<Product>(sql, new { Id = id });
        }

        public void AddProduct(Product product)
        {
            var sql = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";
            using IDbConnection connection = _context.CreateConnection();
            connection.Execute(sql, product);

        }

        public void DeleteProduct(int id)
        {
            var sql = "DELETE FROM Products WHERE ProductId = @Id";
            using var connection = _context.CreateConnection();
            connection.Execute(sql, new { Id = id });
        }


    }
}
