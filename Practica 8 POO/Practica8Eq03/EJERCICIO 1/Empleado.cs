using System;

namespace ProyectoEnfermeras
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }

    public class Empleado : Persona
    {
        public int NumeroEmpleado { get; set; }
        public string RFC { get; set; }

        public Empleado(int numeroEmpleado, string nombre, string apellido, string rfc) : base(nombre, apellido)
        {
            NumeroEmpleado = numeroEmpleado;
            RFC = rfc;
        }

        public virtual void RealizarTarea()
        {
            Console.WriteLine("Realizando tarea...");
        }
    }

    public class Enfermera : Empleado
    {
        public string Area { get; set; }
        public string Contrasena { get; set; }

        public Enfermera(int numeroEmpleado, string nombre, string apellido, string rfc, string area, string contrasena) : base(numeroEmpleado, nombre, apellido, rfc)
        {
            Area = area;
            Contrasena = contrasena;
        }

        public override void RealizarTarea()
        {
            Console.WriteLine("Realizando tarea de enfermería...");
        }

        public void EscribirReporte(Paciente paciente, string reporte)
        {
            Console.WriteLine("Escribiendo reporte para " + paciente.Nombre + " " + paciente.Apellido);
            Console.WriteLine("Reporte: " + reporte);
        }
    }
}