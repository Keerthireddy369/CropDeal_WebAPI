﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Models
{
    public partial class CropOnSale
    {
        [Key]
        public int CropSaleId { get; set; }
        public int? CropId { get; set; }
        public string CropName { get; set; }
        public string CropType { get; set; }
        public int CropQty { get; set; }
        public double CropPrice { get; set; }
        public int? FarmerId { get; set; }

        [JsonIgnore]
        public virtual Crop Crop { get; set; }
        [JsonIgnore]
        public virtual UserProfile Farmer { get; set; }


    }
}
