using System;
using System.Collections.Generic;

class Ejecutivo : Empleado
{
    public string numOficina;
    public float comisiones;

    public Ejecutivo(string nombre, string apellido, string numOficina, int numTrabajador) : base(nombre, apellido, numTrabajador)
    {
        this.numOficina = numOficina;
    }

    public override void CalcularComisiones(float monto)
    {
        this.comisiones += monto * 0.001f;
        Empleado.totalComisiones += this.comisiones;
    }


    public string AbrirCuentaDebito(int numCuentaCliente, float cantidad)
    {
        // Lógica para abrir una cuenta de débito
        CalcularComisiones(cantidad);
        return "Cuenta de débito abierta";
    }

    public string AbrirCuentaCredito(int numCuentaCliente, float cantidad)
    {
        // Lógica para abrir una cuenta de crédito
        CalcularComisiones(cantidad);
        return "Cuenta de crédito abierta";
    }

    public string IniciarFondoInversion(int numCuentaCliente, float cantidad)
    {
        // Lógica para iniciar un fondo de inversión
        CalcularComisiones(cantidad);
        return "Fondo de inversión iniciado";
    }
}