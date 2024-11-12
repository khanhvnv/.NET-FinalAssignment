using System;

namespace CategoryApi.Models;

public class Product
{
        public int Id { get; set; }
        public string ? Name { get; set; }
        public decimal Price { get; set; }
        public string ? Images { get; set; }
        public int CategoryId { get; set; }
}
