using vetClinic.Model;
using vetClinic.Model.Requests;
using vetClinic.Model.SearchObjects;

namespace vetClinic.Services.Interfaces
{
    public interface IUserService : ICRUDService<User, UserSearchObject, UserInsertRequest, UserUpdateRequest>, IReadService<Model.User, UserSearchObject>
    {
    }
}
