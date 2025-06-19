using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_18_06
{
    public class Conferencia : Evento
    {
        public string TemaPrincipal {get;set;}
        
        public override void ObtenerDescripcion()
        {
            Console.WriteLine("Conferencia de eventos");
        }
    }
}
