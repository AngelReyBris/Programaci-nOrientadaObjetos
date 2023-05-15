using System;
using System.Collections.Generic;

public class Empleado {
    public int NumeroTrabajador { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Area { get; set; }
    private List<Producto> productos;

    public Empleado(int numeroTrabajador, string nombre, string apellido, string area) {
        NumeroTrabajador = numeroTrabajador;
        Nombre = nombre;
        Apellido = apellido;
        Area = area;
        productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto) {
        productos.Add(producto);
    }

    public void IniciarSesion() {
        Console.WriteLine("Iniciando sesión para el empleado " + Nombre + " " + Apellido + "...");
    }

    public void MostrarListaProductos() {
        foreach (Producto producto in productos) {
            producto.Informacion();
        }
    }

    public void VenderProducto(string numSerie) {
        Producto producto = productos.Find(p => p.NumSerie == numSerie);
        if (producto != null) {
            productos.Remove(producto);
            Console.WriteLine("Se vendió el producto con número de serie " + numSerie + " correctamente.");
        } else {
            Console.WriteLine("No se encontró ningún producto con el número de serie especificado.");
        }
    }
}