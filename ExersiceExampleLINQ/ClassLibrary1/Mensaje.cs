namespace DemoArraysLinq.Models
{
    public class Mensaje
    {
        // Propiedades
        public string Contenido { get; set; }
        public string Remitente { get; set; }
        public string Destinatario { get; set; }
        public DateTime FechaEnvio { get; set; }

        // Constructor
        public Mensaje()
        {
            // Constructor por defecto
        }

        // Constructor con parámetros
        public Mensaje(string contenido, string remitente, string destinatario, DateTime fechaEnvio)
        {
            Contenido = contenido;
            Remitente = remitente;
            Destinatario = destinatario;
            FechaEnvio = fechaEnvio;
        }

        // Método
        public void MostrarMensaje()
        {
            Console.WriteLine($"De: {Remitente}");
            Console.WriteLine($"Para: {Destinatario}");
            Console.WriteLine($"Fecha de Envío: {FechaEnvio}");
            Console.WriteLine($"Mensaje: {Contenido}");
        }
    }
}
