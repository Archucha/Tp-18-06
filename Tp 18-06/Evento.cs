using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_18_06
{
    public abstract class Evento
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Ubicacion { get; set; }
        public int CantParticipantes {  get; set; }
        public List<Participante> Participantes { get; set; } = new List<Participante>();
        public abstract void ObtenerDescripcion();
        public virtual void AgregarParticipante()
        {
            Participante par = new Participante();
            Participantes.Add(par);
            CantParticipantes = CantParticipantes + 1; 
        }
    }
}
