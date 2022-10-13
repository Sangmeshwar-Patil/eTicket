using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class MoviesController : Controller
    {

        private readonly AppDBContext _appDbContext;
        public MoviesController(AppDBContext appDBContext)
        {
            _appDbContext = appDBContext;
        }
        public async Task<IActionResult> Index()
        {
            var movieList = await _appDbContext.Movies.Include(a=>a.Cinemas).ToListAsync();
            return View(movieList);
        }
    }
}
