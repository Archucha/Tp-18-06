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
            Console.WriteLine("Taller de informatica");
            Console.WriteLine("Cantidad maxima de participantes: "+ CapacidadMax);
        }
        public override void AgregarParticipante(Participante par)
        {
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
