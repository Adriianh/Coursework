namespace Assignment22.Entity
{
    class Empleado(string nombre, string departamento) : Persona(nombre)
    {
        private string Departamento { get; set; } = departamento;

        public override void MostrarAcceso()
        {
            Console.WriteLine($"[Empleado] {Nombre} ({Departamento}) — Acceso a oficinas y áreas comunes.");
        }
    }
}