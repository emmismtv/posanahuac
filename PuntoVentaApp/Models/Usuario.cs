namespace PuntoVentaApp.Models;

public class Usuario
{
    public int? ID  { get; set; }
    public string? Nombre  { get; set; }
    public string? Correo  { get; set; }

    public Usuario(string nombre, int id, string correo)
    {
        Nombre = nombre;
        Correo = correo;
        ID = id;
    }

    public void HistorialCompras() {}
    public void AgregarUsuario() {}
    public void EliminarUsuario() {}
    public void ModificarUsuario() {}
    public void CuponesDisponibles() {}
}
