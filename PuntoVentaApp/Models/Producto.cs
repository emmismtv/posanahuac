namespace PuntoVentaApp.Models;

public class Producto
{
    public string? Nombre { get; set; }
    public float? Precio { get; set; }
    public int? Cantidad { get; set; }
    public bool Disponible { get; set; }
    public int SKU { get; set; }
    public static List<Producto> listaProductos = new List<Producto>();

    public Producto()
    {

    }

    public Producto(string nombre, float precio, int cantidad, bool disponible, int sku)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
        Disponible = disponible;
        SKU = sku;
    }
    public static void GuardarProducto(Producto producto)
    {
        listaProductos.Add(producto);
        Console.WriteLine("Se guardo el producto correctametnte.");
        Console.WriteLine(listaProductos.Count);
    }
    
    public static void EliminarProducto(int sku)
    {
        var producto = listaProductos.FirstOrDefault(p => p.SKU == sku);
        if (producto != null)
        {
            listaProductos.Remove(producto);
        }
    }
    
    public static List<Producto> ObtenerProductos()
    {
        return listaProductos;
    }

}
