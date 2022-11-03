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

        static List<Paciente> pacientes;

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Id = 0, Nombre = "Pedro", Apellido = "Rojo", Domicilio = "xxxx", Telefono = "45642832", Email = "xxxxz@gmail.com", NroHistoriaClinica = 1, FechaNacimiento = new DateTime(1990, 11, 05) });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Juan", Apellido = "Azul", Domicilio = "xxxx", Telefono = "261735824", Email = "jxxxx@gmail.com", NroHistoriaClinica = 2, FechaNacimiento = new DateTime(1989, 05, 05) });
            pacientes.Add(new Paciente() { Id = 2, Nombre = "Equis", Apellido = "Verde", Domicilio = "xxxx", Telefono = "351734789", Email = "xxxxn@gmail.com", NroHistoriaClinica = 3, FechaNacimiento = new DateTime(2000, 08, 19) });
            pacientes.Add(new Paciente() { Id = 3, Nombre = "Diamante", Apellido = "Amarillo", Domicilio = "xxxx", Telefono = "2612453792", Email = "xxx@gmail.com", NroHistoriaClinica = 4, FechaNacimiento = new DateTime(1700, 02, 27) });
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            return 0;
        }

        public static int Eliminar(int id)
        {
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return null;
        }

    }
}