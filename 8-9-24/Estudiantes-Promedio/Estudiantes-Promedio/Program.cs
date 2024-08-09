class Estudiante
{
    private string _nombre;
    private int _legajo;
    private double _promedio;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public int Legajo
    {
        get { return _legajo; }
        set { _legajo = value; }
    }
    public double Promedio
    {
        get { return _promedio; }
        set
        {
            if (value >= 0 && value <= 10)
            {
                _promedio = value;
            }
            else
            {
                Console.WriteLine($"El promedio ingresado no es valido, intente de nuevo");
            }
        }

    }
    public Estudiante(string nombre, int legajo, double promedioInicial)
    {
        this._nombre = nombre;
        this._legajo = legajo;
        this.Promedio = promedioInicial;
    }
    public void CambiarPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
        Console.WriteLine($"Promedio actualizado: {Promedio}");
    }
}
public class Program
{
    public static void Main()
    {
        Estudiante unEstudiante = new Estudiante("Carlos Fuentes", 11232, 8.5);
        Console.WriteLine($"Alumno: {unEstudiante.Nombre}\nLegajo: {unEstudiante.Legajo}\nPromedio: {unEstudiante.Promedio}");
        unEstudiante.CambiarPromedio(9.5);

    }
}
