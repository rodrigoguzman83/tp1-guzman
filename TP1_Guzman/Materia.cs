﻿using System;
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
        public List<Carrera> Carreras { get; set; }
    }
}
