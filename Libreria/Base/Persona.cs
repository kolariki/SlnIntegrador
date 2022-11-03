using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entidades.EntidadBase
{
    public class Persona
    {
        public Persona(string pnombre, string papellido, int pid, string pdomicilio, string ptelefono, string pcorreo)
        {
            Nombre = pnombre;
            Apellido = papellido;
            Id = pid;
            Domicilio = pdomicilio;
            Telefono = ptelefono;
            Correo = pcorreo;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
