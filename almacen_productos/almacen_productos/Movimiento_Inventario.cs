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
    public partial class Movimiento_Inventario : Form
    {
        // Cadena de conexión a la base de datos - ¡Asegúrate de ajustarla según tu configuración!
        string connectionString = "Data Source=(localdb)\\senati;Initial Catalog=ALMACEN_YARID;Integrated Security=True";

        public Movimiento_Inventario()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrWhiteSpace(tbID_Movimiento.Text) || string.IsNullOrWhiteSpace(tbTipo_Movimiento.Text) ||
                string.IsNullOrWhiteSpace(tbID_Producto.Text) || string.IsNullOrWhiteSpace(tbCantidad_Movida.Text) ||
                string.IsNullOrWhiteSpace(tbOrigen.Text) || string.IsNullOrWhiteSpace(tbDestino.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Captura los datos del formulario
            int idMovimiento;
            if (!int.TryParse(tbID_Movimiento.Text, out idMovimiento))
            {
                MessageBox.Show("El ID del movimiento debe ser un número entero válido.");
                return;
            }
            string tipoMovimiento = tbTipo_Movimiento.Text;
            int idProducto;
            if (!int.TryParse(tbID_Producto.Text, out idProducto))
            {
                MessageBox.Show("El ID del producto debe ser un número entero válido.");
                return;
            }
            int cantidadMovida;
            if (!int.TryParse(tbCantidad_Movida.Text, out cantidadMovida))
            {
                MessageBox.Show("La cantidad movida debe ser un número entero válido.");
                return;
            }
            DateTime fechaHoraMovimiento = DateTime.Now; // Se puede tomar la fecha y hora actual
            string origen = tbOrigen.Text;
            string destino = tbDestino.Text;

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO Movimientos_Inventario (ID_Movimiento, Tipo_Movimiento, ID_Producto, Cantidad_Movida, Fecha_Hora_Movimiento, Origen, Destino) " +
                           "VALUES (@ID_Movimiento, @Tipo_Movimiento, @ID_Producto, @Cantidad_Movida, @Fecha_Hora_Movimiento, @Origen, @Destino)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@ID_Movimiento", idMovimiento);
                    command.Parameters.AddWithValue("@Tipo_Movimiento", tipoMovimiento);
                    command.Parameters.AddWithValue("@ID_Producto", idProducto);
                    command.Parameters.AddWithValue("@Cantidad_Movida", cantidadMovida);
                    command.Parameters.AddWithValue("@Fecha_Hora_Movimiento", fechaHoraMovimiento);
                    command.Parameters.AddWithValue("@Origen", origen);
                    command.Parameters.AddWithValue("@Destino", destino);

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