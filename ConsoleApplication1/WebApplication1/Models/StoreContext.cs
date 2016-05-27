using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApplication1.Models
{
    class StoreContext : DbContext
    {
            public DbSet<Store> Stores { get; set; }
            public DbSet<Product> Products { get; set; }

            public StoreContext() : base("ProductEntity")
            {
                Database.SetInitializer<StoreContext>(new ProductInitilizer());
            }
        }
    }
