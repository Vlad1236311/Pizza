using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Pizza.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть ім'я")]
        [StringLength(10)]
        [Required(ErrorMessage = "Ім'я обов'язкове")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(15)]
        [Required(ErrorMessage = "Прізвище обов'язкове")]
        public string surname { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(15)]
        [Required(ErrorMessage = "Телефон обов'язковий")]
        public string phone { get; set; }

        [Display(Name = "Електронна пошта")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Email обов'язковий")]
        public string email { get; set; }

        // 🟢 ДАШ СИСТЕМА ДЕТАЛЬНОЇ АДРЕСИ
        [Display(Name = "Місто")]
        [StringLength(20)]
        public string city { get; set; }

        [Display(Name = "Вулиця")]
        [StringLength(30)]
        public string street { get; set; }

        [Display(Name = "Будинок")]
        [StringLength(10)]
        public string house { get; set; }

        [Display(Name = "Під'їзд")]
        [StringLength(10)]
        public string entrance { get; set; }

        [Display(Name = "Поверх")]
        [StringLength(10)]
        public string floor { get; set; }

        [Display(Name = "Квартира")]
        [StringLength(10)]
        public string flat { get; set; }

        public string deliveryTime { get; set; }

        public string paymentMethod { get; set; }

        public string comment { get; set; }

        public bool callMe { get; set; }

        public decimal cashChange { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}