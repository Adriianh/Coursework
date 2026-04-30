using Assignment22.Entity;

namespace Assignment22
{
    internal static class Program
    {
        private static void Main()
        {
            Separador("ESCENARIO 1 — Plataforma educativa con herencia jerárquica");

            // Objeto de la clase final Alumno: usa métodos heredados + propios
            Alumno alumno = new Alumno("Carlos López", "carlos@uni.edu", "pass123", "Ingeniería en Sistemas");
            alumno.IniciarSesion(); // heredado de Usuario
            alumno.EntregarTarea("Práctica 3 — Recursividad");
            alumno.VerCalificaciones();
            alumno.CerrarSesion(); // heredado de Usuario

            Console.WriteLine();

            Profesor profesor = new Profesor("Dra. Ana Pérez", "ana@uni.edu", "prof456",
                "Programación Orientada a Objetos");
            profesor.IniciarSesion(); // heredado de Usuario
            profesor.PublicarMaterial("Diapositivas Unidad 4 — Herencia");
            profesor.CalificarAlumno("Carlos López", 92.5);
            profesor.CerrarSesion(); // heredado de Usuario

            Console.WriteLine();

            Decano decano = new Decano("Lic. Mario Ramos", "mario@uni.edu", "coord789",
                "Ingeniería");
            decano.IniciarSesion(); // heredado de Usuario
            decano.AsignarProfesor("Dra. Ana Pérez", "POO Avanzado");
            decano.GenerarReporte();
            decano.CerrarSesion(); // heredado de Usuario

            // -------------------------------------------------------
            Separador("ESCENARIO 2 — Sistema de autenticación con interfaces");

            SistemaLogin login = new SistemaLogin();

            // Prueba con credenciales correctas
            login.Autenticar("admin", "1234");
            Console.WriteLine();

            // Prueba con credenciales incorrectas (activa auditoría de fallo)
            login.Autenticar("hackerx", "wrong");
            Console.WriteLine();

            // Cierre de sesión
            login.CerrarSesion("admin");

            // -------------------------------------------------------
            Separador("ESCENARIO 3 — Control de accesos con override");

            // Polimorfismo: el mismo método MostrarAcceso() se comporta diferente
            Persona[] personas =
            [
                new Empleado("Laura Gómez", "Recursos Humanos"),
                new Visitante("Roberto Díaz", "TechCorp S.A."),
                new Seguridad("Inspector Molina", 5),
                new Empleado("Sofía Méndez", "Desarrollo de Software"),
                new Visitante("Junta Directiva", "Corporativo Central")
            ];

            foreach (var p in personas)
            {
                p.MostrarAcceso(); // Cada objeto ejecuta su propia versión del método
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void Separador(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"  {titulo}");
            Console.WriteLine(new string('=', 60));
        }
    }
}