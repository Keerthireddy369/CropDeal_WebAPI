using Crop_Deal_Web_API.Models;
using Crop_Deal_Web_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Services
{
    public class CropViewService
    {
        private IViewCropRepository _repository;
        public CropViewService(IViewCropRepository repository)
        {
            _repository = repository;
        }
        #region viewcrops
        public List<ViewCrop> CropsView()
        {
            return _repository.ViewCrops();
        }
        #endregion
    }
}
