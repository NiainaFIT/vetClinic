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
    public class ServiceMeasureService : BaseCRUDService<Model.ServiceMeasure, Database.ServiceMeasure, ServiceMeasureSearchObject, object, object>, ISearviceMeasureService
    {
        public ServiceMeasureService(VetStationDbContext context, IMapper mapper):
            base(context, mapper)
        {    
        }

        public override IQueryable<Database.ServiceMeasure> AddFilter(IQueryable<Database.ServiceMeasure> query, ServiceMeasureSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);
            if (search?.ServiceMeasureID.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.ServiceMeasureId == search.ServiceMeasureID.Value);
            }

            return filteredQuery;
        }
    }
}
