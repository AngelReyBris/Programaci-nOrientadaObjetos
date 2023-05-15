using System;

public class Televisor : Producto {
    public double Pulgadas { get; set; }
    public string Resolucion { get; set; }

    public Televisor(string marca, string modelo, string numSerie, double pulgadas, string resolucion, double costo) : base(marca, modelo, numSerie, costo) {
        Pulgadas = pulgadas;
        Resolucion = resolucion;
    }

    public override void Informacion() {
        Console.WriteLine("Tipo de producto: Televisor");
        Console.WriteLine(this.ToString());
        Console.WriteLine("Pulgadas: " + Pulgadas);
        Console.WriteLine("Resolución: " + Resolucion);
    }
}