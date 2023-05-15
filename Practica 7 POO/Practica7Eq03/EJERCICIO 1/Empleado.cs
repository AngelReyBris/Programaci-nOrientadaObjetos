using System;

namespace ProyectoEnfermeras
{
    public class Empleado
    {
        public int NumeroEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string RFC { get; set; }

        public Empleado(int numeroEmpleado, string nombre, string apellido, string rfc)
        {
            NumeroEmpleado = numeroEmpleado;
            Nombre = nombre;
            Apellido = apellido;
            RFC = rfc;
        }
    }

  public class Enfermera : Empleado
    {
        public string Area { get; set; }
        public string Contrasena { get; set; }

        public Enfermera(int numeroEmpleado, string nombre, string apellido, string rfc, string area, string contrasena)
            : base(numeroEmpleado, nombre, apellido, rfc)
        {
            Area = area;
            Contrasena = contrasena;
        }

        public void EscribirReporte(Paciente paciente, string reporte)
        {
       Console.WriteLine("Escribiendo reporte para " + paciente.Nombre + " " + paciente.Apellido);
Console.WriteLine("Reporte: " + reporte);
        }
    }
}