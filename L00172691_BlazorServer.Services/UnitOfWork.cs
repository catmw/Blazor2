using L00172691_BlazorServer.DataAccess.DataAccess;
using L00172691_BlazorServer.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _dbContext;
        public ICategoryRepo CategoryRepo{ get; private set; }

        public IProductRepo ProductRepo { get; private set; }
        public UnitOfWork(AppDBContext appDBContext)
        {
            _dbContext = appDBContext;
            CategoryRepo = new CategoryRepo(_dbContext);
            ProductRepo = new ProductRepo(_dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
