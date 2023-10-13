using SportsStore.Models;

namespace SportsStore.Data
{
    public class FakeRepository : ISportsStoreRepository
    {
        public IEnumerable<Product> Products =>
            new List<Product>
            {
                new Product
                {
                    Name = "Football ball",
                    Price = 25
                },
                new Product
                {
                    Name = "Surfboard",
                    Price = 375
                },
                new Product
                {
                    Name = "Running shoes",
                    Price = 95
                }
            };
    }
}
