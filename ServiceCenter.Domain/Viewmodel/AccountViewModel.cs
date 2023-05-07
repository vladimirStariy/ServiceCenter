using System.ComponentModel.DataAnnotations;

namespace ServiceCenter.Domain.Viewmodel
{
    public class AccountViewModel
    {
        [Display(Name = "name")]
        public string Employee_name { get; set; }
    }
}
