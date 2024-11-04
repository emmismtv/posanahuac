namespace PuntoVentaApp.Models;

public class Carrito
{
    public Producto? Producto { get; set; }
    public int? Cantidad { get; set; }
    public float? Total { get; set; }

    public void AgregarProducto() {}
    public void CrearPedido() {}
    public void EliminarProducto() {}
    public void Eliminarcarrito() {}
}
