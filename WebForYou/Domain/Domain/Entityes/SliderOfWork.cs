using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes
{
   public class SliderOfWork
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SliderOfWorkId { get; set; }

        [Display(Name = "Имя слайда")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 25 символов")]
        public string SlideName { get; set; }

        [Display(Name = "Описание слайда")]
        [DataType(DataType.MultilineText)]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Длина описания от 3 до 250 символов")]
        public string SlideDescription { get; set; }

        [Display(Name = "Адрес сайта")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Пожалуйста, введите URL сайта")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина адреса от 3 до 50 символов")]
        public string SiteAdress { get; set; }

        [Display(Name = "Картинка слайда")]
        [Required]
        public string SlidePicture { get; set; }

        [Display(Name = "Номер салайда")]
        [Required(ErrorMessage = "Пожалуйста, укажите корректный номер слайда")]
        public int PrioritySlide { get; set; }

        [Display(Name = "Дата создания слайда")]
        [Required]
        public DateTime SlideDateCreate { get; set; }
    }
}
