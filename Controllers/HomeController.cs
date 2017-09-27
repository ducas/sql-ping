using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlPingWeb.Models;

namespace SqlPingWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ping([FromServices] PingContext context)
        {
            context.Pings.Add(new Ping());
            context.SaveChanges();
            return NoContent();
        }
    }
}
