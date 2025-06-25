using System.Security.Cryptography;
using Tp_18_06;

internal class Program
{
    public static Participante InscribirParticipante(Evento evento)
    {
        Participante par = new Participante();
        Console.WriteLine("Ingrese el nombre");
        par.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido");
        par.Apellido = Console.ReadLine();
        evento.AgregarParticipante();
        return par;
    }
    public static List<Evento> eventos = new List<Evento>();
    public static void CrearEvento()
    {
        Console.WriteLine("Ingrese que tipo de evento es");
        Console.WriteLine("1: Taller");
        Console.WriteLine("2: Conferencia");
        int op = int.Parse(Console.ReadLine());
        switch(op) 
        {
            case 1:
                Taller taller = new Taller();
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
    public static void ListarEventos()
    {
        int i = 1;
        foreach (Evento eve in eventos)
        {
            Console.WriteLine(i);
            eve.ObtenerDescripcion();
            i++;
        }
    }
    public static void BuscarEvento()
    {
        ListarEventos();
        Console.WriteLine("Ingrese el nombre del evento");
        string evento = Console.ReadLine();
        bool existe = false;
        foreach(Evento eve in eventos)
        {
            if (evento == eve.Nombre)
            {
                eve.ObtenerDescripcion();
                foreach (Participante participante in eve.Participantes)
                {
                    participante.MostrarNombreCompleto();
                }
                existe = true;
            }
            if (existe = false)
            {
                Console.WriteLine("No existe");
            }
        }
    }
    public static void Menu()
    {
        Console.WriteLine("Ingrese que desea hacer");
        Console.WriteLine("1: Crear evento");
        Console.WriteLine("2: Mostrar lista de eventos");
        Console.WriteLine("3: Buscar eventos");
        Console.WriteLine("4: Inscribir participantes");
        int sel = int.Parse(Console.ReadLine());
        switch (sel)
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
                Console.WriteLine("A que evento lo queres inscribir");
                ListarEventos();
                int i = int.Parse(Console.ReadLine());
                InscribirParticipante(eventos[i - 1]);
                break;
            default:
                Console.WriteLine("Ingrese una opcion valida");
                break;
        }
    }

    public static void Main(string[] args)
    {
        while(true)
        {
            Menu();
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}