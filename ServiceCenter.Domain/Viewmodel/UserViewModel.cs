using ServiceCenter.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace ServiceCenter.Domain.Viewmodel
{
    public class UserViewModel
    {
        [Display(Name = "Логин")]
        public string Login { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Display(Name = "Роль")]
        public Role Role { get; set; }
    }
}
