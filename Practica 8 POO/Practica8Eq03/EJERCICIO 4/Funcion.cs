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

    public abstract void MostrarInformacion();
}

    class Pelicula : Funcion
{
    public string Sala { get; set; }

    public Pelicula(string nombre, string sala, string horario, int costo) : base(nombre, horario, costo, 100)
    {
        Sala = sala;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("- " + Nombre + " (" + Sala + ", " + Horario + ") - Costo: " + Costo + " pesos por persona");
    }
}
class ObraTeatro : Funcion
{
    public string Escenario { get; set; }
    public string Elenco { get; set; }
    public string Director { get; set; }

    public ObraTeatro(string nombre, string elenco, string director, string escenario, string horario, int costo) : base(nombre, horario, costo, 80)
    {
        Escenario = escenario;
        Elenco = elenco;
        Director = director;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("- " + Nombre + " (" + Escenario + ", " + Horario + ") - Costo: " + Costo + " pesos por persona");
    }
}
    }
