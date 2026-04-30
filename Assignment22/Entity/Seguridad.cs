namespace Assignment22.Entity
{
    class Seguridad(string nombre, int nivelBadge) : Persona(nombre)
    {
        private int NivelBadge { get; set; } = nivelBadge;

        public override void MostrarAcceso()
        {
            Console.WriteLine($"[Seguridad] {Nombre} (Badge nivel {NivelBadge}) — Acceso TOTAL a todas las áreas.");
        }
    }
}