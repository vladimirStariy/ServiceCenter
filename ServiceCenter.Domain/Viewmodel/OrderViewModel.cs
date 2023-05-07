using System.ComponentModel.DataAnnotations;

namespace ServiceCenter.Domain.Viewmodel
{
    public class OrderViewModel
    {
        [Display(Name = "№")]
        public uint Order_ID { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
        [Display(Name = "Дата заказа")]
        public DateTime Order_date { get; set; }
        [Display(Name = "Дата исполнения")]
        public DateTime Order_close_date { get; set; }
        [Display(Name = "Ответственный")]
        public string Employee_name { get; set; }
    }
}
