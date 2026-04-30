namespace Assignment22.Entity
{
    class Coordinador : Usuario
    {
        public string Departamento { get; set; }

        public Coordinador(string nombre, string correo, string contrasena, string departamento)
            : base(nombre, correo, contrasena)
        {
            Departamento = departamento;
        }

        public void AsignarProfesor(string profesor, string curso)
        {
            Console.WriteLine($"[Coordinador] {Nombre} asignó a {profesor} para impartir '{curso}'");
        }

        public void GenerarReporte()
        {
            Console.WriteLine($"[Coordinador] {Nombre} generó un reporte del departamento: {Departamento}");
        }
    }
}