using Assignment22.Interface;

namespace Assignment22
{
    class SistemaLogin : IAutenticable, IAuditable
    {
        // --- Métodos de IAutenticable ---
        public bool Autenticar(string usuario, string contrasena)
        {
            bool credencialesValidas = usuario == "admin" && contrasena == "1234";

            if (credencialesValidas)
            {
                Console.WriteLine($"[Auth] Acceso concedido para '{usuario}'.");
                RegistrarAcceso(usuario, DateTime.Now);
            }
            else
            {
                Console.WriteLine($"[Auth] Acceso denegado para '{usuario}'.");
                RegistrarFallo(usuario, "Credenciales incorrectas");
            }

            return credencialesValidas;
        }

        public void CerrarSesion(string usuario)
        {
            Console.WriteLine($"[Auth] '{usuario}' ha cerrado sesión.");
        }

        // --- Métodos de IAuditable ---
        public void RegistrarAcceso(string usuario, DateTime momento)
        {
            Console.WriteLine($"[Auditoría] Acceso exitoso — Usuario: '{usuario}' | Hora: {momento:HH:mm:ss}");
        }

        public void RegistrarFallo(string usuario, string motivo)
        {
            Console.WriteLine($"[Auditoría] Fallo de acceso — Usuario: '{usuario}' | Motivo: {motivo}");
        }
    }
}