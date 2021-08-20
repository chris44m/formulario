using Microsoft.AspNetCore.Mvc;
using practica1.Models;

namespace practica1.Controllers
{
    public class VentaController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Vender(Venta objvender)
        {
            double subtotal=0;
            double total=0;
            double igv=1.18;

            subtotal =objvender.Cantidad*objvender.Precio;
            total = subtotal*igv;

            ViewData["Message"] = "El total es: "+ total;
            return View("Index");
        }
        
    }
}