using Microsoft.EntityFrameworkCore;

namespace Cosmic_Electronics_Project.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Acer Laptop",
                        Description = "Acer Laptop Windows 11",
                        Category = "Computers",
                        Price = 1599,
                        Image = "product1.png"
                    },
                    new Product
                    {
                        Name = "MSI Laptop",
                        Description = "MSI Laptop Windows 11",
                        Category = "Computers",
                        Price = 1949,
                        Image = "product2.png"
                    },
                    new Product
                    {
                        Name = "Microsoft Surface Pro",
                        Description = "Surface tablet",
                        Category = "Computers",
                        Price = 2199,
                        Image = "product3.png"
                    },
                    new Product
                    {
                        Name = "Sumsung TV",
                        Description = "Samsung OLED TV",
                        Category = "Television",
                        Price = 3295,
                        Image = "product4.png"
                    },
                    new Product
                    {
                        Name = "LG TV",
                        Description = "LG OLED TV",
                        Category = "Television",
                        Price = 3045,
                        Image = "product5.png"
                    },
                    new Product
                    {
                        Name = "XBOX Wireless Controller",
                        Description = "XBOX Wireless Controller",
                        Category = "Gaming",
                        Price = 499,
                        Image = "product6.png"
                    },
                    new Product
                    {
                        Name = "Samsung S23 Ultra",
                        Description = "Samsung S23 Ultra mobile phone",
                        Category = "Mobiles",
                        Price = 1949,
                        Image = "product7.png"
                    },
                    new Product
                    {
                        Name = "Apple AirPods",
                        Description = "Apple AirPods Pro",
                        Category = "Mobiles",
                        Price = 339,
                        Image = "product8.png"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
