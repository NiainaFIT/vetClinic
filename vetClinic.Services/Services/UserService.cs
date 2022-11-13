using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Services.Database;
using vetClinic.Services.Interfaces;
using AutoMapper;
using vetClinic.Model.SearchObjects;
using vetClinic.Model.Requests;
using
using vetClinic.API.Security;

namespace vetClinic.Services.Services
{
    public class UserService : BaseCRUDService<Model.User, Database.User, BaseSearchObject, UserInsertRequest, UserUpdateRequest>, IUserService
    {
        public UserService(VetStationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<IEnumerable<Model.User>> Get(UserSearchObject search = null)
        {
            throw new NotImplementedException();
        }

        public override async Task<Model.User> Insert(UserInsertRequest request)
        {
            var entity = base.Insert(request)?.Result;
            
            foreach (var roleID in request.RoleIDs)
            {
                UserRole role = new UserRole();
                role.UserId = entity.UserId;
                role.RoleId = roleID;
                _context.UserRoles.Add(role);
            }
            await _context.SaveChangesAsync();
            return entity;
        }

        public override void BeforeInsert(UserInsertRequest insert, User entity)
        {
            var salt = entity.PasswordSalt = PasswordEncriptionHelper.GenerateSalt();
            entity.PasswordHash = PasswordEncriptionHelper.GenerateHash(salt, insert.Password);
            base.BeforeInsert(insert, entity);
        }
    }
}
