namespace PuntoVentaApp.Models;

public class Inventario
{
    public Producto? Producto { get; set; }
    

    public Inventario(Producto producto)
    {
        Producto = producto;

    }

} 
