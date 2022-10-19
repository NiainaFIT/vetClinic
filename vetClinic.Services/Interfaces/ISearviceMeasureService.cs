using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vetClinic.Model.SearchObjects;
using vetClinic.Services.Services;

namespace vetClinic.Services.Interfaces
{
    public interface ISearviceMeasureService : ICRUDService<Model.ServiceMeasure,ServiceMeasureSearchObject, object, object>
    {
    }
}
