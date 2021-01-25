using System.ComponentModel.DataAnnotations;

namespace NotesFE.Views.ViewModels.Account
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