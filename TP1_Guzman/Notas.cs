﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Guzman
{
    public class Notas
    {
        public int Id { get; set; }
        public List<Materia> Materia { get; set; }
        public List<Alumno> Alumno { get; set; }
        public int Nota { get; set; }
    }
}