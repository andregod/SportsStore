using SportsStore.Models;

namespace SportsStore.Data
{
    public interface ISportsStoreRepository
    {
        public IEnumerable<Product> Products { get; }
    }
}
