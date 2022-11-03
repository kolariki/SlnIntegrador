using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Director : Persona
    {
        public Director(string pnombre, string papellido, int pid, string pdomicilio, string ptelefono, string pcorreo, string pEspecialidad, int pMatricula, string pPosgrado) : base(pnombre, papellido, pid, pdomicilio, ptelefono, pcorreo)
        {
            Especialidad = pEspecialidad;
            Matricula = pMatricula;
            Posgrado = pPosgrado;
        }
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
        public string Posgrado { get; set; }
      
    }
}
