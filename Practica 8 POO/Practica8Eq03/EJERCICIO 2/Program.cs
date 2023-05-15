using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        List<Empleado> listaEmpleados = new List<Empleado>();
        listaEmpleados.Add(new Empleado(1234, "Juan", "Pérez", "Ventas"));
        listaEmpleados.Add(new Empleado(5678, "María", "García", "Compras"));

        // Agregar algunos productos de ejemplo
        Lavadora lavadora1 = new Lavadora("LG", "WASH1", "1234", 10.5, 4000.0, "60x60x85cm", "Blanco");
        Lavadora lavadora2 = new Lavadora("Samsung", "ECO2", "5678", 8.0, 3500.0, "55x55x80cm", "Negro");
        Lavadora lavadora3 = new Lavadora("Mabe", "AQUA3", "9101", 12.0, 4500.0, "70x70x90cm", "Gris");
        Televisor televisor1 = new Televisor("Sony", "Bravia1", "2345", 55.0, "4K Ultra HD", 15000.0);
        Televisor televisor2 = new Televisor("Samsung", "QLED2", "6789", 65.0, "8K Ultra HD", 25000.0);
        Televisor televisor3 = new Televisor("LG", "NanoCell3", "1122", 49.0, "4K Ultra HD", 12000.0);

        Empleado empleado = listaEmpleados[0];
        empleado.AgregarProducto(lavadora1);
        empleado.AgregarProducto(lavadora2);
        empleado.AgregarProducto(lavadora3);
        empleado.AgregarProducto(televisor1);
        empleado.AgregarProducto(televisor2);
        empleado.AgregarProducto(televisor3);

        IniciarSesion(listaEmpleados);
    }

    public static void IniciarSesion(List<Empleado> listaEmpleados) {
        Console.WriteLine("****Para fines prácticos los numeros de trabajador son: '1234' ó '5678' FIJATE BIEN EN EL AREA DEL TRABAJADOR UNO ES DE VENTAS Y EL OTRO DE COMPRAS, SÓLO EL DE VENTAS PUEDE VENDER*****");
        Console.WriteLine("Ingrese su número de trabajador:");
        int numTrabajador = Convert.ToInt32(Console.ReadLine());

        Empleado empleado = listaEmpleados.Find(e => e.NumeroTrabajador == numTrabajador);

        if (empleado != null) {
            empleado.IniciarSesion();
            Console.WriteLine("Nombre: " + empleado.Nombre);
            Console.WriteLine("Apellido: " + empleado.Apellido);
            Console.WriteLine("Área: " + empleado.Area);

            MostrarMenu(empleado);
        } else {
            Console.WriteLine("No se encontró ningún empleado con el número de trabajador especificado.");
        }
    }

    public static void MostrarMenu(Empleado empleado) {
        while (true) {
            Console.WriteLine("----- Menú -----");
            Console.WriteLine("1. Mostrar lista de productos");
            Console.WriteLine("2. Vender producto");
            Console.WriteLine("3. Salir");

            Console.WriteLine("Ingrese una opción:");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) {
                case 1:
                    empleado.MostrarListaProductos();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de serie del producto a vender:");
                    string numSerie = Console.ReadLine();
                    empleado.VenderProducto(numSerie);
                    break;
                case 3:
                    Console.WriteLine("Sesión cerrada.");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}