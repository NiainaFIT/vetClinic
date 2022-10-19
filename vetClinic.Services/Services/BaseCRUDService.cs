using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Model.SearchObjects;
using vetClinic.Services.Database;
using vetClinic.Services.Interfaces;

namespace vetClinic.Services.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate>
         where T : class where TDb : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(VetStationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<T> Insert(TInsert insert)
        {
            var set = _context.Set<TDb>();
            TDb entity = _mapper.Map<TDb>(insert);
            set.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }

        public async Task<T> Update(int id, TUpdate update)
        {
            var set = _context.Set<TDb>();
            var entity = await set.FindAsync(id);

            if(entity != null)
            {
                _mapper.Map(update, entity);
            }
            else
            {
                return null;
            }
            
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }
    }
}
