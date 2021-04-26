using Microsoft.AspNetCore.Mvc;
using Proyecto_diars.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_diars.Controllers
{
    public class InicioController : Controller
    {
            private AppCartaContext context;
            public InicioController(AppCartaContext context)
            {
                this.context = context;
            }
            public IActionResult Index()
        {
            return View(context.cartas.ToList());
        }
        public IActionResult carta()
        {
            return View(context.cartas.ToList());
        }
    }
}
