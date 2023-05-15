using System;

public class Lavadora {
public string Marca { get; set; }
public string Modelo { get; set; }
public string NumSerie { get; set; }
public double KgMax { get; set; }
public double Costo { get; set; }
public string Dimensiones { get; set; }
public string Color { get; set; }

public Lavadora(string marca, string modelo, string numSerie, double kgMax, double costo, string dimensiones, string color) {
    Marca = marca;
    Modelo = modelo;
    NumSerie = numSerie;
    KgMax = kgMax;
    Costo = costo;
    Dimensiones = dimensiones;
    Color = color;
}

public override string ToString() {
    return "Marca: " + Marca + ", Modelo: " + Modelo + ", Número de serie: " + NumSerie + ", Kilogramos máximos: " + KgMax + ", Costo: " + Costo + ", Dimensiones: " + Dimensiones + ", Color: " + Color;
}
}