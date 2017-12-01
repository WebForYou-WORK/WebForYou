using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes
{
    public class Blog
    {
        [Key]
        [ScaffoldColumn(false)]
        public int NewsId { get; set; }

        [Display(Name = "Название новости")]
        [Required(ErrorMessage = "Пожалуйста, укажите название новости")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 50 символов")]
        public string NewsName { get; set; }

        [Display(Name = "Текст новости")]
        [Required(ErrorMessage = "Пожалуйста, ну хоть что то напишите ! :)")]
        [DataType(DataType.MultilineText)]
        public string NewsDescription { get; set; }

        [Display(Name = "Основнкая картинка новости")]
        [Required]
        public string MainNewsPicture { get; set; }

        [Display(Name = "Картинка новости 1")]
        public string NewsPictureOne { get; set; }

        [Display(Name = "Картинка новости 2")]
        public string NewsPictureTwo { get; set; }

        [Display(Name = "Картинка новости 3")]
        public string NewsPictureThree { get; set; }

        [Display(Name = "Картинка новости 4")]
        public string NewsPictureFour { get; set; }

        [Display(Name = "Категория новости")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию модуля")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 25 символов")]
        public string NewsCategory { get; set; }

        [Display(Name = "Дата публикации новости")]
        [Required]
        public DateTime SlideDateCreate { get; set; }
    }
}
