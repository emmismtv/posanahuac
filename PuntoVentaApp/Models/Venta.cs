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

    public Venta(Producto productos, int id, float total, float descuento, Usuario cliente, DateTime fecha, string status, string formaPago)
    {
        Productos = productos;
        ID = id;
        Total = total;
        Descuento = descuento;
        Cliente = cliente;
        Fecha = fecha;
        Status = status;
        FormaPago = formaPago;
    }

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
    }

}
