using Crop_Deal_Web_API.Models;
using Crop_Deal_Web_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewCropController : Controller
    {
        private readonly CropViewService _cropview;

        public ViewCropController(CropViewService cropview)
        {

            _cropview = cropview;

        }
        #region getcrops
        [Authorize(Roles = "Dealer")]

        [HttpGet]
        public List<ViewCrop> GetCrops()
        {
            return _cropview.CropsView();

        }
        #endregion
    }
}
