namespace PuntoVentaApp.Models;

public class Categoria
{

    public Producto? Producto { get; set; }
    public string? Imagen { get; set; }
    public string? Nombre { get; set; }

    public Categoria(Producto producto, string imagen, string nombre)
    {
        Producto = producto;
        Imagen = imagen;
        Nombre = nombre;
    }

    public void AgregarCategoria()
    {
    }

    public void EliminarCategoria()
    {
    }

    public void ModificarCategoria()
    {
    }

}
