using System;
public class Televisor {
public string Marca { get; set; }
public string Modelo { get; set; }
public string NumSerie { get; set; }
public double Pulgadas { get; set; }
public string Resolucion { get; set; }
public double Costo { get; set; }

public Televisor(string marca, string modelo, string numSerie, double pulgadas, string resolucion, double costo) {
    Marca = marca;
    Modelo = modelo;
    NumSerie = numSerie;
    Pulgadas = pulgadas;
    Resolucion = resolucion;
    Costo = costo;
}

public override string ToString() {
    return "Marca: " + Marca + ", Modelo: " + Modelo + ", Número de serie: " + NumSerie + ", Pulgadas: " + Pulgadas + ", Resolución: " + Resolucion + ", Costo: " + Costo;
}
}