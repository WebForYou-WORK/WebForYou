﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes.Modules
{
    public class LandingCalc
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ModuleId { get; set; }

        [Display(Name = "Название мудуля")]
        [Required(ErrorMessage = "Пожалуйста, укажите название модуля")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 50 символов")]
        public string ModuleName { get; set; }

        [Display(Name = "Описание модуля")]
        [DataType(DataType.MultilineText)]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Длина описания от 3 до 250 символов")]
        public string ModuleDescription { get; set; }

        [Display(Name = "Стоимость модуля")]
        [Required(ErrorMessage = "Пожалуйста, укажите корректную стоимость модуля")]
        public int ModulePrice { get; set; }

        [Display(Name = "категория модуля")]
        [Required(ErrorMessage = "не выыбрана категория модуля")]
        public string ModuleCategory { get; set; }
    }
}
