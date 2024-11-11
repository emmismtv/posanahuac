namespace PuntoVentaApp.Models;

public class Inventario
{
    public List<Producto> ListaProductos { get; set; } = new List<Producto>();
    public Producto? Productos { get; set; }
    public Inventario(Producto productos)
    {
        Productos = productos;
    }

    public void AgregarProducto()
    { 
            ListaProductos.Add(Productos);
    }

    public void EliminarProducto() { 

        ListaProductos.Remove(Productos);
    }
    
}