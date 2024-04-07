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
    public partial class Inventario_de_Salida : Form
    {
        // Cadena de conexión a la base de datos - ¡Asegúrate de ajustarla según tu configuración!
        string connectionString = "Data Source=(localdb)\\senati;Initial Catalog=ALMACEN_YARID;Integrated Security=True";
        public Inventario_de_Salida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrWhiteSpace(tbID_Salida.Text) || string.IsNullOrWhiteSpace(tbID_Producto.Text) ||
                string.IsNullOrWhiteSpace(tbCantidad_Retirada.Text) || string.IsNullOrWhiteSpace(tbMotivo_Salida.Text) ||
                string.IsNullOrWhiteSpace(tbID_Cliente.Text) || string.IsNullOrWhiteSpace(tbNumeroFactura.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Captura los datos del formulario
            int idSalida;
            if (!int.TryParse(tbID_Salida.Text, out idSalida))
            {
                MessageBox.Show("El ID de salida debe ser un número entero válido.");
                return;
            }
            int idProducto;
            if (!int.TryParse(tbID_Producto.Text, out idProducto))
            {
                MessageBox.Show("El ID del producto debe ser un número entero válido.");
                return;
            }
            int cantidadRetirada;
            if (!int.TryParse(tbCantidadRetirada.Text, out cantidadRetirada))
            {
                MessageBox.Show("La cantidad retirada debe ser un número entero válido.");
                return;
            }
            DateTime fechaHoraSalida = DateTime.Now; // Se puede tomar la fecha y hora actual
            string motivoSalida = tbMotivoSalida.Text;
            int idCliente;
            if (!int.TryParse(tbID_Cliente.Text, out idCliente))
            {
                MessageBox.Show("El ID del cliente debe ser un número entero válido.");
                return;
            }
            string numeroFactura = tbNumeroFactura.Text;

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO Salidas_Inventario (ID_Salida, ID_Producto, Cantidad_Retirada, Fecha_Hora_Salida, Motivo_Salida, ID_Cliente, Numero_Factura) " +
                           "VALUES (@ID_Salida, @ID_Producto, @Cantidad_Retirada, @Fecha_Hora_Salida, @Motivo_Salida, @ID_Cliente, @Numero_Factura)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@ID_Salida", idSalida);
                    command.Parameters.AddWithValue("@ID_Producto", idProducto);
                    command.Parameters.AddWithValue("@Cantidad_Retirada", cantidadRetirada);
                    command.Parameters.AddWithValue("@Fecha_Hora_Salida", fechaHoraSalida);
                    command.Parameters.AddWithValue("@Motivo_Salida", motivoSalida);
                    command.Parameters.AddWithValue("@ID_Cliente", idCliente);
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

    

