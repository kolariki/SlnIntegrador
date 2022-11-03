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


namespace WindowsMostrar
{
    public partial class Form1 : Form
    {

        AdmMedico admMedicos = new AdmMedico();
        AdmPaciente admPacientes = new AdmPaciente();
        AdmHabitacion admHabitaciones = new AdmHabitacion();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = admMedicos.Listar("Clinico");

            lstMostrar.Items.Clear();
            foreach (Medico medico in admMedicos.Listar("Clínico"))
            {
                lstMostrar.Items.Add(medico.Nombre + " " + medico.Apellido);
            }


        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = admPacientes.Listar("clinicos");

            lstMostrar.Items.Clear();
            foreach (Paciente paciente in admPacientes.Listar("Clínico"))
            {
                lstMostrar.Items.Add(paciente.Nombre + " " + paciente.Apellido);
            }


        }

        private void bntHabitaciones_Click(object sender, EventArgs e)
        {
            foreach (Habitacion habitacion in admHabitaciones.Listar())
            {
                lstHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }
    }
}
