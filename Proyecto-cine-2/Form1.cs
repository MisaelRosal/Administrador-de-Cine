using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_cine_2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }

        private void texUser_Enter(object sender, EventArgs e)
        {
            if (texUser.Text == "Usuario")
            {
                texUser.Text = "";
                texUser.ForeColor = Color.LightGray;
            }

        }

        private void texUser_Leave(object sender, EventArgs e)
        {
            if (texUser.Text == "")
            {
                texUser.Text = "Usuario";
                texUser.ForeColor = Color.LightGray;

            }
        }

        private void texPassword_Enter(object sender, EventArgs e)
        {
            if (texPassword.Text == "password")
            {
                texPassword.Text = "";
                texPassword.ForeColor = Color.LightGray;
                texPassword.UseSystemPasswordChar = true;
            }
        }

        private void texPassword_Leave(object sender, EventArgs e)
        {
            if (texPassword.Text == "")
            {
                texPassword.Text = "password";
                texPassword.ForeColor = Color.LightGray;
                texPassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peliculas frm = new Peliculas();/* Activa esto cuando ya este terminado el login de la base de datos*/
            frm.Show();
            this.Hide();


            if (texUser.Text != "Usuario") 
            {
                if (texPassword.Text != "password")
                {

                }
                else msgError("Ingrese su contraseña");
            
            }
            else msgError("Ingrese su usuario");
          
        }
        private void msgError(string msg)
        {
            lberror.Text = "    " + msg;
            lberror.Visible = true;
        }
    }

}
