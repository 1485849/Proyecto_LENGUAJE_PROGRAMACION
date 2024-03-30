using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace almacen_productos
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos
        string connectionString = "Data Source=(localdb)\\senati;Initial Catalog=ALMACEN_YARID;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Código si es necesario
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Captura los datos del formulario
            string nombre = tbnombre.Text;
            string descripcion = tbdescripcion.Text;
            string codigo = tbcodigo.Text;
            string categoria = tbcategoria.Text;
            decimal precio = Convert.ToDecimal(tbprecio.Text);
            string unidadMedida = tbunidaddemedida.Text;
            string fechaVencimiento = dateTimePickerfechavencimiento.Text;
            int cantidad = Convert.ToInt32(tbcantidad.Text);

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO TuTabla (Nombre, Descripcion, Codigo, Categoria, Precio, Unidad_Medida, Fecha_Vencimiento, Cantidad) " +
                           "VALUES (@Nombre, @Descripcion, @Codigo, @Categoria, @Precio, @Unidad_Medida, @Fecha_Vencimiento, @Cantidad)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
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
    }
}
