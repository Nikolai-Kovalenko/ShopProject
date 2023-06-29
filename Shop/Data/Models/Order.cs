using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage ="Длинна имени не болше 25 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длинна фамилии не болше 25 символов")]
        public string surName { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длинна адреса не болше 25 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона ")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длинна номера не более 10 знаков")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длинна почты не болше 25 символов")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime createOrderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
