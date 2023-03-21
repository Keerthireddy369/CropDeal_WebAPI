using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Repository
{
    public interface ILogin<TEntity> where TEntity : class
    {
        Task<TEntity> Login(int id);

        Task Save();
    }
}
