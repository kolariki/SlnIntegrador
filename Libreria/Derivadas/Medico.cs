using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Medico : Persona
    {
        public Medico(string pnombre, string papellido, int pid, string pdomicilio, string ptelefono, string pcorreo, string pEspecialidad, int pMatricula) : base(pnombre, papellido, pid, pdomicilio, ptelefono, pcorreo)
        {
            Especialidad = pEspecialidad;
            Matricula = pMatricula;
        }
        public string Especialidad { get; set; }
        public int Matricula { get; set; }


    }
}
