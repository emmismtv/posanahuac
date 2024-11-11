using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers
{

    public class VentaControlador : Controller
    {

        public VentaControlador()
        {

        }

        public void CrearCarrito()
        {
            Carrito carrito = new Carrito();
            var producto1 = new Producto("Playera", 699, 3, true, 1);
            var producto2 = new Producto("Pantalon", 749, 2, true, 2);
            var producto3 = new Producto("Botas", 1299, 4, true, 3);
            carrito.AgregarProducto(producto1, 3);
            carrito.AgregarProducto(producto2, 2);
            carrito.AgregarProducto(producto3, 4);

            carrito.CrearPedido();
        }
    }
}


