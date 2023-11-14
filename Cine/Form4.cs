using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string cadenaConexion = "Data Source=LAPTOP-3UE44R3A\\SQLEXPRESS;Initial Catalog=Cine;Integrated Security=True";


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Capacidad = txtCapacidad.Text;
            string AsientosD = txtAsientosD.Text;
            string AsientosOcu = txtAsientosOcu.Text;

            if (string.IsNullOrEmpty(Capacidad) || string.IsNullOrEmpty(AsientosD) || string.IsNullOrEmpty(AsientosOcu))
            {
                MessageBox.Show("Por favor, ingrese los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "INSERT INTO Sala (Capacidad, [Asientos disponibles], [Asientos ocupados]) " +
                                  "VALUES (@Capacidad, @AsientosD, @AsientosOcu)";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Capacidad", Capacidad);
                    cmd.Parameters.AddWithValue("@AsientosD", AsientosD);
                    cmd.Parameters.AddWithValue("@AsientosOcu", AsientosOcu);

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
                string consulta = "SELECT ID_Sala, Capacidad, [Asientos disponibles], [Asientos ocupados] FROM Sala";

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
            txtCapacidad.Clear();
            txtAsientosD.Clear();
            txtAsientosOcu.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int idEliminar = Convert.ToInt32(filaSeleccionada.Cells["ID_Sala"].Value);

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

                string consulta = "DELETE FROM Sala WHERE ID_Sala = @ID_Sala";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_Sala", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["ID_Sala"].Value);

                string nuevaCapacidad = txtCapacidad.Text;
                string nuevaAsientosD = txtAsientosD.Text;
                string nuevaAsientosOcu = txtAsientosOcu.Text;

                filaSeleccionada.Cells["Capacidad"].Value = nuevaCapacidad;
                filaSeleccionada.Cells["AsientosD"].Value = nuevaAsientosD;
                filaSeleccionada.Cells["AsientosO"].Value = nuevaAsientosOcu;

                ActualizarBaseDeDatos(id, nuevaCapacidad, nuevaAsientosD, nuevaAsientosOcu);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActualizarBaseDeDatos(int id, string nuevaCapacidad, string nuevaAsientosD, string nuevaAsientosOcu)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "UPDATE Sala " +
                                  "SET Capacidad = @NuevaCapacidad, [Asientos disponibles] = @NuevaAsientosD, [Asientos ocupados] = @NuevaAsientosOcu " +
                                  "WHERE ID_Sala = @ID_Sala";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@NuevaCapacidad", nuevaCapacidad);
                    cmd.Parameters.AddWithValue("@NuevaAsientosD", nuevaAsientosD);
                    cmd.Parameters.AddWithValue("@NuevaAsientosOcu", nuevaAsientosOcu);
                    cmd.Parameters.AddWithValue("@ID_Sala", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
    