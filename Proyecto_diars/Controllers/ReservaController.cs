using Microsoft.AspNetCore.Mvc;
using Proyecto_diars.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Controllers
{
    public class ReservaController : Controller
    {
        private AppCartaContext context;
        public ReservaController(AppCartaContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.reservas.ToList());
        }
        public IActionResult detallepedido()
        {
            return View();
        }
    }
}
