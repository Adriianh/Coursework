namespace Assignment22.Entity
{
    class Profesor : Usuario
    {
        public string Materia { get; set; }

        public Profesor(string nombre, string correo, string contrasena, string materia)
            : base(nombre, correo, contrasena)
        {
            Materia = materia;
        }

        public void PublicarMaterial(string material)
        {
            Console.WriteLine($"[Profesor] {Nombre} publicó material: '{material}' para {Materia}");
        }

        public void CalificarAlumno(string alumno, double nota)
        {
            Console.WriteLine($"[Profesor] {Nombre} calificó a {alumno} con {nota:F1} en {Materia}");
        }
    }
}