using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Derivadas;

namespace Negocio
{
    public static class AdmHabitacion
    {
        //declarar
        static List<Habitacion> habitaciones;

        public static List<Habitacion> Carga()
        {

            // crear la lista
            habitaciones = new List<Habitacion>();



            habitaciones.Add(new Habitacion(1, "Safa", 0));
            habitaciones.Add(new Habitacion(2, "Safa", 0));

          
            return habitaciones;

        }

        public static List<Habitacion> Listar()
        {

            habitaciones = new List<Habitacion>();

            habitaciones.Add(new Habitacion(1, "Safa", 0));
            habitaciones.Add(new Habitacion(2, "Linda", 1));
            habitaciones.Add(new Habitacion(3, "Buena", 2));
            habitaciones.Add(new Habitacion(4, "Mala", 3));
            habitaciones.Add(new Habitacion(5, "Excelente", 4));

            return habitaciones;

        }


        public static List<Habitacion> ListarEstado(Habitacion pestado)
        {
            //TODO Falta programar el método TraerPorCategoria
            return null;
        }


        public static int Insertar(int habitaciones)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }

        public static int TraerUno(Habitacion pnumero)
        {
            //TODO Falta programar el método Eliminar
            return 0;
        }
    }

}
