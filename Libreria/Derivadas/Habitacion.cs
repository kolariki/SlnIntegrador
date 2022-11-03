﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Habitacion
    {

        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }

        public Habitacion(int id, int numero, string estado)
        {
            Id = id;
            Numero = numero;
            Estado = estado;
        }

        public Habitacion() { }
    }
}