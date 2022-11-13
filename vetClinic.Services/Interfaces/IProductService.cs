using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Model;
using vetClinic.Model.Requests;
using vetClinic.Model.SearchObjects;
using vetClinic.Services.Services;

namespace vetClinic.Services.Interfaces
{
    public interface IProductService : ICRUDService<Product, ProductSearchObject, ProductInsertRequest, ProductUpdateRequest>, IReadService<Model.Product, ProductSearchObject>
    {

    }
}
