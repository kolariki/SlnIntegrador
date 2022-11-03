using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Paciente : Persona
    {
        public Paciente(string pnombre, string papellido, int pid, string pdomicilio, string ptelefono, string pcorreo, string pnrohistoriaclinica) : base(pnombre, papellido, pid, pdomicilio, ptelefono, pcorreo)
        {
            NroHistoriaClinica = pnrohistoriaclinica;
        }
        public string NroHistoriaClinica{ get; set; }

    }
}
