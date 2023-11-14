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

namespace Cine
{
    public partial class Form5 : Form
    {
        private const string cadenaConexion = "Data Source=LAPTOP-3UE44R3A\\SQLEXPRESS;Initial Catalog=Cine;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string Comida = txtComida.Text;
            string Cantidad = txtCantidad.Text;
            string Precio = txtPrecio.Text;


            if (string.IsNullOrEmpty(Comida) || string.IsNullOrEmpty(Cantidad) || string.IsNullOrEmpty(Precio))
            {
                MessageBox.Show("Por favor, ingrese los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "INSERT INTO Menu (Comida, Cantidad, Precio) VALUES (@Comida, @Cantidad, @Precio)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Comida", Comida);
                        cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                        cmd.Parameters.AddWithValue("@Precio", Precio);

                        cmd.ExecuteNonQuery();

                    }

                    CargarDatos();
                }

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT * FROM Menu";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = tabla;
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtComida.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idEliminar = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                dataGridView1.Rows.Remove(filaSeleccionada);

                EliminarRegistroEnBaseDeDatos(idEliminar);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EliminarRegistroEnBaseDeDatos(int id)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "DELETE FROM Menu WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

                string nuevaComida = txtComida.Text;
                string nuevasUnidades = txtCantidad.Text;
                string nuevoPrecio = txtPrecio.Text;

                filaSeleccionada.Cells["Comida"].Value = nuevaComida;
                filaSeleccionada.Cells["Cantidad"].Value = nuevasUnidades;
                filaSeleccionada.Cells["Precio"].Value = nuevoPrecio;

                ActualizarBaseDeDatos(id, nuevaComida, nuevasUnidades, nuevoPrecio);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActualizarBaseDeDatos(int id, string nuevaComida, string nuevasUnidades, string nuevoPrecio)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "UPDATE Menu " +
                                  "SET Comida = @nuevaComida, Cantidad = @nuevasUnidades, Precio = @nuevoPrecio " +
                                  "WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@nuevaComida", nuevaComida);
                    cmd.Parameters.AddWithValue("@nuevasUnidades", nuevasUnidades);
                    cmd.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
