using L00172691_BlazorServer.DataAccess.DataAccess;
using L00172691_BlazorServer.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00172691_BlazorServer.DataAccess.Repository
{
    public class ProductRepo : Repository<Product>, IProductRepo
    {
        private readonly AppDBContext _dbContext;

        public ProductRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Product product)
        {
            var prodFromDB = _dbContext.Products.
                FirstOrDefault(prodFromDB => prodFromDB.ID == product.ID);
            prodFromDB.Name = product.Name;
            prodFromDB.CategoryID = product.CategoryID;
            if (product.ImageName != null) 
            {
                prodFromDB.ImageName = product.ImageName;
            }
        }

        public Product GetProductCategory(int id)
        {
            try
            {
                var product = _dbContext.Products.Include(p => p.Category).FirstOrDefault(p => p.ID == id);
                if (product == null)
                {
                    Console.WriteLine($"Product with ID {id} not found.");
                }
                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred while retrieving product: {ex.Message}");
                throw;
            }
        }
    }
}
