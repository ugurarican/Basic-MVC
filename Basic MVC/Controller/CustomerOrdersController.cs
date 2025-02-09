using Microsoft.AspNetCore.Mvc;
using Basic_MVC.Model;
namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer{ Id = 1, FirstName="Ahmet", LastName="Yılmaz", Email="ahmet.yilmaz@example.com"};
           

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName="Laptop", Price= 15000m, Quantity=1 },
                new Order {Id=2, ProductName="Mouse",Price =500m, Quantity=2},
                new Order{Id=3, ProductName="Klavye", Price=1200m, Quantity=1 }
            };
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders,
            };


            return View(viewModel);
        }
    }
}
