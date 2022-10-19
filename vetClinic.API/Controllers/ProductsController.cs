using Microsoft.AspNetCore.Mvc;
using vetClinic.Services.Interfaces;
using vetClinic.Services.Services;
using vetClinic.Services.Database;
using vetClinic.Model.SearchObjects;
using vetClinic.Model.Requests;

namespace vetClinic.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : BaseCRUDController<Model.Product, ProductSearchObject, ProductInsertRequest, ProductUpdateRequest>
    {
        public ProductsController(IProductService productsService)
            :base(productsService)
        {
        }
    }
}
