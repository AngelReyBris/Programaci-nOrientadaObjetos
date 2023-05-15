using System;
using System.Collections.Generic;

namespace CineTeatroHermanosRodriguez
{
    class CineTeatro
    {
        public string Nombre { get; set; }
        public List<Pelicula> Peliculas { get; set; }
        public List<ObraTeatro> ObrasTeatro { get; set; }
        private List<Venta> Ventas { get; set; }

        public CineTeatro(string nombre)
        {
            Nombre = nombre;
            Peliculas = new List<Pelicula>();
            ObrasTeatro = new List<ObraTeatro>();
            Ventas = new List<Venta>();
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);
        }

        public void AgregarObraTeatro(ObraTeatro obraTeatro)
        {
            ObrasTeatro.Add(obraTeatro);
        }

        public void IniciarSesionDueño(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "admin")
            {
                // Mostrar historial de ventas
                Console.WriteLine("Historial de Ventas:");
                foreach (Venta venta in Ventas)
                {      
    Console.WriteLine("- " + venta.Funcion.Nombre + " (" + venta.Funcion.Horario + ") - " + venta.NumeroEntradas + " entradas - Total: " + venta.CostoTotal + " pesos");
                }
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos");
            }
        }

        public void VenderBoletos(Funcion funcion, Cliente cliente, int numeroEntradas)
        {
            // Verificar que haya suficientes boletos disponibles
            if (funcion.CantidadBoletosDisponibles() < numeroEntradas)
            {
                Console.WriteLine("Lo sentimos, no hay suficientes boletos disponibles");
                return;
            }

            // Calcular costo total
            int costoTotal = numeroEntradas * funcion.Costo;

            // Registrar venta
            Ventas.Add(new Venta(funcion, cliente, numeroEntradas, costoTotal));

            // Actualizar cantidad de boletos disponibles
            funcion.VenderBoletos(numeroEntradas);

            // Mostrar confirmación
            Console.WriteLine("¡Compra realizada exitosamente! " + numeroEntradas + " boletos para " + funcion.Nombre + " el " + funcion.Horario + " - Total: " + costoTotal + " pesos");
        }
    }
}