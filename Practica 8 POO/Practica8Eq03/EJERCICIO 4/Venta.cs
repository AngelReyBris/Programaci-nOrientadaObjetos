namespace CineTeatroHermanosRodriguez
{
    class Venta
    {
        public Funcion Funcion { get; set; }
        public Cliente Cliente { get; set; }
        public int NumeroEntradas { get; set; }
        public int CostoTotal { get; set; }

        public Venta(Funcion funcion, Cliente cliente, int numeroEntradas, int costoTotal)
        {
            Funcion = funcion;
            Cliente = cliente;
            NumeroEntradas = numeroEntradas;
            CostoTotal = costoTotal;
        }
    }
}