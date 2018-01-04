using System.ComponentModel.DataAnnotations;

namespace Domain.Entityes
{
     public class BlogPhoto
    {
        [Key]
        public int BlogPhotoId { get; set; }

        [Display(Name = "URL фото")]
        [Required]
        public string PhotoUrl { get; set; }
    }
}
