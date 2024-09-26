
using JardinMiranda;
using System;

class Program
{
    static void Main()
    {
        
        List<Planta> plantas = new List<Planta>();
        
        
        bool continuar = true;
       
        while (continuar)
        {
           
            Console.WriteLine("\n** Bienvenido al vivero Miranda **");
            Console.WriteLine("1. Agregar una nueva planta\n2. Agregar cantidades de una planta existente\n" +
                "3. Retirar plantas\n4. Mostrar lista de plantas en stock\n5. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa el nombre de la planta que quieras agregar a tu vivero: ");
                    string nombrePlanta = Console.ReadLine();

                    // Verificar si ya existe
                    bool existe = false;
                    foreach (var planta in plantas)
                    {
                        if (planta.Nombre.ToLower() == nombrePlanta.ToLower())
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe)
                    {
                        Console.WriteLine($"La planta {nombrePlanta} ya existe en el stock.");
                    }
                    else
                    {
                        Console.Write("Ingresa la cantidad inicial: ");
                        int cantidadInicial = int.Parse(Console.ReadLine());

                        plantas.Add(new Planta(nombrePlanta, cantidadInicial));
                        Console.WriteLine($"{nombrePlanta} añadida al vivero");
                    }
                   
                    break;


                case 2:
                    Console.Write("Ingresa el nombre de la planta: ");
                    string nombreAgregar = Console.ReadLine();
                    Console.Write("Cantidad a añadir: ");
                    int cantidadAgregar = int.Parse(Console.ReadLine());

                    // Verificar si existe la planta antes de agregar
                    Planta plantaExistente = null;
                    foreach (var planta in plantas)
                    {
                        if (planta.Nombre.ToLower() == nombreAgregar.ToLower())
                        {
                            plantaExistente = planta;
                            break;
                        }
                    }

                    if (plantaExistente != null)
                    {
                        plantaExistente.AgregarPlanta(cantidadAgregar);
                        Console.WriteLine($"{cantidadAgregar} flores añadidas a {nombreAgregar}.");
                    }
                    else
                    {
                        Console.WriteLine($"No existe {nombreAgregar} en el stock. Debes crearla primero.");
                    }
                    break;

                case 3:
                    Console.Write("Ingresa el nombre de la planta: ");
                    string nombreQuitar = Console.ReadLine();
                    Console.Write("Cantidad a quitar: ");
                    int cantidadQuitar = int.Parse(Console.ReadLine());

                    Planta plantaParaQuitar = null;
                    foreach (var planta in plantas)
                    {
                        if (planta.Nombre.ToLower() == nombreQuitar.ToLower())
                        {
                            plantaParaQuitar = planta;
                            break;
                        }
                    }

                    if (plantaParaQuitar != null)
                    {
                        plantaParaQuitar.RetirarCantidad(cantidadQuitar);
                        Console.WriteLine($"{cantidadQuitar} flores quitadas de {nombreQuitar}.");
                    }
                    else
                    {
                        Console.WriteLine($"No existe {nombreQuitar} en el stock.");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nStock de plantas:");
                    foreach (var planta in plantas)
                    {
                        planta.MostrarInformacion();
                    }
                    break;

                case 5:
                Console.WriteLine("Saliendo del sistema...");
                continuar = false;
                break;

                default:
                Console.WriteLine("La opcion ingresada no es valida");
                break;

            }
        }
    }
}