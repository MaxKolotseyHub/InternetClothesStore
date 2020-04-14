using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Image
    {
        public Image()
        {
            Items = new List<Item>();
        }
        public virtual List<Item> Items { get; set; }
        public int Id { get; set; }
        public string Path { get; set; }
    }
}