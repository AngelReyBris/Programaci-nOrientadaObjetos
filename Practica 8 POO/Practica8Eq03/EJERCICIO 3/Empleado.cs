using System;
using System.Collections.Generic;

abstract class Empleado
{
    public string nombre;
    public string apellido;
    public int numTrabajador;
    public static float totalComisiones;

    public Empleado(string nombre, string apellido, int numTrabajador)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.numTrabajador = numTrabajador;
    }

    public abstract void CalcularComisiones(float monto);
}