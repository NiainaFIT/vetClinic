using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public partial class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public VetStationDbContext _context { get; set; }
        public IMapper _mapper { get; set; }

        public BaseReadService(VetStationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<IEnumerable<T>> Get(TSearch search)
        {
            var entity = _context.Set<TDb>().AsQueryable();

            entity = AddFilter(entity, search);

            if(search?.Page.HasValue == true && search.PageSize.HasValue == true)
            {

            }
            var dataList = await entity.ToListAsync();

            return _mapper.Map<IEnumerable<T>>(dataList);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

        public virtual async Task<T> GetById(int id)
        {
            var set = _context.Set<TDb>();
            var entity = await set.FindAsync(id);
            return _mapper.Map<T>(entity);
        }
    }
}
