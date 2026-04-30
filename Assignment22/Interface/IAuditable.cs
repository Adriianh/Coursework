namespace Assignment22.Interface
{
    interface IAuditable
    {
        void RegistrarAcceso(string usuario, DateTime momento);
        void RegistrarFallo(string usuario, string motivo);
    }
}