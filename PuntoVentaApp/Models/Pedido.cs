namespace PuntoVentaApp.Models;

public class Pedido
{
    public Producto? Producto { get; set; }
    public int? ID { get; set; }
    public float? Total { get; set; }
    public float? Descuento { get; set; }
    public Cliente? Cliente { get; set; }
    public DateTime? Fecha { get; set; }
    public string? Status { get; set; }
    public string? FormaPago { get; set; }

    public Pedido(Producto producto, int id, float total, float descuento, Cliente cliente, DateTime fecha, string status, string formaPago)
    {
        Producto = producto;
        ID = id;
        Total = total;
        Descuento = descuento;
        Cliente = cliente;
        Fecha = fecha;
        Status = status;
        FormaPago = formaPago;
    }

    public void CrearPedido()
    {
    }

    public void EliminarPedido()
    {
    }

    public void ModificarPedido()
    {
    }

}
