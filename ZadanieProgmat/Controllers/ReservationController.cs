using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZadanieProgmat.Data;
using ZadanieProgmat.Models;

namespace ZadanieProgmat.Controllers
{
    public class ReservationController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            return _context.reservations != null ?
                          View(await _context.reservations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.reservations'  is null.");
        }
        // GET: Book/Create
        public async Task<IActionResult> Create(int id)
        {
            var _user = await _userManager.GetUserAsync(User);
            var userId = _user.Id;

            var reserve = new Reservation()
            {
                BookId = id,
                Id = userId,
                DateTime = DateTime.Now
            };
            _context.Add(reserve);
            await _context.SaveChangesAsync();
            return RedirectToAction(controllerName: "Book", actionName: "Index");
        }

        
        
    }
}
