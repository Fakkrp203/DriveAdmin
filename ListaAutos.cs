using System.Data;
using System.Data.SqlClient;

namespace CRUD_TEST
{
    public partial class ListaAutos : Form
    {
        public ListaAutos()
        {
            InitializeComponent();
        }

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-67DAIKB ;database = database1 ; integrated security = true");

        // Buscar un auto

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            btnEliminar.Enabled = true;
            conexion.Open();

            string id = textBox1.Text;
            string Query = "Select * from vehiculos where id=" + id;
            SqlCommand comando = new SqlCommand(Query, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(Query, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgvehiculo.DataSource = dt;
            }
            else
            {
                checkBox1.Visible = false;
                btnEliminar.Enabled = false;
                MessageBox.Show("No se encontró el auto con el ID especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexion.Close();
        }

        // Boton de confirmar edición
        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están habilitados
            if (checkBox1.Checked)
            {
                try
                {
                    conexion.Open();

                    // Obtener el ID del auto a editar
                    string id = textBox1.Text;

                    // Obtener los valores de los TextBox
                    string marca = txtmarca.Text;
                    string modelo = txtModelo.Text;
                    string año = txtAño.Text;
                    string precio = txtprecio.Text;
                    string color = txtcolor.Text;

                    // Crear la consulta de actualización
                    string Query = "UPDATE vehiculos SET marca = @marca, modelo = @modelo, año = @año, precio = @precio, color = @color WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(Query, conexion))
                    {
                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@marca", marca);
                        comando.Parameters.AddWithValue("@modelo", modelo);
                        comando.Parameters.AddWithValue("@año", año);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@color", color);
                        comando.Parameters.AddWithValue("@id", id);

                        // Ejecutar la consulta
                        int rowsAffected = comando.ExecuteNonQuery();

                        // Verificar si se actualizó algún registro
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El elemento ha sido actualizado correctamente.",
                            "Correcto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                            renderizarAutos();
                            ResetearCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el auto con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Asegurarse de cerrar la conexión
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, habilita la edición para guardar los cambios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        // Boton para eliminar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection("server=DESKTOP-67DAIKB;database=database1;integrated security=true"))
            {
                conexion.Open();
                string Query = "DELETE FROM vehiculos WHERE id= @id";
                using (SqlCommand comando = new SqlCommand(Query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    int cant = comando.ExecuteNonQuery();

                    if (cant == 1)
                    {
                        MessageBox.Show("Se Eliminó el Artículo", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvehiculo.DataSource = null;
                        textBox1.Text = string.Empty;
                    }
                }
            }
        }

        // Checkbox para permitir la edición y mostrar los elementos en los inputs
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && textBox1.Text != "")
            {
                // Habilitar campos de texto
                txtmarca.Enabled = true;
                txtModelo.Enabled = true;
                txtAño.Enabled = true;
                txtprecio.Enabled = true;
                txtcolor.Enabled = true;

                btnguardar.Enabled = true;

                // Obtener el ID del TextBox
                string id = textBox1.Text;

                // Validar que el ID no esté vacío
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conexion = new SqlConnection("server=DESKTOP-67DAIKB;database=database1;integrated security=true"))
                {
                    conexion.Open();
                    string Query = "SELECT * FROM vehiculos WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(Query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        // Devolver las columnas
                        using (SqlDataReader registro = comando.ExecuteReader())
                        {
                            if (registro.Read())
                            {
                                txtid.Text = registro["id"].ToString();
                                txtmarca.Text = registro["marca"].ToString();
                                txtModelo.Text = registro["modelo"].ToString();
                                txtAño.Text = registro["año"].ToString();
                                txtprecio.Text = registro["precio"].ToString();
                                txtcolor.Text = registro["color"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el auto con el ID especificado.", "Error al encontrar el auto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                // Deshabilitar campos de texto si no está chequeado
                txtmarca.Enabled = false;
                txtModelo.Enabled = false;
                txtAño.Enabled = false;
                txtprecio.Enabled = false;
                txtcolor.Enabled = false;

                btnguardar.Enabled = false;
            }
        }

        private void ResetearCampos()
        {
            txtid.Text = "";
            txtmarca.Text = "";
            txtModelo.Text = "";
            txtAño.Text = "";
            txtprecio.Text = "";
            txtcolor.Text = "";

            checkBox1.Checked = false;
        }

        // Renderizar otra vez los autos
        private void renderizarAutos()
        {
            string id = textBox1.Text;
            string Query = "Select * from vehiculos where id=" + id;
            SqlCommand comando = new SqlCommand(Query, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(Query, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgvehiculo.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        // Validaciones ========================================

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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