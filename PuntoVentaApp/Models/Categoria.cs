namespace PuntoVentaApp.Models;

public class Categoria
{

    public Producto? Productos { get; set; }
    public string? Imagen { get; set; }
    public string? Nombre { get; set; }

    public Categoria(Producto productos, string imagen, string nombre)
    {
        Productos = productos;
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
