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

namespace Presentacion1.UI_Administracion
{
    public partial class AdminAjustesDeDatosVisita : Form
    {
        public AdminAjustesDeDatosVisita()
        {
            InitializeComponent();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Id")
            {
                txtID.Text = "";
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Id";
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Name")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Name";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Last Name")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Last Name";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Pass")
            {
                txtPass.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Pass";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtPuesto_Enter(object sender, EventArgs e)
        {
            if (txtPuesto.Text == "Puesto")
            {
                txtPuesto.Text = "";
            }
        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {
            if (txtPuesto.Text == "")
            {
                txtPuesto.Text = "Puesto";
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            C_Ent_Regular objEntidad = new C_Ent_Regular();
            C_Neg_Admin objNeg = new C_Neg_Admin();
            try
            {
                objEntidad.ID_User = Convert.ToInt32(DGV_Admin.SelectedRows[0].Cells["ID_User"].Value);
                objEntidad.Nombre = txtNombre.Text.ToUpper();
                objEntidad.Apellido = txtApellido.Text.ToUpper();
                objEntidad.LoginUser = txtUser.Text.ToUpper();
                objEntidad.Password = txtPass.Text.ToUpper();
                objEntidad.Email = txtEmail.Text.ToUpper();
                objEntidad.Puesto = txtPuesto.Text.ToUpper();

                objNeg.AddUserRegular(objEntidad);
                accionestTabla();
                Limpiar();
                MostrarInfo();
                MessageBox.Show("Registro Guardado correctamente.");

            }
            catch (SqlException ex)
            {

                // Manejar la excepción aquí según tus necesidades
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void btnUpUser_Click(object sender, EventArgs e)
        {
            C_Ent_Regular objEntidad = new C_Ent_Regular();
            C_Neg_Admin objNeg = new C_Neg_Admin();

            objEntidad.ID_User = Convert.ToInt32(DGV_Admin.SelectedRows[0].Cells["ID_User"].Value);
            objEntidad.Nombre = txtNombre.Text.ToUpper();
            objEntidad.Apellido = txtApellido.Text.ToUpper();
            objEntidad.LoginUser = txtUser.Text.ToUpper();
            objEntidad.Password = txtPass.Text.ToUpper();
            objEntidad.Email = txtEmail.Text.ToUpper();
            objEntidad.Puesto = txtPuesto.Text.ToUpper();

            objNeg.UpdateUserRegular(objEntidad);
            accionestTabla();
            Limpiar();
            MostrarInfo();
            MessageBox.Show("Registro Actualizado correctamente.");

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            C_Ent_Regular objEntidad = new C_Ent_Regular();
            C_Neg_Admin objNeg = new C_Neg_Admin();
            try
            {
                if (DGV_Admin.SelectedRows.Count > 0)
                {
                    objEntidad.ID_User = Convert.ToInt32(DGV_Admin.SelectedRows[0].Cells["ID_User"].Value);
                    MessageBox.Show("Registro eliminado correctamente.");

                }
                objNeg.DeleteUserRegular(objEntidad);
                MostrarInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void accionestTabla()
        {
            DGV_Admin.Columns[0].Width = 80;
            DGV_Admin.Columns[1].Width = 120;
            DGV_Admin.Columns[2].Width = 120;
            DGV_Admin.Columns[3].Width = 100;
            DGV_Admin.Columns[4].Width = 100;
            DGV_Admin.Columns[5].Width = 120;
            DGV_Admin.Columns[6].Width = 100;
        }
        public void Limpiar()
        {
            txtID.Text = "Id";
            txtNombre.Text = "Name";
            txtApellido.Text = "Last Name";
            txtUser.Text = "User";
            txtPass.Text = "Pass";
            txtEmail.Text = "Email";
            txtPuesto.Text = "Puesto";
        }
        private void MostrarInfo()
        {
            C_Neg_Admin objNeg = new C_Neg_Admin();
            DataTable dt = objNeg.ListarUsuarios();
            DGV_Admin.DataSource = dt;
        }

        private void DGV_Admin_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Admin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Admin.SelectedRows[0];
                txtID.Text = selectedRow.Cells["ID_User"].Value.ToString();
                txtUser.Text = selectedRow.Cells["LoginUser"].Value.ToString();
                txtPass.Text = selectedRow.Cells["Password"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPuesto.Text = selectedRow.Cells["Puesto"].Value.ToString();


            }
        }

        private void AdminAjustesDeDatosVisita_Load(object sender, EventArgs e)
        {
            MostrarInfo();
        }
    }
}
