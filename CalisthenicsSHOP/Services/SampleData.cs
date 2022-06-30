using CalisthenicsSHOP.Models;

namespace CalisthenicsSHOP.Services
{
    public class SampleData
    {
        public List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 12.3M, Category = ProductCategoryEnum.Accessories },
            new Product { Id = 2, Name = "Product 2", Price = 23.5M, Category = ProductCategoryEnum.Equipment },
            new Product { Id = 3, Name = "Product 3", Price = 2.3M, Category = ProductCategoryEnum.Shoes },
            new Product { Id = 4, Name = "Product 4", Price = 1.1M, Category = ProductCategoryEnum.Cloth },
        };


        public List<Customer> Customers = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Peter", LastName = "Parker", Address = "New York", Discout = 25 },
            new Customer { Id = 2, FirstName = "Jon", LastName = "Snow", Address = "Wall", Discout = 50 },
            new Customer { Id = 3, FirstName = "Ilon", LastName = "Mask", Address = "California", Discout = 75 },
            new Customer { Id = 4, FirstName = "Volodymyr", LastName = "Zelensky", Address = "Kyiv", Discout = 90 },
        };
    }
}
