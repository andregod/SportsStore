using SportsStore.Models;

namespace SportsStore.Data
{
    public class SportsStoreDatabaseRepository: ISportsStoreRepository
    {
        private SportsStoreDbContext _context;
        public SportsStoreDatabaseRepository(SportsStoreDbContext context) {
            _context = context;
        }

        public IEnumerable<Product> Products => _context.Products;
    }
}
