using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class InscripcionesCarrera
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<Carrera> Carreras { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
