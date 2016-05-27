using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    class ProductInitilizer : DropCreateDatabaseAlways<StoreContext>
    {
            protected override void Seed(StoreContext context)
            {
                var stores = new List<Store>()
            {
                new Store()
                {
                    Id = 1,
                    Name = "ICA Maxi",
                    Address = "MaxiGatan 10",
                    Products = "Mjölk,",
                },
                 new Store()
                {
                    Id =2,
                    Name = "Alfo Gross",
                    Address = "GA torget",
                    Products = "Vattenmelon",
                }
            };
                foreach (var store in stores)
                {
                    context.Stores.Add(store);
                }
                context.SaveChanges();

                var products = new List<Product>();
                products.Add(new Product() { Id = 1, Name = "Mjölk ", ProductText = "Färsk mjölk från skåne", ProductNumber = 10, Price = 10, ProductsInStock = 200 });
                products.Add(new Product() { Id = 2, Name = "Vattenmelon ", ProductText = "Närodlad svenskt vattemmelon", ProductNumber = 20, Price = 12 , ProductsInStock=50 });

                foreach (var product in products)
                {
                    context.Products.Add(product);
                }
                context.SaveChanges();

            }
        }
    }
