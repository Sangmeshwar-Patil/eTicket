using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDBContext _appDBContext;
        public ActorsController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public IActionResult Index()
        {
            var actorsList = _appDBContext.Actors.ToList();
            return new JsonResult(actorsList);
        }
    }
}
