using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Image
    {
        public virtual Item Item { get; set; }
        public virtual int ItemId { get; set; }
        public int Id { get; set; }
        public string Path { get; set; }
    }
}