using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions.Configuration;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;
using Microsoft.Identity.Client.Extensions.Msal;
using Presentacion1.UI_Admin.Login;
using Presentacion1.UI_Pricipal;

namespace Presentacion1.UI_User.Login
{
    public partial class LoginUser : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
        C_Ent_Regular R = new C_Ent_Regular();

        public LoginUser()
        {
            InitializeComponent();
        }


        private void btnShowUserAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin la = new LoginAdmin();
            la.Show();
            this.Hide();
        }

        private void btnAccesUser_Click(object sender, EventArgs e)
        {
           
            string query = "sp_UserLogin";
            using (SqlCommand command = new SqlCommand(query, Conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LoginUser", R.LoginUser).Value = txtUser.Text;
                command.Parameters.AddWithValue("@Password", R.Password).Value = txtPassUser.Text;
                try
                {
                    Conn.Open();
                    command.ExecuteNonQuery();

               
                    if (txtUser.Text == R.LoginUser && txtPassUser.Text == R.Password || txtUser.Text == "" && txtPassUser.Text == "" )
                    {
                        MessageBox.Show("Ingrese los datos correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido" + R.Nombre + "User ");
                        Pantalla_Principal pp = new Pantalla_Principal(false);
                        pp.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {

                    // Manejar la excepción aquí según tus necesidades
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
                Conn.Close();
            }
        }   

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            Sing_InUser si = new Sing_InUser();
            si.Show();
            this.Hide();
        }

        private void tbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (tbShowPass.Checked)
            {
                txtPassUser.PasswordChar = '\0';

            }
            else
            {
                txtPassUser.PasswordChar = '*';

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
