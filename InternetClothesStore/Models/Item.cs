using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Item
    {
        public Item()
        {
            Images = new List<Image>();
            Purchases = new List<Purchase>();
            Sizes = new List<Size>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Sex Sex { get; set; }
        public ClothingType ClothingType { get; set; }
        public string Description { get; set; }
        public long Quantity { get; set; }
        public virtual List<Image> Images { get; set; }
        public  int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Purchase> Purchases{ get; set; }
        public virtual List<Size> Sizes{ get; set; }

    }

   
}