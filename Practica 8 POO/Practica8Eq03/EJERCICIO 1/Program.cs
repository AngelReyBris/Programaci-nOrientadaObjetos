using System;
using System.Collections.Generic;

namespace ProyectoEnfermeras
{
    class Program
    {
        static List<Enfermera> enfermeras = new List<Enfermera>()
        {
            new Enfermera(1, "Ana", "García", "GARA900101", "Pediatría", "contrasena1"),
            new Enfermera(2, "Juan", "Pérez", "PEJU920202", "Oncología", "contrasena2"),
            new Enfermera(3, "María", "López", "LOMA850414", "Cirugía", "contrasena3")
        };

        static List<Paciente> pacientes = new List<Paciente>()
        {
            new Paciente(1, "Carlos", "Martínez", "MARC950101", "Av. Reforma #123", enfermeras[0]),
            new Paciente(2, "Laura", "González", "GOAL930202", "Calle 10 #456", enfermeras[1]),
            new Paciente(3, "Pedro", "Ramírez", "RAPD910303", "Paseo de la Reforma #789", enfermeras[2])
        };

        static void Main(string[] args)
        {
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("**** para ingresar como enfermera: numero de empleado: 1 contraseña: contrasena1 ; numero de empleado: 2 contraseña: contrasena2 ; numero de empleado: 3 contraseña: contrasena3 *****");
            Console.WriteLine("Bienvenido al sistema de enfermeras y pacientes");
            Console.WriteLine("1. Información de empleados/enfermeras");
            Console.WriteLine("2. Pacientes");
            Console.WriteLine("3. Inicio de sesión de enfermeras");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarMenuEmpleados();
                    break;
                case "2":
                    MostrarMenuPacientes();
                    break;
                case "3":
                    IniciarSesionEnfermera();
                    break;
                case "4":
                    Console.WriteLine("Gracias por utilizar el sistema");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            if (opcion != "4")
            {
                Console.WriteLine("Presione cualquier tecla para regresar al menú principal");
                Console.ReadKey();
                MostrarMenu();
            }
        }

        static void MostrarMenuEmpleados()
        {
            Console.Clear();
            Console.WriteLine("1. Registrar nueva enfermera");
            Console.WriteLine("2. Lista de enfermeras registradas");
            Console.WriteLine("3. Buscar enfermeras por área");
            Console.WriteLine("4. Regresar al menú principal");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarEnfermera();
                    break;
                case "2":
                    MostrarListaEnfermeras();
                    break;
                case "3":
                    BuscarEnfermerasPorArea();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }

        static void RegistrarEnfermera()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los siguientes datos de la nueva enfermera:");

            Console.Write("Número de empleado: ");
            int numeroEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("RFC: ");
            string rfc = Console.ReadLine();

            Console.Write("Área de atención: ");
            string area = Console.ReadLine();

            Console.Write("Contraseña: ");
            string contrasena = Console.ReadLine();

            Enfermera nuevaEnfermera = new Enfermera(numeroEmpleado, nombre, apellido, rfc, area, contrasena);
            enfermeras.Add(nuevaEnfermera);

            Console.WriteLine("Enfermera registrada exitosamente");
        }

        static void MostrarListaEnfermeras()
        {
            Console.Clear();
            Console.WriteLine("Lista de enfermeras registradas:");

            foreach (Enfermera enfermera in enfermeras)
            {
               Console.WriteLine("Número de empleado: " + enfermera.NumeroEmpleado);
Console.WriteLine("Nombre completo: " + enfermera.Nombre + " " + enfermera.Apellido);
Console.WriteLine("RFC: " + enfermera.RFC);
Console.WriteLine("Área de atención: " + enfermera.Area);
                Console.WriteLine();
            }
        }

        static void BuscarEnfermerasPorArea()
        {
            Console.Clear();
            Console.Write("Ingrese el área de atención: ");
            string area = Console.ReadLine();

           Console.WriteLine("Enfermeras que atienden en el área de " + area + ":");
            bool seEncontraronEnfermeras = false;

            foreach (Enfermera enfermera in enfermeras)
            {
                if (enfermera.Area == area)
                {
                   Console.WriteLine("Número de empleado: " + enfermera.NumeroEmpleado);
Console.WriteLine("Nombre completo: " + enfermera.Nombre + " " + enfermera.Apellido);
Console.WriteLine("RFC: " + enfermera.RFC);
                    Console.WriteLine();
                    seEncontraronEnfermeras = true;
                }
            }

            if (!seEncontraronEnfermeras)
            {
                Console.WriteLine("No se encontraron enfermeras que atiendan en esta área");
            }
        }

        static void MostrarMenuPacientes()
        {
            Console.Clear();
            Console.WriteLine("1. Registrar nuevo paciente");
            Console.WriteLine("2. Regresar al menú principal");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarPaciente();
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }

        static void RegistrarPaciente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los siguientes datos del nuevo paciente:");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("CURP: ");
            string curp = Console.ReadLine();

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            Random random = new Random();
            int numeroPaciente = random.Next(10000, 99999);

            Paciente nuevoPaciente = new Paciente(numeroPaciente, nombre, apellido, curp, direccion, enfermeras[random.Next(0, enfermeras.Count)]);
            pacientes.Add(nuevoPaciente);

            Console.WriteLine("Paciente registrado exitosamente con número de paciente " + numeroPaciente);
        }

        static void IniciarSesionEnfermera()
{
    Console.Clear();
    Console.Write("Ingrese su número de empleado: ");
    int numeroEmpleado = int.Parse(Console.ReadLine());

    Console.Write("Ingrese su contraseña: ");
    string contrasena = Console.ReadLine();

    Enfermera enfermera = enfermeras.Find(e => e.NumeroEmpleado == numeroEmpleado && e.Contrasena == contrasena);

    if (enfermera == null)
    {
        Console.WriteLine("Número de empleado o contraseña incorrectos");
        return;
    }

    Console.WriteLine("Bienvenido(a) " + enfermera.Nombre + " " + enfermera.Apellido);

    MostrarMenuEnfermera(enfermera);
}

static void MostrarMenuEnfermera(Enfermera enfermera)
{
    bool turnoIniciado = false;
    List<Paciente> pacientesAsignados = pacientes.FindAll(p => p.EnfermeraAsignada == enfermera);

    while (true)
    {
        Console.Clear();
       Console.WriteLine("Menú de opciones para la enfermera " + enfermera.Nombre + " " + enfermera.Apellido);
        Console.WriteLine("1. Iniciar turno");
        Console.WriteLine("2. Terminar turno");
        Console.WriteLine("3. Ver lista de pacientes asignados");
        Console.WriteLine("4. Atender paciente");
        Console.WriteLine("5. Escribir reporte");
        Console.WriteLine("6. Cerrar sesión");

        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                if (turnoIniciado)
                {
                    Console.WriteLine("Ya ha iniciado su turno");
                }
                else
                {
                    Console.WriteLine("Ha iniciado su turno");
                    turnoIniciado = true;
                }
                break;
            case "2":
                if (turnoIniciado)
                {
                    Console.WriteLine("Ha terminado su turno");
                    turnoIniciado = false;
                }
                else
                {
                    Console.WriteLine("Aún no ha iniciado su turno");
                }
                break;
            case "3":
                if (pacientesAsignados.Count == 0)
                {
                    Console.WriteLine("No tiene pacientes asignados");
                }
                else
                {
                    Console.WriteLine("Pacientes asignados:");

                    foreach (Paciente paciente in pacientesAsignados)
                    {
                        Console.WriteLine("Número de paciente: " + paciente.NumeroPaciente);
Console.WriteLine("Nombre completo: " + paciente.Nombre + " " + paciente.Apellido);
Console.WriteLine("CURP: " + paciente.CURP);
Console.WriteLine("Dirección: " + paciente.Direccion);
                        Console.WriteLine();
                    }
                }
                break;
            case "4":
                if (pacientesAsignados.Count == 0)
                {
                    Console.WriteLine("No tiene pacientes asignados");
                }
                else
                {
                    Console.WriteLine("Pacientes asignados:");

                    foreach (Paciente paciente in pacientesAsignados)
                    {
                        Console.WriteLine("Número de paciente: " + paciente.NumeroPaciente);
Console.WriteLine("Nombre completo: " + paciente.Nombre + " " + paciente.Apellido);
                        Console.WriteLine();
                    }

                    Console.Write("Seleccione el número de paciente que desea atender: ");
                    int numeroPaciente = int.Parse(Console.ReadLine());

                    Paciente pacienteSeleccionado = pacientesAsignados.Find(p => p.NumeroPaciente == numeroPaciente);

                    if (pacienteSeleccionado == null)
                    {
                        Console.WriteLine("Número de paciente incorrecto");
                    }
                    else
                    {
                        Console.WriteLine("Atendiendo a " + pacienteSeleccionado.Nombre + " " + pacienteSeleccionado.Apellido);
                        Console.WriteLine("Ingrese el diagnóstico del paciente:");
                        string diagnostico = Console.ReadLine();

                        if (string.IsNullOrEmpty(diagnostico))
                        {
                            Console.WriteLine("No se ha ingresado un diagnóstico válido");
                        }
                        else
                        {
                            pacienteSeleccionado.AsignarDiagnostico(diagnostico);
                            Console.WriteLine("Diagnóstico registrado correctamente");
                        }
                    }
                }
                break;
            case "5":
                if (pacientesAsignados.Count == 0)
                {
                    Console.WriteLine("No tiene pacientes asignados");
                }
                else
                {
                    Console.WriteLine("Pacientes asignados:");

                    foreach (Paciente paciente in pacientesAsignados)
                    {
                       Console.WriteLine("Número de paciente: " + paciente.NumeroPaciente);
Console.WriteLine("Nombre completo: " + paciente.Nombre + " " + paciente.Apellido);
                        Console.WriteLine();
                    }

                    Console.Write("Seleccione el número de paciente para el que desea escribir un reporte: ");
                    int numeroPaciente = int.Parse(Console.ReadLine());

                    Paciente pacienteSeleccionado = pacientesAsignados.Find(p => p.NumeroPaciente == numeroPaciente);

                    if (pacienteSeleccionado == null)
                    {
                        Console.WriteLine("Número de paciente incorrecto");
                    }
                    else
                    {
                        Console.WriteLine("Escribiendo reporte para " + pacienteSeleccionado.Nombre + " " + pacienteSeleccionado.Apellido);
                        Console.WriteLine("Ingrese el reporte:");
                        string reporte = Console.ReadLine();

                        if (string.IsNullOrEmpty(reporte))
                        {
                            Console.WriteLine("No se ha ingresado un reporte válido");
                        }
                        else
                        {
                            enfermera.EscribirReporte(pacienteSeleccionado, reporte);
                            Console.WriteLine("Reporte registrado correctamente");
                        }
                    }
                }
                break;
            case "6":
                Console.WriteLine("Ha cerrado sesión");
                return;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
    }
}
    }
}