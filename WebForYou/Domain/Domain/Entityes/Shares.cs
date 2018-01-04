using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes
{
    public class Shares
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SharesId { get; set; }

        [Display(Name = "Название акции")]
        [Required(ErrorMessage = "Пожалуйста, введите название акции")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "название не корректно")]
        public string SharesName { get; set; }

        [Display(Name = "описание акции")]
        [Required(ErrorMessage = "Пожалуйста, опишите суть акции")]
        [DataType(DataType.MultilineText)]
        public string SharesDescription { get; set; }

        [Display(Name = "Дата создания акции")]
        [Required]
        public DateTime ShareDateCreate { get; set; }

        [Display(Name = "картинка к акции")]
        [Required]
        public string PictureShares { get; set; }
    }
}
