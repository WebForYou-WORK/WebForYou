using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes
{
    public class CalcSite
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ModuleId { get; set; }

        [Display(Name = "Название мудуля")]
        [Required(ErrorMessage = "Пожалуйста, укажите название модуля")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 25 символов")]
        public string ModuleName { get; set; }

        [Display(Name = "Описание модуля")]
        [DataType(DataType.MultilineText)]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Длина описания от 3 до 250 символов")]
        public string ModuleDescription { get; set; }

        [Display(Name = "Категория мудуля")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию модуля")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 25 символов")]
        public string ModuleCategory { get; set; }

        [Display(Name = "Стоимость модуля")]
        [Required(ErrorMessage = "Пожалуйста, укажите корректную стоимость модуля")]
        public int ModulePrice { get; set; }

        [Display(Name = "Дата создания слайда")]
        [Required]
        public DateTime SlideDateCreate { get; set; }
    }
}
