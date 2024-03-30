using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace almacen_productos
{
    public partial class Form1 : Form
    {
        Productos formularioProductos;
        Proveedores formularioProveedores;

        public Form1()
        {
            InitializeComponent();

            // Inicializar las instancias de los formularios
            formularioProductos = new Productos();
            formularioProveedores = new Proveedores();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Código si es necesario
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            formularioProductos.ShowDialog();
        }

        private void btnRegistrarProveedores_Click(object sender, EventArgs e)
        {
            formularioProveedores.ShowDialog();
        }
    }
}
