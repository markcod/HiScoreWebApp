using HiScoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HiScoreWebApp.Controllers
{
    public class HiScoreController : Controller
    {
        private readonly HiScoreDBContext _context;

        public HiScoreController(HiScoreDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HiScore.OrderByDescending(a => a.Score).ToListAsync());
        }
    }
}
