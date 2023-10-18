using Microsoft.AspNetCore.Mvc;
using SportsStore.Data;

namespace SportsStore.Controllers
{
    public class ProductsController : Controller
    {
        private ISportsStoreRepository _repository;
        public ProductsController(ISportsStoreRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Products);
        }
    }
}