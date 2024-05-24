using Capa_Entidad;
using Presentacion1.UI_Pricipal;
using Presentacion1.UI_User.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Capa_Negocio;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Presentacion1.UI_Admin.Login
{
    public partial class LoginAdmin : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btnShowUserLogin_Click(object sender, EventArgs e)
        {
            LoginUser lu = new LoginUser();
            lu.Show();
            this.Hide();
        }

        private void tbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (tbShowPass.Checked)
            {

                txtPassAdmin.PasswordChar = '\0';
            }
            else
            {
                txtPassAdmin.PasswordChar = '*';

            }
        }

        private void btnAccesAdmin_Click(object sender, EventArgs e)
        {

            C_Ent_Admin A = new C_Ent_Admin();
            string query = "sp_AdminLogin";
            using (SqlCommand command = new SqlCommand(query, Conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LoginAdmin", A.LoginAdmin).Value = txtUserAdmin.Text;
                command.Parameters.AddWithValue("@Password", A.Password).Value = txtPassAdmin.Text;
                try
                {
                    Conn.Open();
                    command.ExecuteNonQuery();

                  

                    if (txtUserAdmin.Text == "" && txtPassAdmin.Text == "" || txtUserAdmin.Text == A.LoginAdmin && txtPassAdmin.Text == A.Password)
                    {
                        MessageBox.Show("Ingrese los datos correctamente");
                    }
                    else 
                    {
                        MessageBox.Show("Bienvenido " + A.Nombre + "  Admin");
                        Pantalla_Principal pp = new Pantalla_Principal(true);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
