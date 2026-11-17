
using System;

namespace tecnoapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("   INVENTARIO DE TECNOPUNTO");
            Console.WriteLine("================================");

            // Registrar tres productos
            for (int i = 1; i <= 3; i++)
            {
                bool registrado = false;

                // Repetir hasta registrar un producto valido
                while (!registrado)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("PRODUCTO " + i);

                        Console.Write("Codigo: ");
                        string codigo = Console.ReadLine();

                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Precio: ");
                        decimal precio = decimal.Parse(
                            Console.ReadLine());

                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(
                            Console.ReadLine());

                        // Crear el objeto usando el constructor
                        Producto producto = new Producto(
                            codigo, nombre, precio, cantidad);

                        Console.WriteLine();
                        Console.WriteLine("Producto registrado exitosamente!.");

                        // Mostrar informacion del producto
                        producto.MostrarInfo();

                        registrado = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine(
                            "ERROR: Introduzca un numero valido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine();
                        Console.WriteLine(
                            "ERROR: El numero esta fuera del rango permitido.");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("  REGISTRO FINALIZADO");
            Console.WriteLine("================================");

            Console.WriteLine("Presione ENTER para salir...");
            Console.ReadLine();
        }
    }
}



