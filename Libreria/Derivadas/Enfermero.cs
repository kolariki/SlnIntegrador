using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Enfermero : Persona
    {
        public Enfermero(string pnombre, string papellido, int pid, string pdomicilio, string ptelefono, string pcorreo, string pCuil) : base(pnombre, papellido, pid, pdomicilio, ptelefono, pcorreo)
        {
            Cuil = pCuil;
        }
        public string Cuil { get; set; }
        
    }
}
