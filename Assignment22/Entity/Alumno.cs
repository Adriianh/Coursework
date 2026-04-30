namespace Assignment22.Entity
{
    class Alumno(string nombre, string correo, string contrasena, string carrera)
        : Usuario(nombre, correo, contrasena)
    {
        private string Carrera { get; set; } = carrera;

        public void EntregarTarea(string tarea)
        {
            Console.WriteLine($"[Alumno] {Nombre} entregó la tarea: '{tarea}' (Carrera: {Carrera})");
        }

        public void VerCalificaciones()
        {
            Console.WriteLine($"[Alumno] {Nombre} está consultando sus calificaciones.");
        }
    }

}