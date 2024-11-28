namespace PuntoVentaApp.Models;
public class Carrito
{
    private static List<Carrito> listaCarrito = new List<Carrito>();
    public int SKU { get; set; }
    public string Nombre { get; set; }
    public float Precio { get; set; }
    public int Cantidad { get; set; }

    public static void AgregarProducto(Carrito item)
    {
        var productoExistente = listaCarrito.FirstOrDefault(p => p.SKU == item.SKU);
        if (productoExistente != null)
        {
            productoExistente.Cantidad += item.Cantidad;
        }
        else
        {
            listaCarrito.Add(item);
        }
    }

    public static void EliminarProducto(int sku)
    {
        var producto = listaCarrito.FirstOrDefault(p => p.SKU == sku);
        if (producto != null)
        {
            listaCarrito.Remove(producto);
            
        }
    }

    public static List<Carrito> ObtenerCarrito()
    {
        return listaCarrito;
    }

    public static void VaciarCarrito() 
    {
        listaCarrito.Clear();
    }

    public static float CalcularSubtotal()
    {
        return listaCarrito.Sum(item => item.Precio * item.Cantidad);
    }

    public static float CalcularIVA()
    {
        return CalcularSubtotal() * 0.16f;
    }

    public static float CalcularTotal()
    {
        return CalcularSubtotal();
    }
}
