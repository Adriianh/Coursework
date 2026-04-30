namespace Assignment22.Entity
{
    class Persona(string nombre)
    {
        public string Nombre { get; set; } = nombre;

        public virtual void MostrarAcceso()
        {
            Console.WriteLine($"[Persona] {Nombre} — Sin nivel de acceso definido.");
        }
    }
}