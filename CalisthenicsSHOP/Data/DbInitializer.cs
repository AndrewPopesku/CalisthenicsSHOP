using CalisthenicsSHOP.Models;

namespace CalisthenicsSHOP.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShopDbContext context)
        {
            context.Database.EnsureCreated();

            if(context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product { Id = 1, Name = "Product 1", Price = 12.3M, Category = ProductCategoryEnum.Accessories },
                new Product { Id = 2, Name = "Product 2", Price = 23.5M, Category = ProductCategoryEnum.Equipment },
                new Product { Id = 3, Name = "Product 3", Price = 2.3M, Category = ProductCategoryEnum.Shoes },
                new Product { Id = 4, Name = "Product 4", Price = 1.1M, Category = ProductCategoryEnum.Cloth },
            };

            foreach(var p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }
    }
}
