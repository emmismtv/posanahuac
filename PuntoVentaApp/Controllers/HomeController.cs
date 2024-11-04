using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor que inyecta el servicio de logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Acción principal que devuelve la vista de inicio
        public IActionResult Index()
        {
            try
            {
                Console.WriteLine("Hello, World!");
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al cargar la página de inicio.");
                return RedirectToAction("Error");
            }
        }

        // Acción que devuelve la vista de privacidad
        public IActionResult Privacy()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al cargar la página de privacidad.");
                return RedirectToAction("Error");
            }
        }

        // Acción que maneja errores y muestra una vista de error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier };
            return View(errorViewModel);
        }

        // Ejemplo de una nueva acción para mostrar detalles de un producto
        public IActionResult ProductDetails(int id)
        {
            try
            {
                // Lógica para obtener detalles de un producto por ID
                // var product = _productService.GetProductById(id); // Llama al servicio correspondiente
                // if (product == null) return NotFound();

                // return View(product);

                return View(); // Placeholder, sustituir con lógica real
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al cargar los detalles del producto con ID: {Id}", id);
                return RedirectToAction("Error");
            }
        }
    }
}
