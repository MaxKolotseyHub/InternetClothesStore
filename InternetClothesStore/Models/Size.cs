using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Size
    {
        public Size()
        {
            Items = new List<Item>();
        }
        public int Id { get; set; }
        public MySize MySize { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}