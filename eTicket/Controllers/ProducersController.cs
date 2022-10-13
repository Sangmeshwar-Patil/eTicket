using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBContext _appDbContext;
        public ProducersController(AppDBContext appDBContext)
        {
            _appDbContext = appDBContext;
        }

        public async Task<IActionResult> Index()
        {
            var producersList = await _appDbContext.Producers.ToListAsync();
            return View(producersList);
        }
    }
}
