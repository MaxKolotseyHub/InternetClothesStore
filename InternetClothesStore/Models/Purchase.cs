using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Purchase
    {
        public Purchase()
        {
            Items = new List<Item>();
        }
        public int Id { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<Item> Items { get; set; }
        public DateTime PurchaseDateTime { get; set; }
    }
}