using System;

public class Lavadora : Producto {
    public double KgMax { get; set; }
    public string Dimensiones { get; set; }
    public string Color { get; set; }

    public Lavadora(string marca, string modelo, string numSerie, double kgMax, double costo, string dimensiones, string color) : base(marca, modelo, numSerie, costo) {
        KgMax = kgMax;
        Dimensiones = dimensiones;
        Color = color;
    }

    public override void Informacion() {
        Console.WriteLine("Tipo de producto: Lavadora");
        Console.WriteLine(this.ToString());
        Console.WriteLine("Kilogramos máximos: " + KgMax);
        Console.WriteLine("Dimensiones: " + Dimensiones);
        Console.WriteLine("Color: " + Color);
    }
}