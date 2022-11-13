using Microsoft.AspNetCore.Mvc;
using vetClinic.Model;
using vetClinic.Model.SearchObjects;
using vetClinic.Services.Interfaces;

namespace vetClinic.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : BaseController<Model.User, BaseSearchObject>
    {
        public UsersController(IReadService<User, BaseSearchObject> service) : base(service)
        {
        }
    }
}
