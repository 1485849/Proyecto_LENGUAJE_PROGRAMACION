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
        public Inventario()
        {
            InitializeComponent();
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
    }
}
