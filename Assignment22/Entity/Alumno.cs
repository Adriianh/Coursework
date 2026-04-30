namespace Assignment22.Entity
{
    class Alumno : Usuario
    {
        public string Carrera { get; set; }

        public Alumno(string nombre, string correo, string contrasena, string carrera)
            : base(nombre, correo, contrasena)
        {
            Carrera = carrera;
        }

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