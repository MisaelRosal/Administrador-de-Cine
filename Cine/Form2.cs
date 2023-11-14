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
    public partial class Form2 : Form
    {
        string cadenaConexion = "Data Source=LAPTOP-3UE44R3A\\SQLEXPRESS;Initial Catalog=Cine;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string duracion = txtDuracion.Text;
            string tiempoInicio = txtTiempoInicio.Text;
            string tiempoFinal = txtTiempoFinal.Text;
            string genero = txtGenero.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(duracion) || string.IsNullOrEmpty(tiempoInicio) || string.IsNullOrEmpty(tiempoFinal) || string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Por favor, ingrese nombre y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "INSERT INTO Cartelera (Nombre, Duracion, TiempoInicio, TiempoFinal, Genero) " +
                                  "VALUES (@Nombre, @Duracion, @TiempoInicio, @TiempoFinal, @Genero)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@duracion", duracion);
                    cmd.Parameters.AddWithValue("@TiempoInicio", tiempoInicio);
                    cmd.Parameters.AddWithValue("@TiempoFinal", tiempoFinal);
                    cmd.Parameters.AddWithValue("@Genero", genero);

                    cmd.ExecuteNonQuery();
                }

                CargarDatos();
            }
            LimpiarFormulario();
        }

        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "SELECT * FROM Cartelera";

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
            txtNombre.Clear();
            txtDuracion.Clear();
            txtTiempoInicio.Clear();
            txtTiempoFinal.Clear();
            txtGenero.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idEliminar = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

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

                string consulta = "DELETE FROM Cartelera WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                string nuevoNombre = txtNombre.Text;
                string nuevaDuracion = txtDuracion.Text;
                string nuevoTiempoInicio = txtTiempoInicio.Text;
                string nuevoTiempoFinal = txtTiempoFinal.Text;
                string nuevoGenero = txtGenero.Text;

                filaSeleccionada.Cells["Nombre"].Value = nuevoNombre;
                filaSeleccionada.Cells["Duracion"].Value = nuevaDuracion;
                filaSeleccionada.Cells["TiempoInicio"].Value = nuevoTiempoInicio;
                filaSeleccionada.Cells["TiempoFinal"].Value = nuevoTiempoFinal;
                filaSeleccionada.Cells["Genero"].Value = nuevoGenero;

                ActualizarBaseDeDatos(id, nuevoNombre, nuevaDuracion, nuevoTiempoInicio, nuevoTiempoFinal, nuevoGenero);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActualizarBaseDeDatos(int id, string nuevoNombre, string nuevaDuracion, string nuevoTiempoInicio, string nuevoTiempoFinal, string nuevoGenero)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "UPDATE Cartelera " +
                                  "SET nombre = @NuevoNombre, duracion = @NuevaDuracion, TiempoInicio = @NuevoTiempoInicio, TiempoFinal = @NuevoTiempoFinal, Genero = @NuevoGenero " +
                                  "WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@NuevaDuracion", nuevaDuracion);
                    cmd.Parameters.AddWithValue("@NuevoTiempoInicio", nuevoTiempoInicio);
                    cmd.Parameters.AddWithValue("@NuevoTiempoFinal", nuevoTiempoFinal);
                    cmd.Parameters.AddWithValue("@NuevoGenero", nuevoGenero);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

