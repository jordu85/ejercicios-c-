class Vehiculo
{
    public string Nombre { get; set; }

    public Vehiculo(string nombre)
    {
        Nombre = nombre;
    }
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"El vehiculo {Nombre} ");
    }
    public virtual void MostrarMedioDesplazamiento()
    {
        MostrarInfo();
        Console.WriteLine($"El vehiculo... ");
    }
}
    class Auto : Vehiculo
    {
        public Auto(string nombre) : base(nombre) { }
        public override void MostrarMedioDesplazamiento()
        {
            MostrarInfo();
            Console.WriteLine($"se desplaza por la autopista.\n");
        }
    }
    class Barco : Vehiculo
    {
        public Barco(string nombre) : base(nombre) { }
        public override void MostrarMedioDesplazamiento()
        {
            MostrarInfo();
            Console.WriteLine($"se desplaza por agua.\n");
        }
    }
    class Avion : Vehiculo
    {
        public Avion(string nombre) : base(nombre) { }
        public override void MostrarMedioDesplazamiento()
        {
            MostrarInfo();
            Console.WriteLine($"se desplaza por aire.\n");
        }
    }
   
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Ingrese nombre del auto: ");
            Vehiculo unAuti = new Auto(Console.ReadLine());
            unAuti.MostrarMedioDesplazamiento();

            Console.WriteLine($"Ingrese nombre del barco: ");
            Vehiculo unBarco = new Barco(Console.ReadLine());
            unBarco.MostrarMedioDesplazamiento();

            Console.WriteLine($"Ingrese nombre del avion: ");
            Vehiculo unAvi = new Avion(Console.ReadLine());
            unAvi.MostrarMedioDesplazamiento();

        }
    }


