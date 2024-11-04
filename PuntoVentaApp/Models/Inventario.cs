namespace PuntoVentaApp.Models

public class Inventario
{
    public Producto Productos { get; set; }

    public Inventario(Producto productos)
    {
        Productos = productos;
    }
    
}