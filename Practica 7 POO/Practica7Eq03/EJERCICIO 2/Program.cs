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
        empleado.AgregarLavadora(lavadora1.Marca, lavadora1.Modelo, lavadora1.NumSerie, lavadora1.KgMax, lavadora1.Costo, lavadora1.Dimensiones, lavadora1.Color);
        empleado.AgregarLavadora(lavadora2.Marca, lavadora2.Modelo, lavadora2.NumSerie, lavadora2.KgMax, lavadora2.Costo, lavadora2.Dimensiones, lavadora2.Color);
        empleado.AgregarLavadora(lavadora3.Marca, lavadora3.Modelo, lavadora3.NumSerie, lavadora3.KgMax, lavadora3.Costo, lavadora3.Dimensiones, lavadora3.Color);
        empleado.AgregarTelevisor(televisor1.Marca, televisor1.Modelo, televisor1.NumSerie, televisor1.Pulgadas, televisor1.Resolucion, televisor1.Costo);
        empleado.AgregarTelevisor(televisor2.Marca, televisor2.Modelo, televisor2.NumSerie, televisor2.Pulgadas, televisor2.Resolucion, televisor2.Costo);
        empleado.AgregarTelevisor(televisor3.Marca, televisor3.Modelo, televisor3.NumSerie, televisor3.Pulgadas, televisor3.Resolucion, televisor3.Costo);

        IniciarSesion(listaEmpleados);
    }

    public static void IniciarSesion(List<Empleado> listaEmpleados) {
        Console.WriteLine("****Para fines prácticos los numeros de trabajador son: '1234' ó '5678' FIJATE BIEN EN EL AREA DEL TRABAJADOR UNO ES DE VENTAS Y EL OTRO DE COMPRAS*****");
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
            Console.WriteLine("\n-----MENU-----");
            Console.WriteLine("1. Agregar lavadora");
            Console.WriteLine("2. Agregar televisor");
            Console.WriteLine("3. Mostrar lista de lavadoras");
            Console.WriteLine("4. Mostrar lista de televisores");
            Console.WriteLine("5. Vender lavadora");
            Console.WriteLine("6. Vender televisor");
            Console.WriteLine("7. Salir");

            Console.WriteLine("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.WriteLine("Ingrese la marca de la lavadora:");
                    string marcaLavadora = Console.ReadLine();

                    Console.WriteLine("Ingrese el modelo de la lavadora:");
                    string modeloLavadora = Console.ReadLine();

                    Console.WriteLine("Ingrese el número de serie de la lavadora:");
                    string numSerieLavadora = Console.ReadLine();

                    Console.WriteLine("Ingrese los kilogramos máximos de la lavadora:");
                    double kgMaxLavadora = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el costo de la lavadora:");
                    double costoLavadora = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese las dimensiones de la lavadora:");
                    string dimensionesLavadora = Console.ReadLine();

                    Console.WriteLine("Ingrese el color de la lavadora:");
                    string colorLavadora = Console.ReadLine();

                    empleado.AgregarLavadora(marcaLavadora, modeloLavadora, numSerieLavadora, kgMaxLavadora, costoLavadora, dimensionesLavadora, colorLavadora);
                    Console.WriteLine("Se agregó la lavadora correctamente.");
                    break;

                case 2:
                    Console.WriteLine("Ingrese la marca del televisor:");
                    string marcaTelevisor = Console.ReadLine();

                    Console.WriteLine("Ingrese el modelo del televisor:");
                    string modeloTelevisor = Console.ReadLine();

                    Console.WriteLine("Ingrese el número de serie del televisor:");
                    string numSerieTelevisor = Console.ReadLine();

                    Console.WriteLine("Ingrese las pulgadas del televisor:");
                    double pulgadasTelevisor = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la resolución del televisor:");
                    string resolucionTelevisor = Console.ReadLine();

                    Console.WriteLine("Ingrese el costo del televisor:");
                    double costoTelevisor = Convert.ToDouble(Console.ReadLine());

                    empleado.AgregarTelevisor(marcaTelevisor, modeloTelevisor, numSerieTelevisor, pulgadasTelevisor, resolucionTelevisor, costoTelevisor);
                    Console.WriteLine("Se agregó el televisor correctamente.");
                    break;

                case 3:
                    Console.WriteLine("Lista de lavadoras:");
                    empleado.MostrarListaLavadoras();
                    break;

                case 4:
                    Console.WriteLine("Lista de televisores:");
                    empleado.MostrarListaTelevisores();
                    break;

                case 5:
                    Console.WriteLine("Ingrese el número de serie de la lavadora a vender:");
                    string numSerieLavadoraVender = Console.ReadLine();
                    empleado.VenderLavadora(numSerieLavadoraVender);
                    break;

                case 6:
                    Console.WriteLine("Ingrese el número de serie del televisor a vender:");
                    string numSerieTelevisorVender = Console.ReadLine();
                    empleado.VenderTelevisor(numSerieTelevisorVender);
                    break;

                case 7:
                    Console.WriteLine("Sesión finalizada.");
                    return;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
