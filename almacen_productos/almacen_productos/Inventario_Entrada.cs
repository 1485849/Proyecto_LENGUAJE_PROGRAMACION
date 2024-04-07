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
    public partial class Inventario_Entrada : Form

    {
        // Cadena de conexión a la base de datos - ¡Asegúrate de ajustarla según tu configuración!
        string connectionString = "Data Source=(localdb)\\senati;Initial Catalog=ALMACEN_YARID;Integrated Security=True";
        public Inventario_Entrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrWhiteSpace(tbID_Producto.Text) || string.IsNullOrWhiteSpace(tbCantidadRecibida.Text) ||
                string.IsNullOrWhiteSpace(tbID_Proveedor.Text) || string.IsNullOrWhiteSpace(tbNumero_Factura.Text) ||
                string.IsNullOrWhiteSpace(tbID_Entrada.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Captura los datos del formulario
            int idEntrada;
            if (!int.TryParse(tbID_Entrada.Text, out idEntrada))
            {
                MessageBox.Show("El ID de entrada debe ser un número entero válido.");
                return;
            }
            int idProducto;
            if (!int.TryParse(tbID_Producto.Text, out idProducto))
            {
                MessageBox.Show("El ID del producto debe ser un número entero válido.");
                return;
            }
            int cantidadRecibida;
            if (!int.TryParse(tbCantidadRecibida.Text, out cantidadRecibida))
            {
                MessageBox.Show("La cantidad recibida debe ser un número entero válido.");
                return;
            }
            DateTime fechaHoraEntrada = DateTime.Now; // Se puede tomar la fecha y hora actual
            int idProveedor;
            if (!int.TryParse(tbID_Proveedor.Text, out idProveedor))
            {
                MessageBox.Show("El ID del proveedor debe ser un número entero válido.");
                return;
            }
            string numeroFactura = tbNumero_Factura.Text;

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO Entradas_Inventario (ID_Entrada, ID_Producto, Cantidad_Recibida, Fecha_Hora_Entrada, ID_Proveedor, Numero_Factura) " +
                           "VALUES (@ID_Entrada, @ID_Producto, @Cantidad_Recibida, @Fecha_Hora_Entrada, @ID_Proveedor, @Numero_Factura)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@ID_Entrada", idEntrada);
                    command.Parameters.AddWithValue("@ID_Producto", idProducto);
                    command.Parameters.AddWithValue("@Cantidad_Recibida", cantidadRecibida);
                    command.Parameters.AddWithValue("@Fecha_Hora_Entrada", fechaHoraEntrada);
                    command.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                    command.Parameters.AddWithValue("@Numero_Factura", numeroFactura);

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
