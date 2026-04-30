namespace Assignment22.Entity
{
    class Decano : Usuario
    {
        public string Facultad { get; set; }

        public Decano(string nombre, string correo, string contrasena, string facultad)
            : base(nombre, correo, contrasena)
        {
            Facultad = facultad;
        }

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