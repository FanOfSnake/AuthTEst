
using System.ComponentModel.DataAnnotations;

namespace AuthTEst.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Год рождения")]
        public int Year{ get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage = "Пароль не совпадает")]
        [DataType(DataType.Password)]
        [Display(Name = "Подвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
