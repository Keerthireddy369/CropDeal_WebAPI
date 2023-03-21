using Crop_Deal_Web_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Services
{
    public class UserIdService
    {
        IUserIdRepository<int> _repo;
        public UserIdService(IUserIdRepository<int> repo)
        {
            _repo = repo;
        }
        public async Task<int> GetUserId(string item)
        {
            return await _repo.GetUserId(item);
        }
    }
}
