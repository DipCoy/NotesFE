using System.ComponentModel.DataAnnotations;

namespace Domain.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Login required")]
        public string Login { get; set; }
         
        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}