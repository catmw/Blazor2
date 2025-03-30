using Microsoft.EntityFrameworkCore;
using  L00172691_BlazorServer.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace L00172691_BlazorServer.DataAccess.DataAccess
{
    public class AppDBContext :IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        


    }

}
