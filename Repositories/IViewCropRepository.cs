using Crop_Deal_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Repository
{
    #region Declaration
    public interface IViewCropRepository
    {
        List<ViewCrop> ViewCrops();
    }
    #endregion
}
