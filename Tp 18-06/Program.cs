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
                eventos.Add(taller);
                break;
        }
    }
    private static void Main(string[] args)
    {

    }
}