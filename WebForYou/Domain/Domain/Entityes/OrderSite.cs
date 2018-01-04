using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entityes.Modules;

namespace Domain.Entityes
{
    public class OrderSite
    {
        [Key]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [Display(Name = "Имя Заказщика")]
        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Имя не корректно")]
        public string ClientName { get; set; }

        [Display(Name = "Дополнительная информация")]
        [Required(ErrorMessage = "Пожалуйста, опишите суть Вашего вопроса")]
        [DataType(DataType.MultilineText)]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Длина от 5 до 250 символов")]
        public string OrderDescription { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "пожалуйста оставьте Ваш E-mail")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string ClientEmail { get; set; }

        [Display(Name = "номер мобильного телефона")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Номер мобильного телефона не корректен!")]
        public string ClientPhone { get; set; }

        [Display(Name = "Дата заказа")]
        [Required]
        public DateTime OrderDateCreate { get; set; }

        [Display(Name = "тип заказа")]
        [Required]
        public string TypeOfOrder { get; set; } //типы заказа : общий, визитка, lending, корпоративный, каталог, магазин, портал

        [Display(Name = "Статус заказа")]
        [Required]
        public bool OrderStatus { get; set; }      //false - новый, true - выполненный
    }
}
