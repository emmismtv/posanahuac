using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers
{

    public class MostrarProductosController : Controller
    {

        public MostrarProductosController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            var productos = Producto.ObtenerProductos();
            Console.WriteLine($"Cantidad de productos: {productos.Count}");
            return View("~/Views/Home/MostrarProductos.cshtml", productos);
        }

        [HttpPost]
        public IActionResult Eliminar(int sku)
        {
            var producto = Producto.ObtenerProductos().FirstOrDefault(p => p.SKU == sku);
            Producto.EliminarProducto(sku);
            TempData["Mensaje"] = $"El producto '{producto.Nombre}' fue eliminado exitosamente.";
            return View("~/Views/Home/MostrarProductos.cshtml");
        }

    }
}


