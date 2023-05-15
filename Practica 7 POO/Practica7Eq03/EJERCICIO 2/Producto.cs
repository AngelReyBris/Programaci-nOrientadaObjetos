using System;public abstract class Producto {
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string NumSerie { get; set; }
    public double Costo { get; set; }

    public Producto(string marca, string modelo, string numSerie, double costo) {
        Marca = marca;
        Modelo = modelo;
        NumSerie = numSerie;
        Costo = costo;
    }

    public abstract void Informacion();

    public override string ToString() {
        return "Marca: " + Marca + ", Modelo: " + Modelo + ", Número de serie: " + NumSerie + ", Costo: " + Costo;
    }
}