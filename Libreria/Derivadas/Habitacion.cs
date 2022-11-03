using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.EntidadBase;

namespace Libreria.Derivadas
{
    public class Habitacion
    {
        public Habitacion(int pnumero, string pestado, int pid)
        {
            Numero = pnumero;
            Estado = pestado;
            Id = pid;
           
        }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public int Id { get; set; }


    }
}
