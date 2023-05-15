using System;
using System.Collections.Generic;
class Cajero : Empleado
{
    public int numVentanilla;
    public float comisiones;

    public Cajero(string nombre, string apellido, int numTrabajador, int numVentanilla) : base(nombre, apellido, numTrabajador)
    {
        this.numVentanilla = numVentanilla;
    }

    public override void CalcularComisiones(float monto)
    {
        this.comisiones += monto * 0.0001f;
        Empleado.totalComisiones += this.comisiones;
    }

    public string AtenderCliente()
    {
        // Lógica para atender al cliente
        return "Cliente atendido";
    }

    public string RealizarDeposito(int numCuentaCliente, float cantidad)
    {
        // Lógica para realizar un depósito
        CalcularComisiones(cantidad);
        return "Depósito realizado";
    }

    public string RealizarRetiro(int numCuentaCliente, float cantidad)
    {
        // Lógica para realizar un retiro
        CalcularComisiones(cantidad);
        return "Retiro realizado";
    }
}