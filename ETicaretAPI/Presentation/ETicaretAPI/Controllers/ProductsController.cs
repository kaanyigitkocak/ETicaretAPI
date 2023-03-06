using ETicaretAPI.Application.Repositories.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    { 
        readonly IProductWriteRepository _productWriteRepository;
        readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id = 1, Name ="dsasd",Price=1000,CreatedDate=DateTime.UtcNow,Stock=10},
                new(){Id = 2, Name ="gkflgf",Price=132,CreatedDate=DateTime.UtcNow,Stock=32},
                new(){Id = 3, Name ="rieafid",Price=93,CreatedDate=DateTime.UtcNow,Stock=47},
            }) ;
            await _productWriteRepository.SaveAsync();
        }
    }
}
