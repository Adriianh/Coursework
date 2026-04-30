namespace Assignment22.Entity
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Correo  { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string nombre, string correo, string contrasena)
        {
            Nombre     = nombre;
            Correo     = correo;
            Contrasena = contrasena;
        }

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