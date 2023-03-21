using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Repository
{
    public interface IUserIdRepository<TKey>
    {
        Task<int> GetUserId(string item);
    }
}
