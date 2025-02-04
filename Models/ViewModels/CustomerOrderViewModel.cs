namespace MVC_Basic_Practical.Models.ViewModels
{
    //View Modeli:
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
