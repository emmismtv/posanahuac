using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers
{

    public class CrearProductosController : Controller
    {

        public CrearProductosController()
        {

        }

        public IActionResult Index()
        {
            try
            {
                return View("~/Views/Home/CrearProductos.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Ocurrió un error al cargar la página de inicio.");
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public IActionResult CrearProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Action is running");
                Producto.GuardarProducto(producto);
                Producto.ObtenerProductos();
                TempData["Mensaje"] = $"El producto '{producto.Nombre}' fue agregado exitosamente.";
                return RedirectToAction("", "MostrarProductos");
            }

            return View(producto);
        }
    }
}


