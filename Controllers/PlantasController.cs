using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea1.Data;

namespace Tarea1.Controllers
{
    public class PlantasController : Controller
    {
        private readonly AppDbContext _ctx;
        public PlantasController(AppDbContext ctx) => _ctx = ctx;

        // GET: /Plantas
        public async Task<IActionResult> Index()
        {
            var lista = await _ctx.Plantas
                .OrderBy(p => p.Nombre)
                .ToListAsync();
            return View(lista);
        }

        // GET: /Plantas/Detalles/5
        public async Task<IActionResult> Detalles(int id)
        {
            var planta = await _ctx.Plantas.FindAsync(id);
            if (planta == null) return NotFound();
            return View(planta);
        }
    }
}
