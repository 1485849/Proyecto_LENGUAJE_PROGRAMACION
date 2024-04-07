using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacen_productos
{
    public partial class Productos : Form
    {

        // Cadena de conexión a la base de datos - ¡Asegúrate de ajustarla según tu configuración!
        string connectionString = "Data Source=(localdb)\\senati;Initial Catalog=ALMACEN_YARID;Integrated Security=True";
        public Productos()
        {
            InitializeComponent();
         
            
                InitializeComponent();
                btnvolver.Click += btnvolver_Click; // Suscripción al evento Click del botón "Volver"
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Validación de campos
            if (string.IsNullOrWhiteSpace(tbid.Text) ||
                string.IsNullOrWhiteSpace(tbnombre.Text) || string.IsNullOrWhiteSpace(tbdescripcion.Text) ||
                string.IsNullOrWhiteSpace(tbcodigo.Text) || string.IsNullOrWhiteSpace(tbcategoria.Text) ||
                string.IsNullOrWhiteSpace(tbprecio.Text) || string.IsNullOrWhiteSpace(tbunidaddemedida.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerfechavencimiento.Text) || string.IsNullOrWhiteSpace(tbcantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Captura los datos del formulario
            int idProducto;
            if (!int.TryParse(tbid.Text, out idProducto))
            {
                MessageBox.Show("El ID del producto debe ser un número entero válido.");
                return;
            }
            string nombre = tbnombre.Text;
            string descripcion = tbdescripcion.Text;
            string codigo = tbcodigo.Text;
            string categoria = tbcategoria.Text;
            decimal precio;
            if (!decimal.TryParse(tbprecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número decimal válido.");
                return;
            }
            string unidadMedida = tbunidaddemedida.Text;
            DateTime fechaVencimiento;
            if (!DateTime.TryParse(dateTimePickerfechavencimiento.Text, out fechaVencimiento))
            {
                MessageBox.Show("Formato de fecha inválido para la fecha de vencimiento.");
                return;
            }
            int cantidad;
            if (!int.TryParse(tbcantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO Productos (ID_Producto, Nombre, Descripcion, Codigo, Categoria, Precio, Unidad_Medida, Fecha_Vencimiento, Cantidad) " +
                           "VALUES (@ID_Producto, @Nombre, @Descripcion, @Codigo, @Categoria, @Precio, @Unidad_Medida, @Fecha_Vencimiento, @Cantidad)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@ID_Producto", idProducto);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Codigo", codigo);
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Unidad_Medida", unidadMedida);
                    command.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVencimiento);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Datos insertados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar datos: " + ex.Message);
                    }
                }
            }
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
