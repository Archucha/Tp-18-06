using System.Security.Cryptography;
using Tp_18_06;

internal class Program
{
    public List<Evento> eventos = new List<Evento>();
    public Participante p = new Participante();
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
                foreach (Participante participante in eve.Participantes)
                {
                    participante.MostrarNombreCompleto();
                }
            }
        }
    }
    public void InscribirParticipante(Participante par)
    {
        Console.WriteLine("Ingrese el nombre");
        par.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido");
        par.Apellido = Console.ReadLine();
    }
    public void Main(string[] args)
    {
        Console.WriteLine("Ingrese que desea hacer");
        Console.WriteLine("1: Crear evento");
        Console.WriteLine("2: Mostrar lista de eventos");
        Console.WriteLine("3: Buscar eventos");
        Console.WriteLine("4: Inscribir participantes");
        int sel = int.Parse(Console.ReadLine());
        switch(sel)
        {
            case 1:
                CrearEvento();
                break;
            case 2:
                ListarEventos();
                break;
            case 3:
                BuscarEvento();
                break;
            case 4:
                InscribirParticipante(p);
                break;
            default: 
                Console.WriteLine("Ingrese una opcion valida");
                break;
        }
    }
}