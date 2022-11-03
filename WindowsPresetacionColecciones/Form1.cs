using System;
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
using Entidades;
using Entidades.Models.Derivada;
using Negocio;

namespace WindowsPresetacionColecciones
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

            gridMedicos.DataSource = AdmMedico.Listar();

            lstMostrar.Items.Clear();
            foreach (Medico medico in AdmMedicos.Listar("Clínico"))
            {
                lstMostrar.Items.Add(medico.Nombre + " " + medico.Apellido);
            }
        }
    }
}