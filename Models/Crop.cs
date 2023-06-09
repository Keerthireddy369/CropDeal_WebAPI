﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Models
{
    public partial class Crop
    {
        public Crop()
        {
            CropOnSales = new HashSet<CropOnSale>();
        }

        public int CropId { get; set; }
        public string CropName { get; set; }
        //public string cropimage { get; set; }

        [JsonIgnore]
        public virtual ICollection<CropOnSale> CropOnSales { get; set; }

       

    }
}
