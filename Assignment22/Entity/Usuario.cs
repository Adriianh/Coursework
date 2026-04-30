namespace Assignment22.Entity
{
    class Usuario(string nombre, string correo, string contrasena)
    {
        public string Nombre { get; set; } = nombre;
        public string Correo  { get; set; } = correo;
        public string Contrasena { get; set; } = contrasena;

        public void IniciarSesion()
        {
            Console.WriteLine($"[Usuario] {Nombre} ha iniciado sesión con el correo: {Correo}");
        }

        public void CerrarSesion()
        {
            Console.WriteLine($"[Usuario] {Nombre} ha cerrado sesión.");
        }
    }

}