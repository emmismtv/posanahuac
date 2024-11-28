using Microsoft.AspNetCore.Mvc;
using PuntoVentaApp.Controllers;
using System;
using System.IO;

namespace PuntoVentaApp.Models;

public class Venta
{
    public Producto? Productos { get; set; }
    public int? ID { get; set; }
    public float? Total { get; set; }
    public float? Descuento { get; set; }
    public Usuario? Cliente { get; set; }
    public DateTime? Fecha { get; set; }
    public string? Status { get; set; }
    public string? FormaPago { get; set; }

    public void CrearVenta()
    {

    }
    public void EliminarVenta()
    {
        
    }

    public void ModificarVenta()
    {
    }

    public void CrearReporte()
    {
        Carrito carrito = new Carrito();
        string path = "ReporteVenta.txt";
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine("Ticket de Venta H&M México S.A. de C.V.");
            writer.WriteLine("----------------------------");
            foreach (var producto in Carrito.ObtenerCarrito())
            {
                writer.WriteLine($"{producto.Nombre} - Precio: ${producto.Precio}");
            }
            writer.WriteLine($"Fecha de Venta: {DateTime.Now}");
            writer.WriteLine($"Total Pagado: ${Carrito.CalcularSubtotal()}");
            writer.WriteLine($"IVA 16%: ${Carrito.CalcularIVA()}");
            writer.WriteLine("----------------------------\n");
        }
        Console.WriteLine("Reporte de venta generado exitosamente.");
    }
}
