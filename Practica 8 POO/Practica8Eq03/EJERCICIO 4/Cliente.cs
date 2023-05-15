namespace CineTeatroHermanosRodriguez
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string NumeroCuentaPayPal { get; set; }

        public Cliente(string nombre, string apellido, string direccion, string numeroCuentaPayPal)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            NumeroCuentaPayPal = numeroCuentaPayPal;
        }
    }
}