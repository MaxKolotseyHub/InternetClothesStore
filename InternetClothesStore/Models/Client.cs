using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Display(Name="Имя")]
        public string FirstName { get; set; }
        [Display(Name="Фамилия")]
        public string LastName { get; set; }
        [Display(Name="Адрес")]
        public string Address { get; set; }
        [Display(Name="Номер телефона")]
        public string PhoneNumber { get; set; }
        [Display(Name="Номер карты")]
        public string CardNumber { get; set; }
        [Display(Name="Срок действия карты")]
        public string CardDate { get; set; }
    }
}