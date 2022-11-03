using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Libreria.Derivadas;

namespace Negocio
{
    public static class AdmMedico
    {
        //declarar
        static List<Medico> medicos;

        public static List<Medico> Carga()
        {

            // crear la lista
            medicos = new List<Medico>();

            medicos.Add(new Medico("Juan", "Alvarez", 0, "Buenos Aires 428", "4564522", "juancarlos@gmail.com", "Cirujano", 1999 ));
            medicos.Add(new Medico("Julian", "Gomez", 1, "San Martin 12", "435345", "julian@gmail.com", "Cerebrista", 433));
            medicos.Add(new Medico("Pedro", "Gonzales", 2, "Azcuebaga 333", "4456e522", "pedro@gmail.com", "Cardiologo", 554));
            medicos.Add(new Medico("Mario", "Martin", 3, "Yrigoyen 322", "45erter22", "mario@gmail.com", "Maternoinfante", 19991));

            return medicos;

        }

        public static List<Medico> Listar(string especialidad)
        {
            medicos = new List<Medico>();

            medicos.Add(new Medico("Juan", "Alvarez", 0, "Buenos Aires 428", "4564522", "juancarlos@gmail.com", "Cirujano", 1999));
            medicos.Add(new Medico("Julian", "Gomez", 1, "San Martin 12", "435345", "julian@gmail.com", "Cerebrista", 433));
            medicos.Add(new Medico("Pedro", "Gonzales", 2, "Azcuebaga 333", "4456e522", "pedro@gmail.com", "Cardiologo", 554));
            medicos.Add(new Medico("Mario", "Martin", 3, "Yrigoyen 322", "45erter22", "mario@gmail.com", "Maternoinfante", 19991));

            return medicos;
        }

        public static int ListarEspecialidad(string pespecialidad)
        {
            //TODO Falta programar el método Insertar
            return 0;
        }


        public static int Insertar(int medicos)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

        public static int Eliminar(int pid)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

        public static int TraerUno(Medico pid)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
    }

}
