using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers
{

    public class VentaController : Controller
    {

        public VentaController()
        {

        }

        [HttpGet]
        public IActionResult Index()
        {
            var productos = Producto.ObtenerProductos();
            ViewBag.Carrito = Carrito.ObtenerCarrito();
            ViewBag.Subtotal = Carrito.CalcularSubtotal();
            ViewBag.IVA = Carrito.CalcularIVA();
            ViewBag.Total = Carrito.CalcularTotal();
            return View("~/Views/Home/Venta.cshtml", productos);
        }

        [HttpPost]
        public IActionResult AgregarAlCarrito(int sku, int cantidad)
        {
            // Busca el producto en la lista de productos disponibles
            var producto = Producto.ObtenerProductos().FirstOrDefault(p => p.SKU == sku);
            if (producto != null)
            {
                var item = new Carrito
                {
                    SKU = producto.SKU,
                    Nombre = producto.Nombre,
                    Precio = producto.Precio ?? 0, // Maneja nulos si es necesario
                    Cantidad = cantidad
                };

                Carrito.AgregarProducto(item);
                TempData["Mensaje"] = $"Se agregó {cantidad} de {producto.Nombre} al carrito.";

                producto.Cantidad -= cantidad;
            }
            else
            {
                TempData["Mensaje"] = "El producto no fue encontrado.";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EliminarDelCarrito(int cantidad, int sku)
        {
            var producto = Producto.ObtenerProductos().FirstOrDefault(p => p.SKU == sku);
            if (producto != null)
            {
                producto.Cantidad += cantidad;
                Carrito.EliminarProducto(sku);
            }
            else
            {
                TempData["Mensaje"] = "El producto no fue encontrado.";
            }

            return RedirectToAction("Index");

        }
        public IActionResult CrearReporte()
        {
            var venta = new Venta();
            venta.CrearReporte();

            string nombreArchivo = "ReporteVenta.txt";

            var rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo);

            if (!System.IO.File.Exists(rutaArchivo))
            {
                return NotFound("El archivo solicitado no existe.");
            }

            var bytesArchivo = System.IO.File.ReadAllBytes(rutaArchivo);
            var tipoContenido = "application/octet-stream";
            File(bytesArchivo, tipoContenido, nombreArchivo);

            return File(bytesArchivo, tipoContenido, nombreArchivo);
        }

        public IActionResult EliminarCarritoReporte()
        {
            Carrito.VaciarCarrito();
            System.IO.File.WriteAllText("ReporteVenta.txt", string.Empty);
            return RedirectToAction("Index");
        }

    }
}


