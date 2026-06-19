using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizza.Data;
using System.Linq;

namespace Pizza.Controllers
{
    public class AdminOrderController : Controller
    {
        private readonly AppDBcontent db;

        public AdminOrderController(AppDBcontent context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var orders = db.Order
                .Include(o => o.orderDetails)
                .ThenInclude(d => d.food)
                .ToList();

            return View(orders);
        }
    }
}