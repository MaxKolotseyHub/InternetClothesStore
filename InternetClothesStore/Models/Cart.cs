using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class MyCart
    {
        private static MyCart Instance;
        public static MyCart GetInstance()
        {
            if (Instance == null)
                Instance = new MyCart();
            return Instance;
        }

        public List<Item> Cart { get; set; } = new List<Item>();
    }
}