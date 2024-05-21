public class UserInfo
{
    // Propiedades auto-implementadas
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }

    // Constructor con parámetros
    public UserInfo(string nombre, int edad, string email, string direccion)
    {
        Nombre = nombre;
        Edad = edad;
        Email = email;
        Direccion = direccion;
    }

    // Método para mostrar información del usuario
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Dirección: {Direccion}");
    }
}
