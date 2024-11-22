using System.Data;
using System.Data.SqlClient;

namespace CRUD_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-67DAIKB ;database = database1 ; integrated security = true");

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderizarVehiculos();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Verifica si alguno de los campos está vacío
            if (txtid.Text == string.Empty || txtmarca.Text == string.Empty || txtModelo.Text == string.Empty ||
                txtAño.Text == string.Empty || txtprecio.Text == string.Empty || txtcolor.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // No continuar hasta que todos los campos estén llenos
            }
            else
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection("server=DESKTOP-67DAIKB ;database = database1 ; integrated security = true"))
                    {
                        conexion.Open();
                        // Obtener los valores de los campos
                        string id = txtid.Text;
                        string marca = txtmarca.Text;
                        string modelo = txtModelo.Text;
                        string año = txtAño.Text;
                        string precio = txtprecio.Text;
                        string color = txtcolor.Text;

                        // Usar parametros
                        string query = "INSERT INTO vehiculos(id, marca, modelo, año, precio, color) " +
                                       "VALUES (@id, @marca, @modelo, @año, @precio, @color)";

                        // Crear el comando SQL y agregar los parámetros
                        SqlCommand comando = new SqlCommand(query, conexion);

                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@modelo", modelo);
                        comando.Parameters.AddWithValue("@año", año);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@color", color);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();

                        // Mensaje de éxito
                        MessageBox.Show("Los datos se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Renderizar los vehículos para tener un "hot reload"
                        RenderizarVehiculos();
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error si ocurre algo
                    MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ResetearCampos();
                }
            }
        }

        // Funciones
        private void RenderizarVehiculos()
        {
            string Query = "Select * from vehiculos";

            SqlDataAdapter adaptador = new SqlDataAdapter(Query, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            dgvehiculo.DataSource = dt;
        }

        private void ResetearCampos()
        {
            txtid.Text = "";
            txtmarca.Text = "";
            txtModelo.Text = "";
            txtAño.Text = "";
            txtprecio.Text = "";
            txtcolor.Text = "";
        }

        private void buttonCatalogo_Click(object sender, EventArgs e)
        {
            ListaAutos listaAutosForm = new ListaAutos();
            listaAutosForm.ShowDialog();
        }

        // Validaciones ========================================

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNum(e, "ID");
        }

        private void txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarString(e, "Marca");
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumString(e, "Modelo");
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNum(e, "Año");
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNum(e, "Precio");
        }

        private void txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarString(e, "Color");
        }

        // Funciones de validación

        // Validar solo strings
        private void validarString(KeyPressEventArgs e, string nombreCampo)
        {
            // "Si el carácter presionado no es un número y no es la tecla de retroceso, cancela la entrada."
            if (!(Char.IsLetter(e.KeyChar)) && (e.KeyChar != (Char)Keys.Back))
            {
                MessageBox.Show($"El campo '{nombreCampo}' debe contener solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true; // e.Handled es el equivalente a e.PreventDefault de js
                return;
            }
        }

        // Solo numeros

        private void validarNum(KeyPressEventArgs e, string nombreCampo)
        {
            // "Si el carácter presionado no es un número y no es la tecla de retroceso, cancela la entrada."
            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (Char)Keys.Back) && (e.KeyChar != (Char)Keys.Escape))
            {
                MessageBox.Show($"El campo {nombreCampo} debe ser solo de numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true; // e.Handled es el equivalente a e.PreventDefault de js
                return;
            }
        }

        // Funcion para validar Campos que puedan tener numeros y letras
        private void validarNumString(KeyPressEventArgs e, string nombreCampo)
        {
            // Permitir solo letras, números, espacio y guion
            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == (char)Keys.Escape))
            {
                MessageBox.Show($"El campo {nombreCampo} debe contener solo letras, números, espacios y guiones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true; // Cancela la entrada
                return;
            }
        }
    }
}