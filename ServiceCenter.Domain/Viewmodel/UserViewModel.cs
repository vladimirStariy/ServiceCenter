using System.ComponentModel.DataAnnotations;

namespace ServiceCenter.Domain.Viewmodel
{
    public class UserViewModel
    {
        [Display(Name = "№")]
        public uint User_ID { get; set; }
        [Display(Name = "Логин")]
        public string Login { get; set; }
        [Display(Name = "Роль")]
        public string Role { get; set; }
    }
}
