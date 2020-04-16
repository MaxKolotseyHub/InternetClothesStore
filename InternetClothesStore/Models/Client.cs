using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CardNumber { get; set; }
        public string CardDate { get; set; }
    }
}