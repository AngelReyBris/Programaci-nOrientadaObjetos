using System;
using System.Collections.Generic;

public class Empleado {
    public int NumeroTrabajador { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Area { get; set; }
    private List<Lavadora> listaLavadoras;
    private List<Televisor> listaTelevisores;

    public Empleado(int numTrabajador, string nombre, string apellido, string area) {
        NumeroTrabajador = numTrabajador;
        Nombre = nombre;
        Apellido = apellido;
        Area = area;
        listaLavadoras = new List<Lavadora>();
        listaTelevisores = new List<Televisor>();
    }

    public void IniciarSesion() {
        Console.WriteLine("Iniciando sesión de empleado...");
    }

    public void AgregarLavadora(string marca, string modelo, string numSerie, double kgMax, double costo, string dimensiones, string color) {
        Lavadora lavadora = new Lavadora(marca, modelo, numSerie, kgMax, costo, dimensiones, color);
        listaLavadoras.Add(lavadora);
    }

    public void AgregarTelevisor(string marca, string modelo, string numSerie, double pulgadas, string resolucion, double costo) {
        Televisor televisor = new Televisor(marca, modelo, numSerie, pulgadas, resolucion, costo);
        listaTelevisores.Add(televisor);
    }

    public void MostrarListaLavadoras() {
        foreach (Lavadora lavadora in listaLavadoras) {
            Console.WriteLine(lavadora);
        }
    }

    public void MostrarListaTelevisores() {
        foreach (Televisor televisor in listaTelevisores) {
            Console.WriteLine(televisor);
        }
    }

    public void VenderLavadora(string numSerie) {
        Lavadora lavadora = listaLavadoras.Find (e => e.NumSerie == numSerie);
     if (lavadora != null) {
        listaLavadoras.Remove(lavadora);
        Console.WriteLine("Se vendió la lavadora con número de serie " + numSerie + ".");
    } else {
        Console.WriteLine("No se encontró ninguna lavadora con el número de serie especificado.");
    }
}

public void VenderTelevisor(string numSerie) {
    Televisor televisor = listaTelevisores.Find(e => e.NumSerie == numSerie);

    if (televisor != null) {
        listaTelevisores.Remove(televisor);
        Console.WriteLine("Se vendió el televisor con número de serie " + numSerie + ".");
    } else {
        Console.WriteLine("No se encontró ningún televisor con el número de serie especificado.");
    }
}
}  