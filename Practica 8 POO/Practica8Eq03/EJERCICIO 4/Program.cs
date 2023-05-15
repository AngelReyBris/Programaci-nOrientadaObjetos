using System;

namespace CineTeatroHermanosRodriguez
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cargar las películas y obras de teatro por defecto
            Pelicula[] peliculas = {
                new Pelicula("1 Avengers: Endgame", "Sala 1", "12:00pm", 150),
                new Pelicula("2 Star Wars: El Ascenso de Skywalker", "Sala 2", "3:00pm", 120),
                new Pelicula("3 Joker", "Sala 3", "6:00pm", 100)
            };

            ObraTeatro[] obrasTeatro = {
                new ObraTeatro("1 Romeo y Julieta", "Leonardo DiCaprio, Claire Danes", "Baz Luhrmann", "Escenario 1", "8:00pm", 200),
                new ObraTeatro("2 Hamlet", "Kenneth Branagh", "Kenneth Branagh", "Escenario 2", "6:00pm", 180),
                new ObraTeatro("3 Los Miserables", "Hugh Jackman, Russell Crowe", "Tom Hooper", "Escenario 3", "9:00pm", 220)
            };

            // Crear el cine-teatro y agregar las películas y obras de teatro
            CineTeatro cineTeatro = new CineTeatro("Cine-Teatro Hermanos Rodríguez");
            foreach (Pelicula pelicula in peliculas)
            {
                cineTeatro.AgregarPelicula(pelicula);
            }
            foreach (ObraTeatro obraTeatro in obrasTeatro)
            {
                cineTeatro.AgregarObraTeatro(obraTeatro);
            }

            // Mostrar el menú principal
            bool salir = false;
            while (!salir)
            {   
                 Console.WriteLine("****** para iniciar sesión como dueño es usuario: admin  contraseña: admin  *******");
                Console.WriteLine("Bienvenido al Cine-Teatro Hermanos Rodríguez");
                Console.WriteLine("1. Películas");
                Console.WriteLine("2. Obras de Teatro");
                Console.WriteLine("3. Iniciar sesión como dueño");
                Console.WriteLine("4. Registrarse como cliente");
                Console.WriteLine("5. Salir");

                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        // Mostrar películas
                        Console.WriteLine("Películas:");
                        foreach (Pelicula pelicula in cineTeatro.Peliculas)
                        {
                            Console.WriteLine("- " + pelicula.Nombre + " (" + pelicula.Sala + ", " + pelicula.Horario + ") - Costo: " + pelicula.Costo + " pesos por persona");
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        // Mostrar obras de teatro
                        Console.WriteLine("Obras de Teatro:");
                        foreach (ObraTeatro obraTeatro in cineTeatro.ObrasTeatro)
                        {
                            Console.WriteLine("- " + obraTeatro.Nombre + " (" + obraTeatro.Escenario + ", " + obraTeatro.Horario + ") - Costo: " + obraTeatro.Costo + " pesos por persona");
                        }
                        Console.WriteLine();
                        break;

                    case "3":
                        // Iniciar sesión como dueño
                        Console.Write("Ingrese el nombre de usuario: ");
                        string usuario = Console.ReadLine();
                        Console.Write("Ingrese la contraseña: ");
                        string contrasena = Console.ReadLine();

                        // Mostrar historial de ventas
                        cineTeatro.IniciarSesionDueño(usuario, contrasena);
                        Console.WriteLine();
                        break;

                    case "4":
                        // Registrarse como cliente
                        Console.Write("Ingrese su nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese su apellido: ");
                        string apellido = Console.ReadLine();
                        Console.Write("Ingrese su dirección: ");
                        string direccion = Console.ReadLine();
                        Console.Write("Ingrese su número de cuenta PayPal: ");
                        string numeroCuentaPayPal = Console.ReadLine();

                        // Crear el cliente y mostrar cartelera
                        Cliente cliente = new Cliente(nombre, apellido, direccion, numeroCuentaPayPal);
                        Console.WriteLine();
                        Console.WriteLine("Cartelera:");
                        Console.WriteLine("1. Películas");
                        Console.WriteLine("2. Obras de Teatro");

                        Console.Write("Ingrese una opción: ");
                        string opcionCartelera = Console.ReadLine();
                        Console.WriteLine();

                        switch (opcionCartelera)
                        {
                            case "1":
                                // Mostrar películas y vender boletos
                                Console.WriteLine("Películas:");
                                foreach (Pelicula pelicula in cineTeatro.Peliculas)
                                {
                                    pelicula.MostrarInformacion();
                                }
                                Console.WriteLine();

                                Console.Write("Ingrese el número de la película que desea ver: ");
                                int numeroPelicula = int.Parse(Console.ReadLine());
                                Pelicula peliculaSeleccionada = cineTeatro.Peliculas[numeroPelicula - 1];

                                Console.Write("Ingrese el número de boletos que desea comprar: ");
                                int numeroBoletos = int.Parse(Console.ReadLine());

                                cineTeatro.VenderBoletos(peliculaSeleccionada, cliente, numeroBoletos);
                                break;

                            case "2":
                                // Mostrar obras de teatro y vender boletos
                                Console.WriteLine("Obras de Teatro:");
                                foreach (ObraTeatro obraTeatro in cineTeatro.ObrasTeatro)
                                {
                                    obraTeatro.MostrarInformacion();
                                }
                                Console.WriteLine();

                                Console.Write("Ingrese el número de la obra de teatro que desea ver: ");
                                int numeroObraTeatro = int.Parse(Console.ReadLine());
                                ObraTeatro obraTeatroSeleccionada = cineTeatro.ObrasTeatro[numeroObraTeatro - 1];

                                Console.Write("Ingrese el número de boletos que desea comprar: ");
                                int numeroBoletosObraTeatro = int.Parse(Console.ReadLine());

                                cineTeatro.VenderBoletos(obraTeatroSeleccionada, cliente, numeroBoletosObraTeatro);
                                break;

                            default:
                                Console.WriteLine("Opción inválida");
                                break;
                        }
                        Console.WriteLine();
                        break;

                    case "5":
                        // Salir
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}