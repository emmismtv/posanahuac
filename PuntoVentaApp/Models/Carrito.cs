namespace PuntoVentaApp.Models;

public class Carrito
{
    public Producto? Producto { get; set; }
    public int? Cantidad { get; set; }
    public float? Total { get; set; }
    public List<(Producto producto, int cantidad)> ListaCarrito { get; set; } = new List<(Producto, int)>();

    public void AgregarProducto(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
        ListaCarrito.Add((producto, cantidad));
    }
    public void CrearPedido()
    {
        Venta venta = new Venta();
        Total = 0;
        Console.WriteLine("\nResumen de la Venta:");
        Console.WriteLine("----------------------------");
        foreach (var producto in ListaCarrito)
        {
            Console.WriteLine($"{producto.producto.Nombre} - Cantidad: {producto.cantidad}, Subtotal: ${producto.producto.Precio * producto.cantidad}");
            Total = (producto.producto.Precio * producto.cantidad) + Total;
        }
        Console.WriteLine($"Total a Pagar: ${Total}");
        Console.WriteLine("----------------------------");

        ListaCarrito.Clear();
        Total = 0;
        venta.CrearReporte();

    }
    public void EliminarProducto(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
        ListaCarrito.Remove((producto, cantidad));
    }
    public void EliminarCarrito()
    {
        ListaCarrito.Clear();
    }
}
