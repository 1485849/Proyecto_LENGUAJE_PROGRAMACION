using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace almacen_productos


{
    public partial class Proveedores : Form
    {
        // Cadena de conexión a la base de datos
        string connectionString = "Data Source=(localdb)\\senati;Initial Catalog=ALMACEN_YARID;Integrated Security=True";

        public Proveedores()
        {
            InitializeComponent();

        
                InitializeComponent();
                btnvolver.Click += btnvolver_Click; // Suscripción al evento Click del botón "Volver"
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (string.IsNullOrEmpty(tbnombreempresa.Text) || string.IsNullOrEmpty(tbnombrecontacto.Text) || string.IsNullOrEmpty(tbdireccion.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.");
                return;
            }

            // Captura los datos del formulario
            string ID_Proveedor = tbid.Text;
            string Nombre_Empresa = tbnombreempresa.Text;
            string Nombre_Contacto = tbnombrecontacto.Text;
            string Direccion = tbdireccion.Text;
            string Telefono = tbtelefono.Text;
            string Correo_Electronico = tbcorreoelectronico.Text;
            string Terminos_Pago = tbterminodepago.Text;

            DateTime Fecha_Entrega_Producto;
            if (!DateTime.TryParse(tbfechaentregadeproducto.Text, out Fecha_Entrega_Producto))
            {
                MessageBox.Show("Formato de fecha inválido para Fecha de Entrega de Producto. Por favor, ingrese una fecha válida.");
                return;
            }

            // Crea la consulta SQL para insertar los datos en la base de datos
            string query = "INSERT INTO Proveedores (ID_Proveedor, Nombre_Empresa, Nombre_Contacto, Direccion, Telefono, Correo_Electronico, Terminos_pago, Fecha_Entrega_Producto) " +
                           "VALUES (@ID_Proveedor, @Nombre_Empresa, @Nombre_Contacto, @Direccion, @Telefono, @Correo_Electronico, @Terminos_pago, @Fecha_Entrega_Producto)";

            // Establece la conexión a la base de datos y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añade parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    command.Parameters.AddWithValue("@Nombre_Empresa", Nombre_Empresa);
                    command.Parameters.AddWithValue("@Nombre_Contacto", Nombre_Contacto);
                    command.Parameters.AddWithValue("@Direccion", Direccion);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Correo_Electronico", Correo_Electronico);
                    command.Parameters.AddWithValue("@Terminos_pago", Terminos_Pago);
                    command.Parameters.AddWithValue("@Fecha_Entrega_Producto", Fecha_Entrega_Producto);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Datos del proveedor insertados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar datos del proveedor: " + ex.Message);
                    }
                }
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
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
