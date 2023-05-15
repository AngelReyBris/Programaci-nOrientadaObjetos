using System;

namespace ProyectoEnfermeras
{
public class Paciente : Persona
    {
        public int NumeroPaciente { get; set; }
        public string CURP { get; set; }
        public string Direccion { get; set; }
        public Enfermera EnfermeraAsignada { get; set; }
        public string Diagnostico { get; set; }

        public Paciente(int numeroPaciente, string nombre, string apellido, string curp, string direccion, Enfermera enfermeraAsignada) : base(nombre, apellido)
        {
            NumeroPaciente = numeroPaciente;
            CURP = curp;
            Direccion = direccion;
            EnfermeraAsignada = enfermeraAsignada;
        }

        public void AsignarDiagnostico(string diagnostico)
        {
            Diagnostico = diagnostico;
            Console.WriteLine("Diagnóstico asignado: " + diagnostico);
        }

        public void AsignarDiagnostico(string diagnostico, Empleado medico)
        {
            Diagnostico = diagnostico;
            Console.WriteLine("Diagnóstico asignado por el médico " + medico.Nombre + " " + medico.Apellido + ": " + diagnostico);
        }
    }
}