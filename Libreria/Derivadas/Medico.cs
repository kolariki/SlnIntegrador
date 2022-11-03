﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Medico : Persona
    {

        public string Especialidad { get; set; }
        public int Matricula { get; set; }

        public Medico(int id, string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, int matricula) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;
        }

        public Medico()
        {
        }
    }
}