using System.ComponentModel.DataAnnotations;

namespace WebForYouUI.Infrastructure.Concrete
{
    public class AuthenticationModel
    {
        [Required(ErrorMessage = "Неверный логин")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Неверный пароль")]
        public string Password { get; set; }
    }
}