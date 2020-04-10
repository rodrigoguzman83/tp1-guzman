using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class Comision
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IList<Carrera> Carreras { get; set; }
        public IList<Materia> Materias { get; set; }
        public IList<Profesor> Profesors { get; set; }
        public IList<Ayudante> Ayudantes { get; set; }
        public IList<Aula> Aulas { get; set; }
        public DateTime FechaInicio { get; set; }
    }
}
