using NortwindExample.Entities;
using System.Data.Entity;

namespace NortwindExample.Dal.Concrete.EntitiyFrameWork
{

    public class ExampleContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }


    }
}