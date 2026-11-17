
using System;

namespace tecnoapp
{
    public class Producto
    {
        // Campos privados
        private string nombre;
        private decimal precio;
        private int cantidad;

        // Propiedad Codigo
        public string Codigo { get; set; }

        // Propiedad Nombre con validacion
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "El nombre no puede estar vacio.");
                }

                nombre = value;
            }
        }

        // Propiedad Precio con validacion
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "El precio debe ser mayor que cero.");
                }

                precio = value;
            }
        }

        // Propiedad Cantidad con validacion
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "La cantidad no puede ser negativa.");
                }

                cantidad = value;
            }
        }

        // Propiedad calculada de solo lectura
        public decimal ValorTotal
        {
            get
            {
                return Precio * Cantidad;
            }
        }

        // Constructor de la clase
        public Producto(string codigo, string nombre,
                        decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Metodo para mostrar los datos
        public void MostrarInfo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: RD$" + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor total: RD$" + ValorTotal);
            Console.WriteLine("--------------------------");
        }
    }
}

