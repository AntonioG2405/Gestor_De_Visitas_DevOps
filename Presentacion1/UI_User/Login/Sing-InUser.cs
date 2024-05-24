using Capa_Entidad;
using Capa_Negocio;
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

namespace Presentacion1.UI_User.Login
{
    public partial class Sing_InUser : Form
    {
        public Sing_InUser()
        {
            InitializeComponent();
        }

        private void tbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (tbShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';

            }
            else
            {
                txtPass.PasswordChar = '*';

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            C_Ent_Regular objEntidad = new C_Ent_Regular();
            C_Neg_Admin objNeg = new C_Neg_Admin();
            try
            {
                //objEntidad.ID_User = Convert.ToInt32(DGV_Admin.SelectedRows[0].Cells["ID_User"].Value);
                objEntidad.Nombre = txtNombre.Text.ToUpper();
                objEntidad.Apellido = txtApellido.Text.ToUpper();
                objEntidad.LoginUser = txtUser.Text.ToUpper();
                objEntidad.Password = txtPass.Text.ToUpper();
                objEntidad.Email = txtEmail.Text.ToUpper();
                objEntidad.Puesto = txtPass.Text.ToUpper();

                objNeg.AddUserRegular(objEntidad);

                txtUser.Text = "";
                txtNombre.Text = "";
                txtPass.Text = "";
                txtEmail.Text = "";
                txtPuesto.Text = "";
                txtApellido.Text = "";

                MessageBox.Show("Usuario Guardado correctamente.");

            }
            catch (SqlException ex)
            {

                // Manejar la excepción aquí según tus necesidades
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser lu = new LoginUser();
            lu.Show();
            this.Hide();
        }
    }
}
