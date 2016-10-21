﻿using System;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public DateTime releaseDate { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public decimal starRating { get; set; }
        public string imageUrl { get; set; }
    }
}
