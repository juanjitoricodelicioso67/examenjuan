using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenjuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[11];
            string[] cedulas = new string[11];

            int cantidad = 0;
            int opcion = 0;
            int posicion;
            int i;

            string nombre;
            string cedula;
            string buscar;

            // Inicializar los vectores
            for (i = 0; i < 11; i++)
            {
                nombres[i] = "";
                cedulas[i] = "";
            }

            while (opcion != 6)
            {
                Console.WriteLine("");
                Console.WriteLine("HOSPITAL SAN RAFAEL");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Buscar paciente");
                Console.WriteLine("3. Modificar paciente");
                Console.WriteLine("4. Dar de baja paciente");
                Console.WriteLine("5. Mostrar pacientes");
                Console.WriteLine("6. Salir");
                Console.Write("Digite una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                // Registrar paciente
                if (opcion == 1)
                {
                    if (cantidad < 11)
                    {
                        Console.Write("Digite el nombre del paciente: ");
                        nombre = Console.ReadLine();

                        Console.Write("Digite la cedula del paciente: ");
                        cedula = Console.ReadLine();

                        nombres[cantidad] = nombre;
                        cedulas[cantidad] = cedula;

                        cantidad = cantidad + 1;

                        Console.WriteLine("Paciente registrado");
                    }
                    else
                    {
                        Console.WriteLine("No hay espacio para mas pacientes");
                    }
                }

                // Buscar paciente
                else if (opcion == 2)
                {
                    Console.Write("Digite la cedula que desea buscar: ");
                    buscar = Console.ReadLine();

                    posicion = -1;

                    for (i = 0; i < cantidad; i++)
                    {
                        if (cedulas[i] == buscar)
                        {
                            posicion = i;
                        }
                    }

                    if (posicion != -1)
                    {
                        Console.WriteLine("Nombre: " + nombres[posicion]);
                        Console.WriteLine("Cedula: " + cedulas[posicion]);
                    }
                    else
                    {
                        Console.WriteLine("Paciente no encontrado");
                    }
                }

                // Modificar paciente
                else if (opcion == 3)
                {
                    Console.Write("Digite la cedula del paciente que desea modificar: ");
                    buscar = Console.ReadLine();

                    posicion = -1;

                    for (i = 0; i < cantidad; i++)
                    {
                        if (cedulas[i] == buscar)
                        {
                            posicion = i;
                        }
                    }

                    if (posicion != -1)
                    {
                        Console.Write("Digite el nuevo nombre: ");
                        nombres[posicion] = Console.ReadLine();

                        Console.Write("Digite la nueva cedula: ");
                        cedulas[posicion] = Console.ReadLine();

                        Console.WriteLine("Paciente modificado");
                    }
                    else
                    {
                        Console.WriteLine("Paciente no encontrado");
                    }
                }

                // Dar de baja paciente
                else if (opcion == 4)
                {
                    Console.Write("Digite la cedula del paciente que desea dar de baja: ");
                    buscar = Console.ReadLine();

                    posicion = -1;

                    for (i = 0; i < cantidad; i++)
                    {
                        if (cedulas[i] == buscar)
                        {
                            posicion = i;
                        }
                    }

                    if (posicion != -1)
                    {
                        for (i = posicion; i < cantidad - 1; i++)
                        {
                            nombres[i] = nombres[i + 1];
                            cedulas[i] = cedulas[i + 1];
                        }

                        nombres[cantidad - 1] = "";
                        cedulas[cantidad - 1] = "";

                        cantidad = cantidad - 1;

                        Console.WriteLine("Paciente dado de baja");
                    }
                    else
                    {
                        Console.WriteLine("Paciente no encontrado");
                    }
                }

                // Mostrar pacientes
                else if (opcion == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("LISTA DE PACIENTES");

                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay pacientes registrados");
                    }
                    else
                    {
                        for (i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Paciente " + (i + 1));
                            Console.WriteLine("Nombre: " + nombres[i]);
                            Console.WriteLine("Cedula: " + cedulas[i]);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Total de pacientes: " + cantidad);
                    }
                }

                // Salir
                else if (opcion == 6)
                {
                    Console.WriteLine("Programa finalizado");
                }

                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }

            Console.ReadKey();
        }
    }
}
