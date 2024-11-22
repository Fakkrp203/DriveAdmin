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
            // Verifica si alguno de los campos est� vac�o
            if (txtid.Text == string.Empty || txtmarca.Text == string.Empty || txtModelo.Text == string.Empty ||
                txtA�o.Text == string.Empty || txtprecio.Text == string.Empty || txtcolor.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // No continuar hasta que todos los campos est�n llenos
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
                        string a�o = txtA�o.Text;
                        string precio = txtprecio.Text;
                        string color = txtcolor.Text;

                        // Usar parametros
                        string query = "INSERT INTO vehiculos(id, marca, modelo, a�o, precio, color) " +
                                       "VALUES (@id, @marca, @modelo, @a�o, @precio, @color)";

                        // Crear el comando SQL y agregar los par�metros
                        SqlCommand comando = new SqlCommand(query, conexion);

                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@modelo", modelo);
                        comando.Parameters.AddWithValue("@a�o", a�o);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@color", color);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();

                        // Mensaje de �xito
                        MessageBox.Show("Los datos se guardaron correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Renderizar los veh�culos para tener un "hot reload"
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
            txtA�o.Text = "";
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

        private void txtA�o_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNum(e, "A�o");
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNum(e, "Precio");
        }

        private void txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarString(e, "Color");
        }

        // Funciones de validaci�n

        // Validar solo strings
        private void validarString(KeyPressEventArgs e, string nombreCampo)
        {
            // "Si el car�cter presionado no es un n�mero y no es la tecla de retroceso, cancela la entrada."
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
            // "Si el car�cter presionado no es un n�mero y no es la tecla de retroceso, cancela la entrada."
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
            // Permitir solo letras, n�meros, espacio y guion
            if (!(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == (char)Keys.Escape))
            {
                MessageBox.Show($"El campo {nombreCampo} debe contener solo letras, n�meros, espacios y guiones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true; // Cancela la entrada
                return;
            }
        }
    }
}