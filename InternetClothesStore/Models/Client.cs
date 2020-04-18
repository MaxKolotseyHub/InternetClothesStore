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
        [Required]
        public string FirstName { get; set; }
        [Display(Name="Фамилия")]
        [Required]
        public string LastName { get; set; }
        [Display(Name="Адрес")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "Номер телефона")]
        [Required]
        [RegularExpression(@"(\+375\d{9})",ErrorMessage ="Неверный формат телефона. Введите так: +375ХХХХХХХХХ")]
        public string PhoneNumber { get; set; }
        [Display(Name="Номер карты")]
        [Required]
        [StringLength(16, ErrorMessage = "Должно быть 16 символов")]
        public string CardNumber { get; set; }
        [Display(Name="Срок действия карты")]
        [Required]
        [RegularExpression(@"(\d{2}\\\d{2})", ErrorMessage = "Введите в формате dd\\dd")]

        public string CardDate { get; set; }
    }
}