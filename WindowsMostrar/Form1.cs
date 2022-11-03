using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Libreria.Derivadas;
using Negocio;
using Libreria.Entidades;
using System.Collections;


namespace WindowsMostrar
{
   
        public partial class Form1 : Form
        {

                    public Form1()
            {
                InitializeComponent();
            }

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {

            gridDatos.DataSource = AdmMedico.Listar();

            lstMostrar.Items.Clear();
            foreach (Medico medico in AdmMedico.Listar("Clínico"))
            {
                lstMostrar.Items.Add(medico.Nombre + " " + medico.Apellido + " ---> " + "MEDICO CLINICO");
            }

        }

        private void bntHabitaciones_Click(object sender, EventArgs e)
        {
            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                lstHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = AdmPaciente.Listar();
        }

        
    }
    }