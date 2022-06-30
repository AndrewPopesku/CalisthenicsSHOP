using CalisthenicsSHOP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CalisthenicsSHOP.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShopDbContext(serviceProvider.
                   GetRequiredService<DbContextOptions<ShopDbContext>>()))
            {
                if(context.Products.Any())
                {
                    return;
                }

                context.Products.AddRange(
                    new Product { Name = "Product 1", Price = 12.3M, Description = "description 1", Category = ProductCategoryEnum.Accessories },
                    new Product { Name = "Product 2", Price = 23.1M, Description = "description 2", Category = ProductCategoryEnum.Equipment },
                    new Product { Name = "Product 3", Price = 2.0M, Description = "description 3", Category = ProductCategoryEnum.Shoes },
                    new Product { Name = "Product 4", Price = 1.1M, Description = "description 4", Category = ProductCategoryEnum.Cloth }
                );

                context.SaveChanges();
            }
        }
    }
}
