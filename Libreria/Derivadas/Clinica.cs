using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Clinica
    {
        public Clinica(string pnombre, string papellido, int pid, string pdomicilio, string ptelefono, string pcorreo, string pemail)
        {
            Nombre = pnombre;
            Domicilio = pdomicilio;
            Telefono = ptelefono;
            Email = pemail;
        }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


    }
}
