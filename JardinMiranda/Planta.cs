

namespace JardinMiranda
{
    class Planta
    {
        private string _nombre;
        private int _cantidadStock;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int CantidadStock
        {
            get { return _cantidadStock; }
            set { _cantidadStock = value; }
        }

        public Planta(string nombre, int cantidadStock)
        {
            _nombre = nombre;
            _cantidadStock = cantidadStock;

        }

        public void AgregarPlanta(int cantidad)
        {

                if (cantidad > 0)
                {
                    CantidadStock += cantidad;
                    Console.WriteLine($"Incorporacion: {cantidad}\nStock actualizado: {CantidadStock}");
                }
                else
                {
                    Console.WriteLine("La cantidad ingresada no es valida, tiene que ser un numaero mayor que 0");
                }
        }
        public void RetirarCantidad(int cantidadRetirar)
            {

                if (cantidadRetirar > 0 && cantidadRetirar < CantidadStock)
                {
                    CantidadStock -= cantidadRetirar;
                    Console.WriteLine($"Se retiran: {cantidadRetirar}\nStock actualizado: {CantidadStock}");
                }
                else
                {
                    Console.WriteLine("La cantidad ingresada no es valida, tiene que ser un numaero mayor que 0");
                }
            }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}\nCantidad en stock: {CantidadStock}");
        }

    }
}

