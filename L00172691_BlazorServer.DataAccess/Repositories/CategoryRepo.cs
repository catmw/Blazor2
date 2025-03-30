using L00172691_BlazorServer.DataAccess.Repository;
using L00172691_BlazorServer.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00172691_BlazorServer.DataAccess.DataAccess
{
    public class CategoryRepo : Repository<Category>, ICategoryRepo
    {
        private readonly AppDBContext _dbContext;
        public CategoryRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveAll()
        {
            _dbContext.SaveChanges();
        }
    }
}
