namespace PuntoVentaApp.Models;

public class Producto
{
    public string? Nombre { get; set; }
    public float? Precio { get; set; }
    public int? Cantidad { get; set; }
    public bool? Disponible { get; set; }
    public int? ID { get; set; }

    public Producto(string nombre, float precio, int cantidad, bool disponible, int id)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
        Disponible = disponible;
        ID = id;
    }

}
