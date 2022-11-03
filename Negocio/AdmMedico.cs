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

            static List<Medico> medicos;

            public static List<Medico> Listar()
            {
                medicos = new List<Medico>();
                medicos.Add(new Medico() { Id = 0, Nombre = "Francisco", Apellido = "Paton", Domicilio = "xxx xxx 123", Telefono = "261364173", Email = "xxx@gmail.com", Especialidad = "Clínico", Matricula = 1 });
                medicos.Add(new Medico() { Id = 1, Nombre = "Pedro", Apellido = "Bro", Domicilio = "xxx 2482", Telefono = "346782423", Email = "xxx@gmail.com", Especialidad = "Traumatólogo", Matricula = 2 });
                medicos.Add(new Medico() { Id = 2, Nombre = "Lolo", Apellido = "Amigo", Domicilio = "xxxx 342", Telefono = "354532534", Email = "xxx@gmail.com", Especialidad = "Clínico", Matricula = 3 });
                medicos.Add(new Medico() { Id = 3, Nombre = "Lucas", Apellido = "Perez", Domicilio = "xxxx 864", Telefono = "253717434", Email = "xxx@gmail.com", Especialidad = "Pediatra", Matricula =4 });
                return medicos;
            }

            public static List<Medico> Listar(string especialidad)
            {
                List<Medico> tempMedicos = new List<Medico> { };
                foreach (Medico medico in medicos)
                {
                    if (medico.Especialidad == especialidad)
                    {
                        tempMedicos.Add(medico);
                    }
                }
                return tempMedicos;
            }

            public static int Insertar(Medico medico)
            {
                return 0;
            }

            public static int Eliminar(int id)
            {
                return 0;
            }

            public static Medico TraerUno(int id)
            {
                return null;
            }
        }
    }