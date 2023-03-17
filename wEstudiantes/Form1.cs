using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///<sumary>
///Nombre: jose manuel contreras 
///Fecha: 03/17/2023
///entrega: trabajo en clase "Escuela"
///curso: herramientas de programacion 2
///</sumary>
namespace wEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona persona = new Persona();
        Profesor profesor = new Profesor();
        Estudiante estudiante = new Estudiante();
        private void btnCapturarDatos_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radProfesor.Checked)
                {
                    persona.Name = txtNombre.Text;
                    profesor.Salary = double.Parse(txtSueldo.Text);

                }
                if (radEstudiante.Checked)
                {
                    persona.Name = txtNombre.Text;
                    estudiante.Note = double.Parse(txtCalificacion.Text);
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radEstudiante.Checked)
            {
                MessageBox.Show("Estudiante: " + persona.Asistir() + " nota: " + estudiante.Study());
            }
            if (radProfesor.Checked)
            {
                MessageBox.Show("Profesor: " + persona.Asistir() + " salary: " + profesor.Learn());
            }
        }
        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                txtCalificacion.Enabled = false;
                txtSueldo.Enabled = true;
                txtCalificacion.Clear();
            }
        }
        private void radEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (radEstudiante.Checked)
            {
                txtSueldo.Enabled = false;
                txtCalificacion.Enabled = true;
                txtSueldo.Clear();
            }
        }
    }
}
