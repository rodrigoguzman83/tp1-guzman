using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Carrera> Carrera { get; set; }
        public List<Profesor> Profesor { get; set; }
        public List<Ayudante> Ayudante { get; set; }
        public List<Aula> Aula { get; set; }
        public string Dia { get; set; }
        public int HorarioDesde { get; set; }
        public int HorarioHasta { get; set; }
    }
}
