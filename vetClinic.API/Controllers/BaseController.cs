using Microsoft.AspNetCore.Mvc;
using vetClinic.Services.Interfaces;
using vetClinic.Services.Services;

namespace vetClinic.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T, TSearch> : ControllerBase where T:class where TSearch : class
    {
       public IReadService<T, TSearch> _service { get; set; }

        public BaseController(IReadService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<T>> Get([FromQuery] TSearch search = null)
        {
            return await _service.Get(search);
        }
    }
}
