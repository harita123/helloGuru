﻿namespace PGEcommerce.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set;}
        public DateTime CreatedDate { get; set;}
        public decimal? Price { get; set;}
    }
}
