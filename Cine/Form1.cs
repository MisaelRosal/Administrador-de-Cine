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
    public partial class Form1 : Form
    {
        private const string cadenaConexion = "Data Source=LAPTOP-3UE44R3A\\SQLEXPRESS;Initial Catalog=Cine;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string Tipo = txtTipo.Text;

    
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(Tipo)) 
            {
                MessageBox.Show("Por favor, ingrese nombre y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "INSERT INTO Usuario (Nombre, Contraseña, Tipo) VALUES (@Nombre, @Contraseña,@Tipo)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@Tipo", Tipo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    CargarDatos();
                }
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

                string consulta = "SELECT * FROM Usuario";

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
            txtContraseña.Clear();
            txtTipo.Clear();
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

                string consulta = "DELETE FROM Usuario WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
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

                string nuevoUsuario = txtNombre.Text;
                string nuevaContraseña = txtContraseña.Text;
                string nuevoTipo = txtTipo.Text;

                filaSeleccionada.Cells["Nombre"].Value = nuevoUsuario;
                filaSeleccionada.Cells["Contraseña"].Value = nuevaContraseña;
                filaSeleccionada.Cells["Tipo"].Value = nuevoTipo;

                ActualizarBaseDeDatos(id, nuevoUsuario, nuevaContraseña, nuevoTipo);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ActualizarBaseDeDatos(int id, string nuevoUsuario, string nuevaContraseña, string nuevoTipo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string consulta = "UPDATE Sala " +
                                  "SET Nombre = @nuevoUsuario, Contraseña = @nuevaContraseña, Tipo = @nuevoTipo " +
                                  "WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@nuevoUsuario", nuevoUsuario);
                    cmd.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña);
                    cmd.Parameters.AddWithValue("@nuevoTipo", nuevoTipo);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.cineDataSet1.Usuario);
        }


        private void carteleraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }
    }
}
    