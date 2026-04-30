namespace Assignment22.Entity
{
    class Visitante(string nombre, string empresa) : Persona(nombre)
    {
        private string Empresa { get; set; } = empresa;

        public override void MostrarAcceso()
        {
            Console.WriteLine($"[Visitante] {Nombre} (de {Empresa}) — Acceso SOLO a recepción y sala de juntas.");
        }
    }
}