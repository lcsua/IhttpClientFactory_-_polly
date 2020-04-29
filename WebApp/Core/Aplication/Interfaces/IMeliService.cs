using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Core.Aplication.Interfaces
{
    public interface IMeliService
    {
        Task<ExpandoObject> GetMeliUser(long userId);
    }
}
