using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set;  }
        public int Dni { get; set; }
        public int Celular { get; set; }
        public DateTime FechaNac { get; set; }
        public string Mail { get; set; }
    }
}
