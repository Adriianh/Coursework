namespace Assignment22.Interface
{
    interface IAutenticable
    {
        bool Autenticar(string usuario, string contrasena);
        void CerrarSesion(string usuario);
    }
}