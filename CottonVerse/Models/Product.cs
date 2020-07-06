using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CottonVerse.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string MaterialInner { get; set; }
        public string MaterialOuter { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int StockOnHand { get; set; }
        public decimal Price { get; set; }
        public decimal ProfitMargin { get; set; }
    }
}
