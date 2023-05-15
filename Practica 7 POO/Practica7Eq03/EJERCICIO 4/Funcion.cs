using System;

namespace CineTeatroHermanosRodriguez
{
    abstract class Funcion
    {
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public int Costo { get; set; }
        private int boletosDisponibles;

        public Funcion(string nombre, string horario, int costo, int boletosDisponibles)
        {
            Nombre = nombre;
            Horario = horario;
            Costo = costo;
            this.boletosDisponibles = boletosDisponibles;
        }

        public int CantidadBoletosDisponibles()
        {
            return boletosDisponibles;
        }

        public void VenderBoletos(int numeroBoletos)
        {
            boletosDisponibles -= numeroBoletos;
        }
    }

    class Pelicula : Funcion
    {
        public string Sala { get; set; }

        public Pelicula(string nombre, string sala, string horario, int costo) : base(nombre, horario, costo, 100)
        {
            Sala = sala;
        }
    }

    class ObraTeatro : Funcion
    {
        public string Actores { get; set; }
        public string Director { get; set; }
        public string Escenario { get; set; }

        public ObraTeatro(string nombre, string actores, string director, string escenario, string horario, int costo) : base(nombre, horario, costo, 50)
        {
            Actores = actores;
            Director = director;
            Escenario = escenario;
        }
    }
}