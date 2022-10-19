using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetClinic.Services.Interfaces
{
    public interface IService<T, TSearch> where T : class where TSearch : class
    {
        Task<IEnumerable<T>> Get(TSearch search = null);
    }
}
