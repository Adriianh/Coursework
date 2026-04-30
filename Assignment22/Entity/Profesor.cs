namespace Assignment22.Entity
{
    class Profesor(string nombre, string correo, string contrasena, string materia)
        : Usuario(nombre, correo, contrasena)
    {
        private string Materia { get; set; } = materia;

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