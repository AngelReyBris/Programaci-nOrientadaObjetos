using System;
using System.Collections.Generic;
class Empleado
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

    public virtual void CalcularComisiones(float monto)
    {
        // Este método se implementará en las clases hijas
    }
}

