using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantMaterias { get; set; }
        public int Duracion { get; set; }
        public bool TituloIntermedio { get; set; }
        public string NombreTituloIntermedio { get; set; }
    }
}
