using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var ventaControlador = new VentaControlador();
                ventaControlador.CrearPedido();
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al cargar la página de inicio.");
                return RedirectToAction("Error");
            }
        }

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

        public IActionResult Venta()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió un error al cargar la página de venta.");
                return RedirectToAction("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier };
            return View(errorViewModel);
        }
    }
}
