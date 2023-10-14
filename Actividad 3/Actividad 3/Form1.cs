using Actividad_3.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3
{
    public partial class Form1 : Form
    {
        List<Alumno> Aprobados = new List<Alumno>();
        List<Alumno> Reprobados = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if(string.IsNullOrEmpty(nombre) )
            {
                MessageBox.Show("Ingrese un nombre valido.");
            }
            if(double.TryParse(txtCalificacion.Text, out double calificacion))
            {
                Alumno alumno = new Alumno(nombre, calificacion);
                if (calificacion >= 7)
                {
                    Aprobados.Add(alumno);
                    lstAprobados.Items.Add(alumno);
                }
                else
                {
                    Reprobados.Add(alumno);
                    lstReprobados.Items.Add(alumno);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Ingrese una calificacion valida.");
            }
            txtNombre.Clear();
            txtCalificacion.Clear();
        }
    }
}
