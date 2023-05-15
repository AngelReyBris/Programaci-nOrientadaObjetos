using System;

namespace ProyectoEnfermeras
{
    public class Paciente
    {
        public int NumeroPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CURP { get; set; }
        public string Direccion { get; set; }
        public Enfermera EnfermeraAsignada { get; set; }
        public string Diagnostico { get; set; } 

        public Paciente(int numeroPaciente, string nombre, string apellido, string curp, string direccion, Enfermera enfermeraAsignada)
        {
            NumeroPaciente = numeroPaciente;
            Nombre = nombre;
            Apellido = apellido;
            CURP = curp;
            Direccion = direccion;
            EnfermeraAsignada = enfermeraAsignada;
        }

        public void AsignarDiagnostico(string diagnostico)
        {
            Diagnostico = diagnostico;
        }
    }
}