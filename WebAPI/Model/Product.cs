﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Sku { get; set; }

        public float Price { get; set; }

        public float? DiscountPrice { get; set; }

        public bool IsActive { get; set; }

        public string ImageUrl { get; set; }

        public int ViewCount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
