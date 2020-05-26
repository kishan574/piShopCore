﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piShopCore.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThumbnaiUrl { get; set; }
        public bool IsPieOfWeek { get; set; }
        public bool IsInStock { get; set; }

    }
}

