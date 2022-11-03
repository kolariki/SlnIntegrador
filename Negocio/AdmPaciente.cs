using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Derivadas;

namespace Negocio
{
    public static class AdmPaciente
    {
        //declarar
        static List<Paciente> pacientes;

        public static List<Paciente> Carga()
        {

            // crear la lista
            pacientes = new List<Paciente>();



            pacientes.Add(new Paciente("Juan", "Alvarez", 0, "Buenos Aires 428", "4564522", "juancarlos@gmail.com", "A193399"));
            pacientes.Add(new Paciente("Julian", "Gomez", 1, "San Martin 12", "435345", "julian@gmail.com", "A43323"));

   
            return pacientes;

        }

        public static List<Paciente> Listar(string HistoriaClinica)
        {
            pacientes = new List<Paciente>();



            pacientes.Add(new Paciente("Juan", "Alvarez", 0, "Buenos Aires 428", "4564522", "juancarlos@gmail.com", "A193399"));
            pacientes.Add(new Paciente("Julian", "Gomez", 1, "San Martin 12", "435345", "julian@gmail.com", "A43323"));


            return pacientes;
        }

        public static int Insertar(int pacientes)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

        public static int Eliminar(int pid)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

        public static int TraerUno(Paciente pid)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
    }

}
