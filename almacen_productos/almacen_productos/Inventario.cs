using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacen_productos
{
    public partial class Inventario : Form
    {

        Inventario_de_Salida formularioInventario_De_Salida;
        Inventario_Entrada formularioInventario_Entrada;
        Movimiento_Inventario formularioMovimiento_Inventario;
        public Inventario()
        {
            InitializeComponent();

            
            formularioInventario_De_Salida = new Inventario_de_Salida();
            formularioInventario_Entrada = new Inventario_Entrada();
            formularioMovimiento_Inventario = new Movimiento_Inventario();

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual (Productos)
            this.Close();

            // Buscar una instancia existente del formulario principal
            Form1 formPrincipal = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (formPrincipal != null)
            {
                // Si existe, tráelo al frente
                formPrincipal.BringToFront();
            }
            else
            {
                // Si no existe, crea una nueva instancia y muéstrala
                formPrincipal = new Form1();
                formPrincipal.Show();
            }
        }

        private void btnInventarioSalida_Click(object sender, EventArgs e)
        {
            formularioInventario_De_Salida.ShowDialog();
        }

        private void btnInventarioEntrada_Click(object sender, EventArgs e)
        {
            formularioInventario_Entrada.ShowDialog();
        }

        private void btnMovimientoInventario_Click(object sender, EventArgs e)
        {
            formularioMovimiento_Inventario.ShowDialog();
        }
    }
}
