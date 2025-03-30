using L00172691_BlazorServer.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepo CategoryRepo {get;}
        
        void Save();

        IProductRepo ProductRepo { get;}
    }
}
