using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApp.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalSum = await _context.Orders.SumAsync(o => o.Total);
            ViewBag.OrdersCount = await _context.Orders.CountAsync();
            
            var orders = await _context.Orders.Include(o => o.Client).ToListAsync();
            return View(orders);
        }
    }
}