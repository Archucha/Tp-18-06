using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_18_06
{
    internal class Taller:Evento
    {
        public int CapacidadMax { get; set;}
        public override void ObtenerDescripcion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Ubicacion: " + Ubicacion);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Capacidad Maxima: " + CapacidadMax);
        }
        public override void AgregarParticipante()
        {
            Participante par = new Participante();
            if (CantParticipantes + 1 > CapacidadMax)
            {
                Console.WriteLine("Cantidad maxima alcanzada");
            }
            else
            {
                Participantes.Add(par);
            }
        }
        
    }
}
