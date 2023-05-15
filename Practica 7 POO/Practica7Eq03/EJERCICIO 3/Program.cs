using System;
using System.Collections.Generic;
class Program
{
    static List<Empleado> listaEmpleados = new List<Empleado>();

    static void Main(string[] args)
    {
        listaEmpleados.Add(new Cajero("Juan", "Pérez", 123, 1));
        listaEmpleados.Add(new Cajero("Ana", "García", 124, 2));
       listaEmpleados.Add(new Ejecutivo("María", "Gómez", "456", 3));

        while (true)
        {
            Console.WriteLine("Bienvenido al sistema bancario");
            Console.WriteLine("1. Cajero");
            Console.WriteLine("2. Ejecutivo");
            Console.WriteLine("3. Consultar empleados");
            Console.WriteLine("4. Total de comisiones");
            Console.WriteLine("5. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Bienvenido, cajero");
                    Console.WriteLine("1. Atender cliente");
                    Console.WriteLine("2. Realizar depósito");
                    Console.WriteLine("3. Realizar retiro");

                    int subOpcionCajero = int.Parse(Console.ReadLine());

                    switch (subOpcionCajero)
                    {
                        case 1:
                            Console.WriteLine(((Cajero)listaEmpleados[0]).AtenderCliente());
                            break;
                        case 2:
                            Console.WriteLine(((Cajero)listaEmpleados[0]).RealizarDeposito(123456, 1000));
                            break;
                        case 3:
                            Console.WriteLine(((Cajero)listaEmpleados[0]).RealizarRetiro(234567, 500));
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Bienvenido, ejecutivo");
                    Console.WriteLine("1. Abrir cuenta de débito");
                    Console.WriteLine("2. Abrir cuenta de crédito");
                    Console.WriteLine("3. Iniciar fondo de inversión");

                    int subOpcionEjecutivo = int.Parse(Console.ReadLine());

                    switch (subOpcionEjecutivo)
                    {
                        case 1:
                            Console.WriteLine(((Ejecutivo)listaEmpleados[2]).AbrirCuentaDebito(345678, 5000));
                            break;
                        case 2:
                            Console.WriteLine(((Ejecutivo)listaEmpleados[2]).AbrirCuentaCredito(456789, 10000));
                            break;
                        case 3:
                            Console.WriteLine(((Ejecutivo)listaEmpleados[2]).IniciarFondoInversion(567890, 50000));
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Lista de empleados:");

                    foreach (Empleado empleado in listaEmpleados)
                    {
                        Console.WriteLine("Nombre: " + empleado.nombre + ", Apellido: " + empleado.apellido + ", Número de trabajador: " + empleado.numTrabajador);
                    }
                    break;
                case 4:
                    float comisionesCajeros = 0;
                    float comisionesEjecutivos = 0;

                    foreach (Empleado empleado in listaEmpleados)
                    {
                        if (empleado is Cajero)
                        {
                            comisionesCajeros += ((Cajero)empleado).comisiones;
                        }
                        else if (empleado is Ejecutivo)
                        {
                            comisionesEjecutivos += ((Ejecutivo)empleado).comisiones;
                        }
                    }

                  Console.WriteLine("Comisiones totales de cajeros: " + comisionesCajeros);
Console.WriteLine("Comisiones totales de ejecutivos: " + comisionesEjecutivos);
                    break;
                case 5:
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}