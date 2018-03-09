using System;
using System.Collections.Generic;
using System.Text;

namespace CheckOut
{
    public class Product
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public string Category { get; set; }
        public bool IsVisible { get; set; }
    }
    public class ProductPair : Tuple<Product, Product>
    {
        public ProductPair(Product item1, Product item2)
            : base(item1, item2 ?? CreateEmptyModel()) { }

        private static Product CreateEmptyModel()
        {
            return new Product { IsVisible = false };
        }
    }
}

