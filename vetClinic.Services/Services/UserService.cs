using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Services.Database;
using vetClinic.Services.Interfaces;
using AutoMapper;
using vetClinic.Model.SearchObjects;

namespace vetClinic.Services.Services
{
    public class UserService : BaseCRUDService<Model.User, Database.User, BaseSearchObject, object, object>, IUserService
    {
        public UserService(VetStationDbContext context, IMapper mapper)
            :base(context, mapper)
        {
        }

        //public IEnumerable<Model.User> Get()
        //{
        //    List<Model.User> users = new List<Model.User>();
        //    var result = _context.Users.ToList();
        //    return _mapper.Map<List<Model.User>>(result);
        //}
    }
}
