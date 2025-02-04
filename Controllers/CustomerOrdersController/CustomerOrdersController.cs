using Microsoft.AspNetCore.Mvc;
using MVC_Basic_Practical.Models;
using MVC_Basic_Practical.Models.ViewModels;


namespace MVC_Basic_Practical.Controllers.CustomerOrdersController
{
    //Controller
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "John.Doe@outlook.com"
            };

            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    ProductName = "Laptop",
                    Quantity = 1,
                    Price = 1000
                },
                new Order
                {
                    Id = 2,
                    ProductName = "Mouse",
                    Quantity = 2,
                    Price = 20
                }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
