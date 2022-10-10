using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBContext _appDbContext;
        public CinemasController(AppDBContext appDBContext)
        {
            _appDbContext = appDBContext;
        }
        public async Task<IActionResult> Index()
        {
            var cinemasList = await _appDbContext.Cinemas.ToListAsync();
            return View();
        }
    }
}
