namespace Assignment22.Entity
{
    class Decano(string nombre, string correo, string contrasena, string facultad)
        : Usuario(nombre, correo, contrasena)
    {
        private string Facultad { get; set; } = facultad;

        public void AsignarProfesor(string profesor, string curso)
        {
            Console.WriteLine($"[Coordinador] {Nombre} asignó a {profesor} para impartir '{curso}'");
        }

        public void GenerarReporte()
        {
            Console.WriteLine($"[Coordinador] {Nombre} generó un reporte del departamento: {Facultad}");
        }
    }
}