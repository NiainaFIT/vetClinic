using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Model;
using vetClinic.Model.Requests;
using vetClinic.Model.SearchObjects;
using vetClinic.Services.Database;
using vetClinic.Services.Interfaces;

namespace vetClinic.Services.Services
{
    public class ProductService : BaseCRUDService<Model.Product, Database.Product, ProductSearchObject, ProductInsertRequest, ProductUpdateRequest>, IProductService
    {
        
        public ProductService(VetStationDbContext context, IMapper mapper)
        :base(context, mapper)
        {
        }

       public override IQueryable<Database.Product> AddFilter(IQueryable<Database.Product> query, ProductSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search?.ProductID.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.ProductId == search.ProductID);
                return filteredQuery;
            }

            if (!string.IsNullOrEmpty(search?.ProductName)){
                filteredQuery = filteredQuery.Where(x => x.ProductName.Contains(search.ProductName));  
            }

            if (!string.IsNullOrEmpty(search?.Code)){
                filteredQuery = filteredQuery.Where(x => x.Code == search.Code);
            }

            if (search?.Page.HasValue == true)
            {
                filteredQuery = filteredQuery.Take(search.PageSize.Value).Skip(search.Page.Value);  
            }
            return filteredQuery;
        }
        //public IEnumerable<Model.Product> Get()
        //{
        //    var result = _context.Products.ToList();

        //    return _mapper.Map<List<Model.Product>>(result);
        //}
    }
}
