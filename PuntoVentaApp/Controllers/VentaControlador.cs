using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Models;

namespace PuntoVentaApp.Controllers {

public class VentaControlador: Controller
{

        // Clase para Venta (Sencilla)
        private List<Producto> carrito;
        private float? total;

        public VentaControlador()
        {
            carrito = new List<Producto>();
            total = 0;
        }

        //Funcion para Agregar Productos al carrito (Sencillo)

        public void AgregarProductos() {

        var producto1 = new Producto("Playera",699 ,3, true, 1 );     
        var producto2 = new Producto("Pantalon", 749, 2, true, 2);   
        var producto3 = new Producto("Botas", 1299 ,4,true,3);   

        carrito.Add(producto1);
        carrito.Add(producto2);
        carrito.Add(producto3);
        }
        public void CrearPedido()
        {
            Console.WriteLine("\nResumen de la Venta:");
            Console.WriteLine("----------------------------");
            foreach (var producto in carrito)
            {
                Console.WriteLine($"{producto.Nombre} - Cantidad: {producto.Cantidad}, Subtotal: ${producto.Precio * producto.Cantidad}");
                total = (producto.Precio * producto.Cantidad) + total;
            }
            Console.WriteLine($"Total a Pagar: ${total}");
            Console.WriteLine("----------------------------");

            GenerarReporte();
            
            carrito.Clear();
            total = 0;
        }

        private void GenerarReporte()
        {
            string path = "ReporteVenta.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("Ticket de Venta H&M México S.A. de C.V.");
                writer.WriteLine("----------------------------");
                foreach (var producto in carrito)
                {
                    writer.WriteLine($"{producto.Nombre} - Cantidad: {producto.Cantidad}, Subtotal: {producto.Precio * producto.Cantidad:C}");
                }
                writer.WriteLine($"Total Pagado: ${total}");
                writer.WriteLine($"Fecha de Venta: {DateTime.Now}");
                writer.WriteLine("----------------------------\n");
            }
            Console.WriteLine("Reporte de venta generado exitosamente.");
        }
    }
}
  
   
