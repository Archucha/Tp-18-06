using System.Security.Cryptography;
using Tp_18_06;

internal class Program
{
    public List<Evento> eventos = new List<Evento>();
    public void CrearEvento()
    {
        Console.WriteLine("Ingrese que tipo de evento es");
        Console.WriteLine("1: Taller");
        Console.WriteLine("2: Conferencia");
        int op = int.Parse(Console.ReadLine());
        switch(op) 
        {
            case 1:
                Taller taller = new Taller();
                taller.ObtenerDescripcion();
                Console.WriteLine("Ingrese el nombre del evento");
                taller.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha del evento");
                taller.Fecha = Console.ReadLine();
                Console.WriteLine("Ingrese la ubicacion");
                taller.Ubicacion = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad maxima de participantes");
                taller.CapacidadMax = int.Parse(Console.ReadLine());
                eventos.Add(taller);
                break;
            case 2:
                Conferencia conferencia = new Conferencia();
                conferencia.ObtenerDescripcion();
                Console.WriteLine("Ingrese el nombre del evento");
                conferencia.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha del evento");
                conferencia.Fecha = Console.ReadLine();
                Console.WriteLine("Ingrese la ubicacion");
                conferencia.Ubicacion = Console.ReadLine();
                Console.WriteLine("Ingrese el tema principal");
                conferencia.TemaPrincipal = Console.ReadLine();
                eventos.Add(conferencia);
                break;
        }
    }
    public void ListarEventos()
    {
        foreach (Evento eve in eventos)
        {
            eve.ObtenerDescripcion();
        }
    }
    public void BuscarEvento()
    {
        Console.WriteLine("Ingrese el nombre del evento");
        string evento = Console.ReadLine();
        foreach(Evento eve in eventos)
        {
            if (evento == eve.Nombre)
            {
                eve.ObtenerDescripcion(); 
            }
        }
    }
    private static void Main(string[] args)
    {

    }
}