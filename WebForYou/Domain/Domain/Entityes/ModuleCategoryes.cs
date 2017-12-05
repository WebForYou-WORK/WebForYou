using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entityes
{
    public class ModuleCategoryes
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ModuleCategoryesId { get; set; }

        [Display(Name = "Категория мудуля")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию модуля")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 25 символов")]
        public string ModuleCategory { get; set; }
        public virtual ICollection<CalcSite> CalcSites { get; set; }
    }
}
