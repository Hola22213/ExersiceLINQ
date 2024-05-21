using System;
using System.Collections.Generic;

namespace DemoArraysLinq.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cargar datos de usuarios
            List<UserInfo> usuarios = Data.Load();

            // Mostrar información de cada usuario
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInfo();
                Console.WriteLine(); // Agregar una línea en blanco entre cada usuario
            }
        }
    }

    public class Data
    {
        // Método Load para cargar datos
        public static List<UserInfo> Load()
        {
            // Aquí puedes simular la carga de datos desde una base de datos, un archivo, etc.
            // Por ahora, simplemente creamos una lista de UserInfo de ejemplo
            return new List<UserInfo>
            {
                new UserInfo("Juan", 30, "juan@example.com", "Calle 123"),
                new UserInfo("María", 25, "maria@example.com", "Avenida 456"),
                new UserInfo("Pedro", 35, "pedro@example.com", "Plaza 789")
            };
        }
    }

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
}
