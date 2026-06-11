using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Pizza.Data.Models
{
    public class Order {

        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть ім'я")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина імені не повинна перевищувати 10 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина прізвища не повинна перевищувати 15 символів")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина адреси не повинна перевищувати 20 символів")]
        public string address { get; set; }

        [Display(Name = "Номер телефона")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина номера не повинна перевищувати 15 символів")]
        public string phone { get; set; }

        [Display(Name = "Електронна пошта")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина електронної пошти не повинна перевищувати 30 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
