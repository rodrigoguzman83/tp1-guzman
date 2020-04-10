using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class InscripcionMateria
    {
        public int Id { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public IList<Materia> Materias { get; set; }
        public IList<Alumno> Alumnos { get; set; }
    }
}
