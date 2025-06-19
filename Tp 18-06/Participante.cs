using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_18_06
{
    public class Participante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string MostrarNombreCompleto(string nombrecompleto)
        {
            Participante p = new Participante();
            nombrecompleto = p.Nombre + " " + p.Apellido;
            return nombrecompleto;
        }

    }
}
