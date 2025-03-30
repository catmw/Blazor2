
using L00172691_BlazorServer.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00172691_BlazorServer.DataAccess.Repository
{
    public interface IProductRepo : IRepository<Product>
    {
        public void Update(Product product);
        Product GetProductCategory(int id);
    }
}
