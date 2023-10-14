using Actividad_4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_4
{
    public partial class Form1 : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        Producto producto = new Producto();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ID = random.Next(1,101); 
            string nombre = txtNombre.Text;
            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                listaProductos.Add(new Producto {ID = ID, Nombre = nombre, Precio = precio });
                ActualizarListaProductos();
                txtNombre.Clear();
                txtPrecio.Clear();
            }
            else
            {
                MessageBox.Show("El precio debe ser un número válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             string claveEliminar = txtClaveEliminar.Text;
            listaProductos.RemoveAll(producto => producto.ID.ToString() == claveEliminar);
            ActualizarListaProductos();
            txtClaveEliminar.Clear(
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaProductos = listaProductos.OrderBy(producto => producto.Nombre).ToList();
            ActualizarListaProductos();
        }
        private void ActualizarListaProductos()
        {
            listBoxProductos.Items.Clear();
            decimal costoTotal = 0;

            foreach (var producto in listaProductos)
            {
                listBoxProductos.Items.Add($"ID: {producto.ID} - {producto.Nombre} - ${producto.Precio}");
                costoTotal += producto.Precio;
            }

            labelCostoTotal.Text = $"Costo Total: ${costoTotal}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
